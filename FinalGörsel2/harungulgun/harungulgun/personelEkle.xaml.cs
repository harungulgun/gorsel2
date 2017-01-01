using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Threading;

namespace harungulgun
{
    /// <summary>
    /// Interaction logic for personelEkle.xaml
    /// </summary>
    public partial class personelEkle : Window
    {
        MySqlConnection bag = new MySqlConnection("Server = localhost; Database = stoktakibi; Uid = root; Pwd=;");
        DispatcherTimer zaman;
        public personelEkle()
        {
            InitializeComponent();
            cinsiyet.Items.Add("Erkek");
            cinsiyet.Items.Add("Kız");
            zaman = new DispatcherTimer();
            zaman.Interval = new TimeSpan(0, 0, 1);
            zaman.Tick += Zaman_Tick;
            zaman.Start();
          
        }
        private void Zaman_Tick(object sender, EventArgs e)
        {
            MySqlCommand cm = new MySqlCommand("Select * from personel", bag);
            MySqlDataAdapter ad = new MySqlDataAdapter(cm);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            personelgoster.ItemsSource = tb.AsDataView();

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            AnaEkran ana = new AnaEkran();
            ana.Show();
            this.Close();
           
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            
        }
     
     

        private void button_Click(object sender, RoutedEventArgs e)
        {
            bag.Open();
            MySqlCommand ekle = new MySqlCommand("INSERT INTO personel(personelTc,personelAd,personelSoyad,cinsiyet,tarih) VALUES ('" + tcno.Text + "','" + perad.Text+ "','" + persoyad.Text + "','" + cinsiyet.Text + "','" +gtarih.Text +"')", bag);
            ekle.ExecuteNonQuery();
            ekle.Dispose();
            bag.Close();
        }
    }
}
