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


namespace OnlineChat
{
    public partial class kisiler : Form
    {
        //VERİTABANI BAĞLANTISI-----------------------------------------------------------------------------------
        private static string sIp = "160.153.129.28"; // Sunucu IP Adresi
        private static string sDB = "haloo"; // Veritabanı
        private static string sKA = "haloo_user"; // Kullanıcı Adı
        private static string sSifre = "15864500"; // Şifre

        public MySqlConnection mysqlbaglan = new MySqlConnection("Server=" + sIp + ";Database=" + sDB + ";Uid=" + sKA + ";Pwd='" + sSifre + "';");
        //VERİTABANI BAĞLANTISI-----------------------------------------------------------------------------------

        public kisiler()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void kisiler_Load(object sender, EventArgs e)
        {
            //Kullanıcıları Tara

            mysqlbaglan.Open(); // MySQL bağlantımızı açıyoruz.
            if (mysqlbaglan.State != ConnectionState.Closed)
            {
                // Her seferinde butona basarsa aynı verileri tekrar yazdıracak bu yüzden
                // ListView içeriğini temizliyoruz.
                listView1.Items.Clear();

                // Eğer tablo içi boş ise kayıtlı kullanıcı yok diye bildirim verdireceğiz.
                bool kontrolEt = false;

                // Sorgumuzu gönderiyoruz.
                string sql = "SELECT * FROM `Users`";
                MySqlCommand cmd = new MySqlCommand(sql, mysqlbaglan);
                MySqlDataReader rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    // Eğer kayıtlı kullanıcı var ise
                    // ListView'e verileri çekecek.

                    kontrolEt = true;
                    ListViewItem Kullanici = new ListViewItem(rdr["KullaniciAdi"].ToString());
                    Kullanici.SubItems.Add(rdr["Songorulme"].ToString());
                    Kullanici.SubItems.Add(rdr["Durum"].ToString());

                    listView1.Items.Add(Kullanici);
                }
                // Bağlantılarımı kapatıyoruz.
                rdr.Close();
                mysqlbaglan.Close();

                // Eğer tablo boş ise bir mesaj gönderiyoruz.
                if (kontrolEt == false)
                {
                    MessageBox.Show("Kayıtlı üye yok !");
                    return;
                }
            }
            else
            {
                // İnternet bağlantımız yoksa bir mesaj veriyoruz.
                MessageBox.Show("Bağlantı yok");
            }
        }
    }
}
