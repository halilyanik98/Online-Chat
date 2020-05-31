using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using MySql.Data.MySqlClient;
using System.Net.Mail;

namespace OnlineChat
{
    public partial class onay : Form
    {
        //VERİTABANI BAĞLANTISI-----------------------------------------------------------------------------------
        private static string sIp = "160.153.129.28"; // Sunucu IP Adresi
        private static string sDB = "haloo"; // Veritabanı
        private static string sKA = "haloo_user"; // Kullanıcı Adı
        private static string sSifre = "15864500"; // Şifre

        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=" + sIp + ";Database=" + sDB + ";Uid=" + sKA + ";Pwd='" + sSifre + "';");
        //VERİTABANI BAĞLANTISI-----------------------------------------------------------------------------------

        public onay()
        {
            InitializeComponent();
        }
        //SAYFAYI SÜRÜKLEME KODU-------------------------------------------
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
        public static string kullanici_id { get; set; }
        public static string kullanici_adi { get; set; }
        //
        public static string kullanici_parola { get; set; }
        //
        public static string kullanici_eposta { get; set; }
        //
        public static string kullanici_adin { get; set; }
        //
        public static string kullanici_soyadi { get; set; }
        //
        public static string kullanici_cinsiyet { get; set; }

        enum aylar
        {
            x, Ocak, Şubat, Mart, Nisan, Mayıs, Haziran, Temmuz, Ağustos, Eylül, Ekim, Kasım, Aralık
        }
        private void tb_onay_OnValueChanged(object sender, EventArgs e)
        {
            //SINIRI KODU
            {
                foreach (var ctl in tb_onay.Controls)
                {

                    if (ctl.GetType() == typeof(TextBox))
                    {
                        var txt = (TextBox)ctl;
                        txt.MaxLength = 5;

                    }

                }
            }
        }

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            //ONAY SAYFASINI KAPATIP KAYIT SAYFASINA GERİ DÖNME KODU
            kayit k1 = new kayit();
            this.Close();
            k1.Show();
        }

        private void btn_talep_Click(object sender, EventArgs e)
        {
            string tarih = DateTime.Now.ToLongDateString(); // sadece tarih
            string dakika = DateTime.Now.Minute.ToString(); // sadece dakika
            string saat = DateTime.Now.Hour.ToString(); // sadece saat
            string gun = DateTime.Now.Day.ToString(); // sadece gün
            string ay = DateTime.Now.Month.ToString(); // sadece ay
            int ay1 = Convert.ToInt32(ay);
            aylar a;
            a = (aylar)ay1;



            mysqlbaglan.Open();
            if (mysqlbaglan.State != ConnectionState.Closed)
            {
                string sql = "SELECT * FROM `DogrulamaKodu` WHERE `Eposta` = '" + kullanici_eposta + "' AND `Kod` = '" + tb_onay.Text + "' LIMIT 1";
                MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglan);
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr.Read())
                {

                    mysqlbaglan.Close();
                    if (mysqlbaglan.State != ConnectionState.Open)
                    {

                        mysqlbaglan.Close();
                        if (mysqlbaglan.State != ConnectionState.Open)
                        {
                            string online = ("Online ++");
                            string son = (gun + " " + a + "**" + saat + ":" + dakika);
                            MySqlCommand komutVer1 = mysqlbaglan.CreateCommand();
                            komutVer1.CommandText = "INSERT INTO Users (KullaniciAdi,Parola,Adi,Soyadi,EPosta,Cinsiyet,Durum,Songorulme) VALUES(@isim,@sifre,@adi,@soyadi,@eposta,@cinsiyet,@durum,@songorulme)";
                            komutVer1.Parameters.AddWithValue("@isim", kullanici_id);
                            komutVer1.Parameters.AddWithValue("@sifre", kullanici_parola);
                            komutVer1.Parameters.AddWithValue("@adi", kullanici_adi);
                            komutVer1.Parameters.AddWithValue("@soyadi", kullanici_soyadi);
                            komutVer1.Parameters.AddWithValue("@eposta", kullanici_eposta);
                            komutVer1.Parameters.AddWithValue("@cinsiyet", kullanici_cinsiyet);
                            komutVer1.Parameters.AddWithValue("@durum", online);
                            komutVer1.Parameters.AddWithValue("@songorulme", son);

                            mysqlbaglan.Open();
                            komutVer1.ExecuteNonQuery();

                            AutoClosingMessageBox.Show("Kayıt Başarılı.Sunucuya Bağlanıyorsunuz.", "Hoşgeldin ", 5000);
                            //MessageBox.Show("Kayıt olundu !");

                            //KAYIT SAYFASINI AÇIP ANA EKRANI KAYBETME KODU
                            Sohbet.kullanici_id = kullanici_id;
                            Sohbet s1 = new Sohbet();
                            s1.Show();
                            this.Hide();
                            //KAYIT SAYFASINI AÇIP ANA EKRANI KAYBETME KODU SONU

                        }
                    }
                    else
                    {
                        AutoClosingMessageBox.Show("Doğrulama Kodu Yanlış.", "HATA", 3000);
                    }
                    rdr.Close();
                }
                else
                {
                    AutoClosingMessageBox.Show("Bağlantınızı Kontrol Edin", "HATA", 3000);
                }
                mysqlbaglan.Close();

            }
        }

        private void onay_Load(object sender, EventArgs e)
        {

        }
    }
}