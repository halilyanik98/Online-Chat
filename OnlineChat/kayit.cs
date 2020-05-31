using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Net.Mail;

namespace OnlineChat
{
    public partial class kayit : Form
    {
        //VERİTABANI BAĞLANTISI-----------------------------------------------------------------------------------
        private static string sIp = "160.153.129.28"; // Sunucu IP Adresi
        private static string sDB = "haloo"; // Veritabanı
        private static string sKA = "haloo_user"; // Kullanıcı Adı
        private static string sSifre = "15864500"; // Şifre

        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=" + sIp + ";Database=" + sDB + ";Uid=" + sKA + ";Pwd='" + sSifre + "';");
        //VERİTABANI BAĞLANTISI-----------------------------------------------------------------------------------

        public kayit()
        {
            InitializeComponent();
        }

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
                IntPtr mbWnd = FindWindow("#32770", _caption); // lpClassName is #32770 for MessageBox
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
        //SAYFA SÜRÜKLEME KODU SONU-----------------------------------------

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            GirisSayfasi g1 = new GirisSayfasi();
            this.Close();
            g1.Show();
        }

        private void btn_simge_Click(object sender, EventArgs e)
        {

            //UYGULAMAYI SİMGE DURUMUNA GETİRME KODU
            WindowState = FormWindowState.Minimized;
            //UYGULAMAYI SİMGE DURUMUNA GETİRME KODU SONU
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            //TAM EKRAN YAPMA ,TAM EKRANDAN ÇIKMA KODU
            WindowState = WindowState == FormWindowState.Maximized
                         ? FormWindowState.Normal
                         : FormWindowState.Maximized;
            //TAM EKRAN YAPMA ,TAM EKRANDAN ÇIKMA KODU SONU
        }

        private void tb_idbelirle_OnValueChanged(object sender, EventArgs e)
        {


            //KULLANICI ADI BELİRLEME SINIRI KODU
            {
                foreach (var ctl in tb_idbelirle.Controls)
                {

                    if (ctl.GetType() == typeof(TextBox))
                    {
                        var txt = (TextBox)ctl;
                        txt.MaxLength = 10;

                    }

                }

            }
            //KULLANICI ADI BELİRLEME SINIRI KODU SONU
        }

        private void tb_parolabelirle_OnValueChanged(object sender, EventArgs e)
        {
            //PAROLA GİZLEME KODU
            tb_parolabelirle.isPassword = true;
            //PAROLA BELİRLEME SINIRI KODU
            {
                foreach (var ctl in tb_parolabelirle.Controls)
                {

                    if (ctl.GetType() == typeof(TextBox))
                    {
                        var txt = (TextBox)ctl;
                        txt.MaxLength = 10;

                    }

                }

            }
            //PAROLA BELİRLEME SINIRI KODU SONU
        }

        private void tb_parolabelirle2_OnValueChanged(object sender, EventArgs e)
        {
            tb_parolabelirle2.isPassword = true;
            //PAROLA BELİRLEME SINIRI KODU
            {
                foreach (var ctl in tb_parolabelirle2.Controls)
                {

                    if (ctl.GetType() == typeof(TextBox))
                    {
                        var txt = (TextBox)ctl;
                        txt.MaxLength = 10;

                    }

                }

            }
            //PAROLA BELİRLEME SINIRI KODU SONU
        }

        private void tb_ad_OnValueChanged(object sender, EventArgs e)
        {
            // AD BELİRLEME SINIRI KODU
            {
                foreach (var ctl in tb_ad.Controls)
                {

                    if (ctl.GetType() == typeof(TextBox))
                    {
                        var txt = (TextBox)ctl;
                        txt.MaxLength = 20;

                    }

                }

            }
            //AD BELİRLEME SINIRI KODU SONU
        }

        private void tb_soyad_OnValueChanged(object sender, EventArgs e)
        {
            //PAROLA BELİRLEME SINIRI KODU
            {
                foreach (var ctl in tb_soyad.Controls)
                {

                    if (ctl.GetType() == typeof(TextBox))
                    {
                        var txt = (TextBox)ctl;
                        txt.MaxLength = 17;

                    }

                }

            }
            //PAROLA BELİRLEME SINIRI KODU SONU
        }

