using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data.Odbc;

namespace OnlineChat
{
    public partial class GirisSayfasi : Form
    {
        //VERİTABANI BAĞLANTISI-----------------------------------------------------------------------------------
        private static string sIp = "160.153.129.28"; // Sunucu IP Adresi
        private static string sDB = "haloo"; // Veritabanı
        private static string sKA = "haloo_user"; // Kullanıcı Adı
        private static string sSifre = "15864500"; // Şifre

        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=" + sIp + ";Database=" + sDB + ";Uid=" + sKA + ";Pwd='" + sSifre + "';");
        //VERİTABANI BAĞLANTISI-----------------------------------------------------------------------------------
        public GirisSayfasi()
        {
            InitializeComponent();
        }
        //SAYFAYI SÜRÜKLEME KODU
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST)
                m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        //SAYFA SÜRÜKLEME KODU SONU

        //OTOMATİK KAPANAN MessageBox KODU
        public class AutoClosingMessageBox
        {
            System.Threading.Timer _timeoutTimer;
            string _caption;
            AutoClosingMessageBox(string text, string caption, int timeout)
            {
                _caption = caption;
                _timeoutTimer = new System.Threading.Timer(OnTimerElapsed,
                    null, timeout, System.Threading.Timeout.Infinite);
                using (_timeoutTimer)
                    MessageBox.Show(text, caption);
            }
            public static void Show(string text, string caption, int timeout)
            {
                new AutoClosingMessageBox(text, caption, timeout);
            }
            void OnTimerElapsed(object state)
            {
                IntPtr mbWnd = FindWindow("#32770", _caption);
                if (mbWnd != IntPtr.Zero)
                    SendMessage(mbWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero);
                _timeoutTimer.Dispose();
            }
            const int WM_CLOSE = 0x0010;
            [System.Runtime.InteropServices.DllImport("user32.dll", SetLastError = true)]
            static extern IntPtr FindWindow(string lpClassName, string lpWindowName);
            [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
            static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, IntPtr wParam, IntPtr lParam);
        }
        //OTOMATİK KAPANAN MessageBox KODU SONU

        //ENUM BELİRLEME KODU
        enum aylar
        {
            x, Ocak, Şubat, Mart, Nisan, Mayıs, Haziran, Temmuz, Ağustos, Eylül, Ekim, Kasım, Aralık
        }
        //ENUM BELİRLEME KODU SONU
        private void GirisSayfasi_Load(object sender, EventArgs e)
        {

        }

        private void lb_versiyon_Click(object sender, EventArgs e)
        {

        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            //UYGULAMAYI TAMAMEN KAPATMA KODU
            Application.Exit();
            //UYGULAMAYI TAMAMEN KAPATMA KODU SONU
        }

        private void btn_simge_Click(object sender, EventArgs e)
        {
            //UYGULAMAYI SİMGE DURUMUNA GETİRME KODU
            WindowState = FormWindowState.Minimized;
            //UYGULAMAYI SİMGE DURUMUNA GETİRME KODU SONU
        }

