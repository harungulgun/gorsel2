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
    /// Interaction logic for urungiris.xaml
    /// </summary>
    public partial class urungiris : Window
    {
        MySqlConnection bag = new MySqlConnection("Server = localhost; Database = stoktakibi; Uid = root; Pwd=;");
        System.Windows.Threading.DispatcherTimer zaman;
        public urungiris()
        {
            InitializeComponent();
            zaman = new System.Windows.Threading.DispatcherTimer();
            zaman.Interval = new TimeSpan(0,0,1);
            zaman.Tick += Zaman_Tick;
            zaman.Start();
        }
        private void Zaman_Tick(object sender, EventArgs e)
        {
            MySqlCommand cm = new MySqlCommand("Select * from urunler",bag);
            MySqlDataAdapter ad = new MySqlDataAdapter(cm);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            urungoster.ItemsSource = tb.AsDataView();

        }

       
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            AnaEkran ana = new AnaEkran();
            ana.Show();
            this.Hide();
        }

        private void urunekle_Click(object sender, RoutedEventArgs e)
        {
            bag.Open();
            MySqlCommand ekle = new MySqlCommand("INSERT INTO urunler (urunad,urunadet,ureticiFirma,barkodno,fiyati,giristarihi) VALUES ('" + urunad.Text + "','" + urunadet.Text + "','" + urunuret.Text + "','" + urunbarkod.Text + "','"+urunfiyat.Text+"','"+giristarih.Text+"')",bag);
            ekle.ExecuteNonQuery();
            ekle.Dispose();
            bag.Close();

        }
    }
}
