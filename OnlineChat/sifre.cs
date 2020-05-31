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
    public partial class sifre : Form
    {
        //VERİTABANI BAĞLANTISI--------------------------------------------------------------------------------------------------------------
        private static string sIp = "160.153.129.28"; // Sunucu IP Adresi
        private static string sDB = "haloo"; // Veritabanı
        private static string sKA = "haloo_user"; // Kullanıcı Adı
        private static string sSifre = "15864500"; // Şifre

        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=" + sIp + ";Database=" + sDB + ";Uid=" + sKA + ";Pwd='" + sSifre + "';");
        //VERİTABANI BAĞLANTISI--------------------------------------------------------------------------------------------------------------

        public sifre()
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

        private void btn_tamekran_Click(object sender, EventArgs e)
        {
            //TAM EKRAN YAPMA ,TAM EKRANDAN ÇIKMA KODU
            WindowState = WindowState == FormWindowState.Maximized
                         ? FormWindowState.Normal
                         : FormWindowState.Maximized;
            //TAM EKRAN YAPMA ,TAM EKRANDAN ÇIKMA KODU SONU
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

        private void tb_eposta_OnValueChanged(object sender, EventArgs e)
        {
            //EPOSTA SINIR KODU
            {
                foreach (var ctl in tb_id.Controls)
                {
                    if (ctl.GetType() == typeof(TextBox))
                    {
                        var txt = (TextBox)ctl;
                        txt.MaxLength = 25;
                    }
                }
            }
            //EPOSTA SINIR KODU SONU
        }

        private void btn_talep_Click(object sender, EventArgs e)
        {
            mysqlbaglan.Open(); // MySQL bağlantımızı açıyoruz.
            if (mysqlbaglan.State != ConnectionState.Closed)
            {
                string sql = "SELECT * FROM `Users` WHERE `KullaniciAdi` = '" + tb_id.Text + "' AND `EPosta` = '" + tb_eposta.Text + "'LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglan);
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {
                    //yeni satır
                    // E Psota mesajı Gönderme Kodu
                    MailMessage mesaj = new MailMessage();
                    mesaj.Subject = ("OnlineChat Şifre Talebi ");
                    mesaj.From = new MailAddress("afbonlinechat@gmail.com");
                    mesaj.To.Add(tb_eposta.Text);
                    mesaj.Body = ("Merhaba " + rdr["Adi"].ToString() + "  " + rdr["Soyadi"].ToString() + "  Kullandığın Parola :" + rdr["Parola"].ToString());

                    SmtpClient server = new SmtpClient("smtp.gmail.com");
                    server.Credentials = new System.Net.NetworkCredential("afbonlinechat@gmail.com", "123456Ali");
                    server.Port = 587;
                    server.EnableSsl = true;﻿

                    server.Send(mesaj);
                    AutoClosingMessageBox.Show("Şifreni Az Önce E-Posta Adresine Gönderdik.", "Başarılı", 3000);
                    // E Psota mesajı Gönderme Kodu Sonu
                }
                else
                {
                    AutoClosingMessageBox.Show("Böyle bir kullanıcı yok, veri getirilemez.", "Hatalı İşlem", 3000);
                }
                // Her şey tamam ise bağlantıları kapatıyoruz..
                rdr.Close();
                mysqlbaglan.Close();
            }
            else
            {
                // İnternet bağlantımız yoksa bir mesaj veriyoruz.
                AutoClosingMessageBox.Show("Bağlantınızı Kontrol Edin", "Hay Aksii", 3000);
            }
        }

        private void sifre_Load(object sender, EventArgs e)
        {

        }
    }
}