        private void tb_epostanelirle_OnValueChanged(object sender, EventArgs e)
        {
            //EPOSTA BELİRLEME SINIRI KODU
            {
                foreach (var ctl in tb_epostanelirle.Controls)
                {

                    if (ctl.GetType() == typeof(TextBox))
                    {
                        var txt = (TextBox)ctl;
                        txt.MaxLength = 25;

                    }

                }

            }
            //EPOSTA BELİRLEME SINIRI KODU SONU
        }

        private void btn_devam_Click(object sender, EventArgs e)
        {
            onay.kullanici_id = tb_idbelirle.Text;
            onay.kullanici_adi = tb_ad.Text;
            onay.kullanici_parola = tb_parolabelirle.Text;
            onay.kullanici_eposta = tb_epostanelirle.Text;
            onay.kullanici_adin = tb_ad.Text;
            onay.kullanici_soyadi = tb_soyad.Text;
            onay.kullanici_cinsiyet = lb_cinsiyet.Text;
            profil2.kullanici_adi = tb_idbelirle.Text;
            profil2.cinsiyet = lb_cinsiyet.Text; //



            if (tb_idbelirle.Text == ("") || (tb_idbelirle.Text.Length < 4))
            {
                AutoClosingMessageBox.Show("Kullanıcı Adınızı 4-8 Karakter Arası Girin", "HATA", 3000);
            }
            else if (tb_parolabelirle.Text == ("") || (tb_parolabelirle.Text.Length < 4))
            {
                AutoClosingMessageBox.Show("Parolanızı 4-8 Karakter Arası Girin", "HATA", 3000);
            }
            else if ((tb_parolabelirle2.Text.Length < 4) || (tb_parolabelirle2.Text != tb_parolabelirle.Text))
            {
                AutoClosingMessageBox.Show("Parolanız Eşleşmiyor", "HATA", 3000);
            }
            else if (tb_epostanelirle.Text == ("") || (tb_epostanelirle.Text.Length < 10))
            {
                AutoClosingMessageBox.Show("E-Postanızı Hatalı Girdiniz", "HATA", 3000);
            }
            else if (tb_ad.Text == ("") || (tb_ad.Text.Length < 3))
            {
                AutoClosingMessageBox.Show("Adınızı Boş Bırakmayın", "HATA", 3000);
            }
            else if (tb_soyad.Text == ("") || (tb_soyad.Text.Length < 3))
            {
                AutoClosingMessageBox.Show("Soyadınızı Boş Bırakmayın", "HATA", 3000);
            }
            else if (rb_erkek.Checked == false && rb_kadın.Checked == false)
            {
                AutoClosingMessageBox.Show("Cinsiyeti Seçin", "HATA", 3000);
            }
            else
            {
                //CİNSİYET SEÇİMİ VERİTABANINA YÜKLEME KODU
                if (rb_erkek.Checked == true)
                {
                    lb_cinsiyet.Text = rb_erkek.Text;
                }
                else if (rb_kadın.Checked == true)
                {
                    lb_cinsiyet.Text = rb_kadın.Text;
                }
                //CİNSİYET SEÇİMİ VERİTABANINA YÜKLEME KODU SONU
                onay.kullanici_cinsiyet = lb_cinsiyet.Text;
                //KAYIT OLMA KODU 
                bool durumNee = false;
                mysqlbaglan.Open();
                if (mysqlbaglan.State != ConnectionState.Closed)
                {
                    string sql = "SELECT * FROM `Users` WHERE `KullaniciAdi` = '" + tb_idbelirle.Text + "' LIMIT 1";
                    MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglan);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    int x = 0;
                    if (rdr.Read())
                    {
                        x++;
                    }
                    rdr.Close();
                    mysqlbaglan.Close();
                    if (x != 0)
                    {
                        durumNee = true;
                    }
                }
                else
                {
                    AutoClosingMessageBox.Show("Bağlantı Yok. Kayıt Gerçekleştirilemedi.", "Hata ", 3000);


                    //MessageBox.Show("Bağlantı yok, kayıt işlemi gerçekleşemez !");
                    return;
                }
                if (durumNee)
                {
                    AutoClosingMessageBox.Show("Böyle Bir Kullanıcı Var.", "Hata ", 3000);

                    //MessageBox.Show("Böyle bir kullanıcı var !");
                    return;
                }
                //E POSTA KULLANILIP KULLANILMADIĞINI KONTROL EDEN KOD 

                bool durumNee2 = false;
                mysqlbaglan.Open();
                if (mysqlbaglan.State != ConnectionState.Closed)
                {
                    string sql = "SELECT * FROM `Users` WHERE `EPosta` = '" + tb_epostanelirle.Text + "' LIMIT 1";
                    MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglan);
                    MySqlDataReader rdr = cmd.ExecuteReader();
                    int x = 0;
                    if (rdr.Read())
                    {
                        x++;
                    }
                    rdr.Close();
                    mysqlbaglan.Close();
                    if (x != 0)
                    {
                        durumNee2 = true;
                    }
                }
                else
                {
                    AutoClosingMessageBox.Show("Bağlantı Yok. Kayıt Gerçekleştirilemedi.", "Hata ", 3000);


                    //MessageBox.Show("Bağlantı yok, kayıt işlemi gerçekleşemez !");
                    return;
                }
                if (durumNee2)
                {

                    AutoClosingMessageBox.Show("Bu E-posta Adresi Daha Önce Kullanılmıştır.", "Hata", 3000);

                    //MessageBox.Show("Bu E-Posta Daha Önce Kullanılmıştır !");
                    return;
                }

