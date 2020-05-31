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
using System.Net;

namespace OnlineChat
{
    public partial class profil2 : Form
    {
        //VERİTABANI BAĞLANTISI-----------------------------------------------------------------------------------
        private static string sIp = "160.153.129.28"; // Sunucu IP Adresi
        private static string sDB = "haloo"; // Veritabanı
        private static string sKA = "haloo_user"; // Kullanıcı Adı
        private static string sSifre = "15864500"; // Şifre

        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=" + sIp + ";Database=" + sDB + ";Uid=" + sKA + ";Pwd='" + sSifre + "';");
        //VERİTABANI BAĞLANTISI-----------------------------------------------------------------------------------
        public profil2()
        {
            InitializeComponent();
        }
        //OTOMATİK KAPANAN MessageBox KODU
        public static string kullanici_adi { get; set; }
        public static string cinsiyet { get; set; } 
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
        private void profil2_Load(object sender, EventArgs e)
        {
            mysqlbaglan.Open();
            if (mysqlbaglan.State != ConnectionState.Closed)
            {
                string sql = "SELECT * FROM `Users` WHERE `KullaniciAdi` = '" + kullanici_adi + "' LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglan);
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (!rdr.Read())
                {
                    AutoClosingMessageBox.Show("Bilgiler Yüklenemedi", "HATA", 1500);
                }
                else
                {
                    label6.Text = rdr["KullaniciAdi"].ToString();
                    label7.Text = rdr["Adi"].ToString();
                    label8.Text = rdr["Soyadi"].ToString();
                    label9.Text = rdr["EPosta"].ToString();
                    label10.Text = rdr["Cinsiyet"].ToString();
                }
                // Her şey tamam ise bağlantıları kapatıyoruz..
                rdr.Close();
                mysqlbaglan.Close();
            }
            else
            {
                // İnternet bağlantımız yoksa bir mesaj veriyoruz.
                AutoClosingMessageBox.Show("Bilgiler Yüklenemedi", "HATA", 1500);
            }
        }

        private void tb_eski_OnValueChanged(object sender, EventArgs e)
        {
            tb_eski.isPassword = true;
            //ŞİFRE SINIRI KODU
            {
                foreach (var ctl in tb_eski.Controls)
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

        private void tb_yeni_OnValueChanged(object sender, EventArgs e)
        {
            tb_yeni.isPassword = true;
            //ŞİFRE SINIRI KODU
            {
                foreach (var ctl in tb_yeni.Controls)
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

        private void btn_giris_Click(object sender, EventArgs e)
        {
            mysqlbaglan.Open();
            if (mysqlbaglan.State != ConnectionState.Closed)
            {
                string sql = "SELECT * FROM `Users` WHERE `KullaniciAdi` = '" + kullanici_adi + "' AND `Parola` = '" + tb_eski.Text + "' LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglan);
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (!rdr.Read())
                {
                    AutoClosingMessageBox.Show("Şifreni Hatalı Girdin", "Hata", 1500);
                }
                else
                {
                    mysqlbaglan.Close();
                    mysqlbaglan.Open();
                    MySqlCommand komutVer1 = mysqlbaglan.CreateCommand();
                    komutVer1.CommandText = "Update Users set Parola='" + tb_yeni.Text + "' where KullaniciAdi='" + label6.Text + "'";
                    komutVer1.ExecuteNonQuery();
                    AutoClosingMessageBox.Show("Şifre Değiştirildi.", "Başarılı", 1500);
                    mysqlbaglan.Close();
                    // Doğrulama kodu mesajı Gönderme Kodu                                    HATA 1
                    MailMessage mesaj = new MailMessage();
                    mesaj.Subject = ("OnlineChat Şifre Değişikliği");
                    mesaj.From = new MailAddress("afbonlinechat@gmail.com");
                    mesaj.To.Add(label9.Text);
                    mesaj.Body = ("Yeni Şifren :" + tb_yeni.Text);

                    SmtpClient server = new SmtpClient("smtp.gmail.com");
                    server.Credentials = new System.Net.NetworkCredential("afbonlinechat@gmail.com", "123456Ali");
                    server.Port = 587;
                    server.EnableSsl = true;﻿

                    server.Send(mesaj);
                }
                // Her şey tamam ise bağlantıları kapatıyoruz..
                rdr.Close();
                mysqlbaglan.Close();
            }
            else
            {
                // İnternet bağlantımız yoksa bir mesaj veriyoruz.
                AutoClosingMessageBox.Show("Bilgiler Yüklenemedi", "HATA", 1500);
            }
        }
    }
}
