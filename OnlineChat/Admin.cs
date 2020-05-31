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
using System.Net.Mail;

namespace OnlineChat
{
    public partial class Admin : Form
    {
        //VERİTABANI BAĞLANTISI-----------------------------------------------------------------------------------
        private static string sIp = "160.153.129.28"; // Sunucu IP Adresi
        private static string sDB = "haloo"; // Veritabanı
        private static string sKA = "haloo_user"; // Kullanıcı Adı
        private static string sSifre = "15864500"; // Şifre

        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=" + sIp + ";Database=" + sDB + ";Uid=" + sKA + ";Pwd='" + sSifre + "';");
        //VERİTABANI BAĞLANTISI-----------------------------------------------------------------------------------
        public Admin()
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
        private void btn_kapat_Click(object sender, EventArgs e)
        {
            //Admin SAYFASINI KAPATIP GİRİŞ SAYFASINA GİTME KODU
            GirisSayfasi g1 = new GirisSayfasi();
            this.Close();
            g1.Show();
            //Admin SAYFASINI KAPATIP GİRİŞ SAYFASINA GİTME KODU SONU
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

        private void K_id_OnValueChanged(object sender, EventArgs e)
        {
            //VERİ SINIRI
            {
                foreach (var ctl in K_id.Controls)
                {
                    if (ctl.GetType() == typeof(TextBox))
                    {
                        var txt = (TextBox)ctl;
                        txt.MaxLength = 10;
                    }
                }
            }
        }

        private void K_parola_OnValueChanged(object sender, EventArgs e)
        {
            //VERİ SINIRI
            {
                foreach (var ctl in K_parola.Controls)
                {
                    if (ctl.GetType() == typeof(TextBox))
                    {
                        var txt = (TextBox)ctl;
                        txt.MaxLength = 10;
                    }
                }
            }
        }

        private void K_ad_OnValueChanged(object sender, EventArgs e)
        {
            //VERİ SINIRI
            {
                foreach (var ctl in K_ad.Controls)
                {
                    if (ctl.GetType() == typeof(TextBox))
                    {
                        var txt = (TextBox)ctl;
                        txt.MaxLength = 20;
                    }
                }
            }
        }

        private void K_soyad_OnValueChanged(object sender, EventArgs e)
        {
            //VERİ SINIRI
            {
                foreach (var ctl in K_soyad.Controls)
                {
                    if (ctl.GetType() == typeof(TextBox))
                    {
                        var txt = (TextBox)ctl;
                        txt.MaxLength = 15;
                    }
                }
            }
        }

        private void K_eposta_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {

        }

        private void Admin_Load(object sender, EventArgs e)
        {
            //kULLANICI ADI KISMINA KARAKTER GİRİLEMEZ
            K_id.Enabled = false;

            
            mysqlbaglan.Open(); // MySQL bağlantımızı açıyoruz.
            string sql = "SELECT * FROM `Users`";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, mysqlbaglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            mysqlbaglan.Close();

            mysqlbaglan.Open(); // MySQL bağlantımızı açıyoruz.
            string sql1 = "SELECT * FROM `DogrulamaKodu`";
            MySqlDataAdapter da1 = new MySqlDataAdapter(sql1, mysqlbaglan);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;
            mysqlbaglan.Close();
        }

        private void btn_guncelle_Click_1(object sender, EventArgs e)
        {

            if (K_id.Text == ("") || K_parola.Text == ("") || K_ad.Text == ("") || K_soyad.Text == ("") || K_eposta.Text == ("") || K_cinsiyet.Text == (""))
            {
                AutoClosingMessageBox.Show("Tablodan Bir Kullanıcı Seçiniz", "HATA", 3000);
            }
            else
            {
                mysqlbaglan.Open();
                if (mysqlbaglan.State != ConnectionState.Closed)
                {
                    {
                        mysqlbaglan.Close();
                        mysqlbaglan.Open();
                        MySqlCommand komutVer1 = mysqlbaglan.CreateCommand();
                        MySqlCommand komutVer2 = mysqlbaglan.CreateCommand();
                        MySqlCommand komutVer3 = mysqlbaglan.CreateCommand();
                        MySqlCommand komutVer4 = mysqlbaglan.CreateCommand();
                        MySqlCommand komutVer5 = mysqlbaglan.CreateCommand();

                        komutVer1.CommandText = "Update Users set Parola='" + K_parola.Text + "' where KullaniciAdi='" + K_id.Text + "'";
                        komutVer2.CommandText = "Update Users set Adi='" + K_ad.Text + "' where KullaniciAdi='" + K_id.Text + "'";
                        komutVer3.CommandText = "Update Users set Soyadi='" + K_soyad.Text + "' where KullaniciAdi='" + K_id.Text + "'";
                        komutVer4.CommandText = "Update Users set EPosta='" + K_eposta.Text + "' where KullaniciAdi='" + K_id.Text + "'";
                        komutVer5.CommandText = "Update Users set Cinsiyet='" + K_cinsiyet.Text + "' where KullaniciAdi='" + K_id.Text + "'";
                        komutVer1.ExecuteNonQuery();
                        komutVer2.ExecuteNonQuery();
                        komutVer3.ExecuteNonQuery();
                        komutVer4.ExecuteNonQuery();
                        komutVer5.ExecuteNonQuery();
                        AutoClosingMessageBox.Show("Bilgiler Güncellendi.", "Başarılı", 1500);
                        mysqlbaglan.Close();
                        // Doğrulama kodu mesajı Gönderme Kodu                                    HATA 1
                        MailMessage mesaj = new MailMessage();
                        mesaj.Subject = ("Online Chat Hesap Ayarları");
                        mesaj.From = new MailAddress("afbonlinechat@gmail.com");
                        mesaj.To.Add(K_eposta.Text);
                        mesaj.Body = ("İD :" + K_id.Text + "\n Parola :" + K_parola.Text + "\n Kullanıcı Adı :" + K_ad.Text + "\n Kullanıcı Soyadı :" + K_soyad.Text + "\n E_Posta Adresi :" + K_eposta.Text + "\n Cinsiyet :" + K_cinsiyet.Text);


                        SmtpClient server = new SmtpClient("smtp.gmail.com");
                        server.Credentials = new System.Net.NetworkCredential("afbonlinechat@gmail.com", "123456Ali");
                        server.Port = 587;
                        server.EnableSsl = true;﻿

                    server.Send(mesaj);
                    }
                    // Her şey tamam ise bağlantıları kapatıyoruz..

                    mysqlbaglan.Close();
                }
                else
                {
                    // İnternet bağlantımız yoksa bir mesaj veriyoruz.
                    AutoClosingMessageBox.Show("Bilgiler Yüklenemedi", "HATA", 1500);
                }
            }


            
        }

        private void K_cinsiyet_OnValueChanged(object sender, EventArgs e)
        {
            //VERİ SINIRI
            {
                foreach (var ctl in K_cinsiyet.Controls)
                {
                    if (ctl.GetType() == typeof(TextBox))
                    {
                        var txt = (TextBox)ctl;
                        txt.MaxLength = 5;
                    }
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //TABLODA SEÇİLEN KULLANICININ BİLGİLERİNİ TEXTBOX'A ATMA KODU
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            K_id.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            K_parola.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            K_ad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            K_soyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            K_eposta.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            K_cinsiyet.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Admin_Load_1(object sender, EventArgs e)
        {
            //LOAD SAYFA AÇILIRKEN ÇALIŞACAK KODLAR
            K_id.Enabled = false;
            
            


            mysqlbaglan.Open(); // MySQL bağlantımızı açıyoruz.
            string sql = "SELECT * FROM `Users`";
            MySqlDataAdapter da = new MySqlDataAdapter(sql, mysqlbaglan);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            mysqlbaglan.Close();

            mysqlbaglan.Open(); // MySQL bağlantımızı açıyoruz.
            string sql1 = "SELECT * FROM `DogrulamaKodu`";
            MySqlDataAdapter da1 = new MySqlDataAdapter(sql1, mysqlbaglan);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView2.DataSource = dt1;
            mysqlbaglan.Close();
        }
    }
}