                //ASCII KULLANILDI
                Random rastgele = new Random();
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < 5; i++)
                {
                    int x = rastgele.Next(49, 56);
                    char karakter = Convert.ToChar(x);
                    sb.Append(karakter);

                }
                // Doğrulama kodu mesajı Gönderme Kodu                                    HATA 1
                MailMessage mesaj = new MailMessage();
                mesaj.Subject = ("OnlineChat'e Hoşgeldin " + tb_ad.Text + "  " + tb_soyad.Text);
                mesaj.From = new MailAddress("afbonlinechat@gmail.com");
                mesaj.To.Add(tb_epostanelirle.Text);
                mesaj.Body = ("Doğrulama Kodunuz :" + sb);

                SmtpClient server = new SmtpClient("smtp.gmail.com");
                server.Credentials = new System.Net.NetworkCredential("afbonlinechat@gmail.com", "123456Ali");
                server.Port = 587;
                server.EnableSsl = true;﻿

                    server.Send(mesaj);

                    //2. VERİTABANINA DOĞRULAMA KODUNU KAYDETME KODU                               HATA 2
                    mysqlbaglan.Open();
                    if (mysqlbaglan.State != ConnectionState.Closed)
                    {
                        MySqlCommand komutVer2 = mysqlbaglan.CreateCommand();
                        komutVer2.CommandText = "INSERT INTO DogrulamaKodu (EPosta,Kod) VALUES(@eposta,@kod)";
                        komutVer2.Parameters.AddWithValue("@eposta", tb_epostanelirle.Text);
                        komutVer2.Parameters.AddWithValue("@kod", sb);

                        komutVer2.ExecuteNonQuery();

                        onay o1 = new onay();
                        this.Close();
                        o1.Show();

                    }
                    else
                    {
                        AutoClosingMessageBox.Show("Bağlantı yok, Onay Kodu Gönderilemedi ", "Tekrar Deneyin", 3000);

                        //MessageBox.Show("Bağlantı yok, kayıt işlemi gerçekleşemez !");
                    }
                    mysqlbaglan.Close();
                //KAYIT OLMA KODU SONU--------------------------------------------------------------------------------

                // Doğrulama kodu mesajı Gönderme Kodu Sonu
            }
        }

        private void kayit_Load(object sender, EventArgs e)
        {

        }
    }
}