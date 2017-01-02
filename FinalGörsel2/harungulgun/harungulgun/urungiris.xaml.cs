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
        public urungiris()
        {
            InitializeComponent();
            urunlerigosteer();
        }
        private void urunlerigosteer()
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
            urunlerigosteer();

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            personelEkle per = new personelEkle();
            per.Show();
            this.Hide();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            personelSil persil = new personelSil();
            persil.Show();
            this.Hide();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            urungoster urungso = new urungoster();
            urungso.Show();
            this.Hide();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            urungiris gir = new urungiris();
            gir.Show();
            this.Hide();
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            urunsil silurun = new urunsil();
            silurun.Show();
            this.Hide();
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            odemeler ode = new odemeler();
            ode.Show();
            this.Hide();
        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            gelenpara pa = new gelenpara();
            pa.Show();
            this.Hide();
        }

        private void MenuItem_Click_8(object sender, RoutedEventArgs e)
        {
            kasa kas = new kasa();
            kas.Show();
            this.Hide();
        }
    }
}
