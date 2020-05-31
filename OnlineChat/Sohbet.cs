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
using System.Data.Odbc;
namespace OnlineChat
{
    public partial class Sohbet : Form
    {
        //VERİTABANI BAĞLANTISI-----------------------------------------------------------------------------------
        private static string sIp = "160.153.129.28"; // Sunucu IP Adresi
        private static string sDB = "haloo"; // Veritabanı
        private static string sKA = "haloo_user"; // Kullanıcı Adı
        private static string sSifre = "15864500"; // Şifre

        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=" + sIp + ";Database=" + sDB + ";Uid=" + sKA + ";Pwd='" + sSifre + "';");
        //VERİTABANI BAĞLANTISI-----------------------------------------------------------------------------------

        public Sohbet()
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

        public static string kullanici_id { get; set; }

        WebClient ftp = new WebClient();
        enum aylar
        {
            x, Ocak, Şubat, Mart, Nisan, Mayıs, Haziran, Temmuz, Ağustos, Eylül, Ekim, Kasım, Aralık
        }
        private void btn_kapat_Click(object sender, EventArgs e)
        {
            string tarih = DateTime.Now.ToLongDateString(); // sadece tarih
            string dakika = DateTime.Now.Minute.ToString(); // sadece dakika
            string saat = DateTime.Now.Hour.ToString(); // sadece saat
            string gun = DateTime.Now.Day.ToString(); // sadece gün
            string ay = DateTime.Now.Month.ToString(); // sadece ay
            int ay1 = Convert.ToInt32(ay);
            aylar a;
            a = (aylar)ay1;

            GirisSayfasi g1 = new GirisSayfasi();
            if (MessageBox.Show("Oturum Kapatılıyor...?", "Çıkış", MessageBoxButtons.YesNo, MessageBoxIcon.None, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                mysqlbaglan.Open();
                string online = ("Offline--");
                string son = (gun + " " + a + "**" + saat + ":" + dakika);
                MySqlCommand komutguncelle = mysqlbaglan.CreateCommand();
                MySqlCommand komutguncelle2 = mysqlbaglan.CreateCommand();
                komutguncelle.CommandText = ("Update Users set Durum='" + online + "'Where KullaniciAdi='" + kullanici_id + "'");
                komutguncelle2.CommandText = ("Update Users set Songorulme='" + son + "'Where KullaniciAdi='" + kullanici_id + "'");
                komutguncelle.ExecuteNonQuery();
                komutguncelle2.ExecuteNonQuery();
                MySqlCommand komutsil = new MySqlCommand("Delete From Users Where Misafir=1", mysqlbaglan);
                komutsil.ExecuteNonQuery();
                mysqlbaglan.Close();
                this.Close();
                g1.Show();
            }
        }

        private void Sohbet_Load(object sender, EventArgs e)
        {
            string saniye = DateTime.Now.Second.ToString(); // sadece saniye
            string dakika = DateTime.Now.Minute.ToString(); // sadece dakika


            button1.Enabled = true;
            richTextBox1.Enabled = false;
            richTextBox2.Enabled = false;
            richTextBox1.Clear();
            richTextBox2.Clear();


            //KULLANICILARI GÖSTERME KODU
            panel1.Controls.Clear();
            kisiler kullan = new kisiler();
            kullan.TopLevel = false;
            panel1.Controls.Add(kullan);
            kullan.Show();
            kullan.Dock = DockStyle.Fill;
            kullan.BringToFront();
            //KULLANICILARI GÖSTERME KODU SONU

            //BAŞLANGIÇTA SOHBETE BAĞLANMA KODU

            try
            {
                ftp.Credentials = new NetworkCredential("afbonlinechat", "123456Ali");
                richTextBox1.Text = ftp.DownloadString("ftp://files.000webhost.com/Panel.txt");
                timer1.Start();
                richTextBox2.Enabled = true;
                richTextBox1.Enabled = true;



            }
            catch
            {
                MessageBox.Show("Sunucu Bağlantı Hatası");
                button1.Enabled = true;
                richTextBox1.Enabled = false;
                richTextBox2.Enabled = false;
                richTextBox1.Clear();
                richTextBox2.Clear();
            }
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            profil2 kullan = new profil2();
            kullan.TopLevel = false;
            panel1.Controls.Add(kullan);
            kullan.Show();
            kullan.Dock = DockStyle.Fill;
            kullan.BringToFront();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            kisiler kullan = new kisiler();
            kullan.TopLevel = false;
            panel1.Controls.Add(kullan);
            kullan.Show();
            kullan.Dock = DockStyle.Fill;
            kullan.BringToFront();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {

            try
            {
                ftp.Credentials = new NetworkCredential("afbonlinechat", "123456Ali");
                richTextBox1.Text = ftp.DownloadString("ftp://files.000webhost.com/Panel.txt");
                timer1.Start();
                richTextBox2.Enabled = true;
                richTextBox1.Enabled = true;



            }
            catch
            {
                MessageBox.Show("Sunucu Bağlantı Hatası");
                button1.Enabled = true;
                richTextBox1.Enabled = false;
                richTextBox2.Enabled = false;
                richTextBox1.Clear();
                richTextBox2.Clear();
            }
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
            richTextBox1.ScrollToCaret();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string saniye = DateTime.Now.Second.ToString(); // sadece saniye
            string dakika = DateTime.Now.Minute.ToString(); // sadece dakika
            string saat = DateTime.Now.Hour.ToString(); // sadece saat
            try
            {
                ftp.Credentials = new NetworkCredential("afbonlinechat", "123456Ali");
                ftp.UploadString("ftp://files.000webhost.com/Panel.txt", richTextBox1.Text + "(" + saat + ":" + dakika + ":" + saniye + ")---" + kullanici_id + " : " + richTextBox2.Text + "\n");

            }
            catch
            {
                MessageBox.Show("Sunucu Bağlantısı Hatası");
                button1.Enabled = true;
                richTextBox1.Enabled = false;
                richTextBox2.Enabled = false;
                richTextBox1.Clear();
                richTextBox2.Clear();
            }
            richTextBox2.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();

            try
            {
                ftp.Credentials = new NetworkCredential("afbonlinechat", "123456Ali");
                richTextBox1.Text = ftp.DownloadString("ftp://files.000webhost.com/Panel.txt");




            }
            catch
            {
                MessageBox.Show("Sunucu Bağlantısında aksaklık oldu.Yeniden Bağlanmayı Deneyin.");
                button1.Enabled = true;
                richTextBox1.Enabled = false;
                richTextBox2.Enabled = false;
                richTextBox1.Clear();
                richTextBox2.Clear();
            }
            timer1.Start();
        }
        
    }

}