        private void btn_tamekran_Click(object sender, EventArgs e)
        {
            //TAM EKRAN YAPMA ,TAM EKRANDAN ÇIKMA KODU
            WindowState = WindowState == FormWindowState.Maximized
                         ? FormWindowState.Normal
                         : FormWindowState.Maximized;
            //TAM EKRAN YAPMA ,TAM EKRANDAN ÇIKMA KODU SONU
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {
            //VERİTABANI BAĞLANTI KONTROL KODU
            mysqlbaglan.Open();
            if (mysqlbaglan.State != ConnectionState.Closed)
            {
                bunifuCustomLabel2.Text = "Çevrimiçi";
                bunifuCustomLabel2.ForeColor = Color.Green;
            }
            else
            {
                bunifuCustomLabel2.Text = "Çevrimdışı";
                bunifuCustomLabel2.ForeColor = Color.Red;
            }
            mysqlbaglan.Close();
            //VERİTABANI BAĞLANTI KONTROL KODU SONU
        }

        private void tb_id_OnValueChanged(object sender, EventArgs e)
        {
            //KULLANICI ADI SINIRI KODU
            {
                foreach (var ctl in tb_id.Controls)
                {
                    if (ctl.GetType() == typeof(TextBox))
                    {
                        var txt = (TextBox)ctl;
                        txt.MaxLength = 10;
                    }
                }
            }
            //KULLANICI ADI SINIRI KODU SONU
        }

        private void tb_sifre_OnValueChanged(object sender, EventArgs e)
        {
            //ŞİFRE GİZLEME KODU
            tb_sifre.isPassword = true;
            //ŞİFRE SINIRI KODU
            {
                foreach (var ctl in tb_sifre.Controls)
                {
                    if (ctl.GetType() == typeof(TextBox))
                    {
                        var txt = (TextBox)ctl;
                        txt.MaxLength = 10;
                    }
                }
            }
            //ŞİFRE SINIRI KODU SONU
        }

        private void lb_sifreunuttum_Click(object sender, EventArgs e)
        {
            //SİFRE SAYFASINI AÇIP ANA EKRANI KAYBETME KODU
            sifre s1 = new sifre();
            s1.Show();
            this.Hide();
            //SİFRE SAYFASINI AÇIP ANA EKRANI KAYBETME KODU SONU
        }

        private void misafir_CheckedChanged(object sender, EventArgs e)
        {
            if (misafir.Checked == true)
            {
                //ASCII KULLANILDI-RASTGELE KULLANICI OLUŞTURUP VERİ TABANINA KAYDETTİ
                Random rastgele = new Random();
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < 5; i++)
                {
                    int x = rastgele.Next(49, 56);
                    char karakter = Convert.ToChar(x);
                    sb.Append(karakter);

                }
                string misafirkullanici_id = ("Ms-" + sb);
                string kullanici_parola = ("1783261");
                int misafir_no = 1;
                string bilinmiyor = ("Bilinmiyor");



                //VERİ TABANI BAĞLANTI KODU
                mysqlbaglan.Open();
                if (mysqlbaglan.State != ConnectionState.Closed)
                {
                    MySqlCommand komutVer1 = mysqlbaglan.CreateCommand();
                    komutVer1.CommandText = "INSERT INTO Users (KullaniciAdi,Parola,Adi,Soyadi,EPosta,Cinsiyet,Misafir) VALUES(@isim,@sifre,@adi,@soyadi,@eposta,@cinsiyet,@misafir)";
                    komutVer1.Parameters.AddWithValue("@isim", misafirkullanici_id);
                    komutVer1.Parameters.AddWithValue("@sifre", kullanici_parola);
                    komutVer1.Parameters.AddWithValue("@adi", bilinmiyor);
                    komutVer1.Parameters.AddWithValue("@soyadi", bilinmiyor);
                    komutVer1.Parameters.AddWithValue("@eposta", bilinmiyor);
                    komutVer1.Parameters.AddWithValue("@cinsiyet", bilinmiyor);
                    komutVer1.Parameters.AddWithValue("@misafir", misafir_no);
                    komutVer1.ExecuteNonQuery();
                    mysqlbaglan.Close();
                    tb_id.Text = (misafirkullanici_id);
                    tb_sifre.Text = (kullanici_parola);
                    tb_id.Enabled = false;
                    tb_sifre.Enabled = false;
                    //VERİ TABANI BAĞLANTI KODU SONU
                }

            }
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            //GİRİŞ YAPILDIKTAN SONRA SAAT TARİH VERİLERİNİ ALMA KODU
            string tarih = DateTime.Now.ToLongDateString(); // sadece tarih
            string dakika = DateTime.Now.Minute.ToString(); // sadece dakika
            string saat = DateTime.Now.Hour.ToString(); // sadece saat
            string gun = DateTime.Now.Day.ToString(); // sadece gün
            string ay = DateTime.Now.Month.ToString(); // sadece ay
            int ay1 = Convert.ToInt32(ay);
            aylar a;
            a = (aylar)ay1;
            //GİRİŞ YAPILDIKTAN SONRA SAAT TARİH VERİLERİNİ ALMA KODU SONU
            mysqlbaglan.Open();
            if (mysqlbaglan.State != ConnectionState.Closed)
            {
                string sql = "SELECT * FROM `Users` WHERE `KullaniciAdi` = '" + tb_id.Text + "' AND `Parola` = '" + tb_sifre.Text + "' LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglan);
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    string online = ("Online ++");
                    mysqlbaglan.Close();
                    mysqlbaglan.Open();
                    MySqlCommand komutguncelle = mysqlbaglan.CreateCommand();
                    MySqlCommand komutguncelle2 = mysqlbaglan.CreateCommand();
                    komutguncelle.CommandText = ("Update Users set Durum='" + online + "'Where KullaniciAdi='" + tb_id.Text + "'");
                    komutguncelle2.CommandText = ("Update Users set Songorulme='" + gun + " " + a + "**" + saat + ":" + dakika + "'Where KullaniciAdi='" + tb_id.Text + "'");
                    komutguncelle.ExecuteNonQuery();
                    komutguncelle2.ExecuteNonQuery();
                    //KAYIT SAYFASINI AÇIP ANA EKRANI KAYBETME KODU
                    Sohbet.kullanici_id = tb_id.Text;
                    profil2.kullanici_adi = tb_id.Text;

                    Sohbet s1 = new Sohbet();
                    s1.Show();
                    this.Hide();
                    //KAYIT SAYFASINI AÇIP ANA EKRANI KAYBETME KODU SONU
                }
                else
                {
                    AutoClosingMessageBox.Show("Bilgilerinizi Kontrol Edin", "HATA", 3000);
                }
                rdr.Close();
            }
            else
            {
                AutoClosingMessageBox.Show("Bağlantınızı Kontrol Edin", "HATA", 3000);
            }
            mysqlbaglan.Close();
        }

        private void lb_kayit_Click(object sender, EventArgs e)
        {
            //KAYIT SAYFASINI AÇIP ANA EKRANI KAYBETME KODU
            kayit k1 = new kayit();
            k1.Show();
            this.Hide();
            //KAYIT SAYFASINI AÇIP ANA EKRANI KAYBETME KODU SONU
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //ADMİN PANELİNE BAĞLANMA KODU
            mysqlbaglan.Open();
            if (mysqlbaglan.State != ConnectionState.Closed)
            {
                string sql = "SELECT * FROM `Admin` WHERE `Aid` = '" + tb_id.Text + "' AND `Apw` = '" + tb_sifre.Text + "' LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglan);
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    mysqlbaglan.Close();
                    Admin adm = new Admin();
                    adm.Show();
                    this.Hide();
                }
                else
                {
                    AutoClosingMessageBox.Show("Bilgilerinizi Kontrol Edin", "HATA", 3000);
                }
                rdr.Close();
            }
            else
            {
                AutoClosingMessageBox.Show("Bağlantınızı Kontrol Edin", "HATA", 3000);
            }
            mysqlbaglan.Close();
            //ADMİN PANELİNE BAĞLANMA KODU
        }
    }
}
