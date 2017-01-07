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
using System.Windows.Threading;
using System.Data;
using MySql.Data.MySqlClient;

namespace harungulgun
{
    /// <summary>
    /// Interaction logic for AnaEkran.xaml
    /// </summary>
    public partial class AnaEkran : Window
    {
        MySqlConnection bag = new MySqlConnection("Server = localhost; Database = stoktakibi; Uid = root; Pwd=;");
        DispatcherTimer zamana;

        public AnaEkran()
        {
            InitializeComponent();
            zamana = new DispatcherTimer();
            zamana.Interval = new TimeSpan(0, 0, 1);
            zamana.Tick += Zamana_Tick;
            zamana.Start();

        }
        private void Zamana_Tick(object sender, EventArgs e)
        {
            MySqlCommand asd = new MySqlCommand("Select * from urunler", bag);
            MySqlDataAdapter ad = new MySqlDataAdapter(asd);
            DataTable ta = new DataTable();
            ad.Fill(ta);
            gostermeler.ItemsSource = ta.AsDataView();

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            personelEkle per = new personelEkle();
            per.Show();
            this.Hide();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            urungoster goster = new urungoster();
            goster.Show();
            this.Hide();
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            urungiris gir = new urungiris();
            gir.Show();
            this.Hide();
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            urunsil sil = new urunsil();
            sil.Show();
            this.Hide();

        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            odemeler ode = new odemeler();
            ode.Show();
            this.Hide();
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            personelSil sil = new personelSil();
            sil.Show();
            this.Hide();
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            gelenpara para = new gelenpara();
            para.Show();
            this.Hide();

        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            kasa k = new kasa();
            this.Hide();
            k.Show();  
        }
    }
}
