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
    /// Interaction logic for kasa.xaml
    /// </summary>
    public partial class kasa : Window
    {
        MySqlConnection bag = new MySqlConnection("Server = localhost; Database = stoktakibi; Uid = root; Pwd=;");
  
        DispatcherTimer zamanart;
        public kasa()
        {
            InitializeComponent();

            zamanart = new DispatcherTimer();
            zamanart.Interval = new TimeSpan(0, 0, 1);
            zamanart.Tick += Zamanart_Tick;
            zamanart.Start();



        }
        private void Zamanart_Tick(object sender, EventArgs e)
        {

            

         
                         bag.Open(); 
                         MySqlCommand komut = new MySqlCommand("select sum(miktar) from kasa", bag);
                         kasatoplam.Text = komut.ExecuteScalar().ToString();
                         komut.ExecuteNonQuery(); 
                         bag.Close();
   

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            AnaEkran ANA = new AnaEkran();
            ANA.Show();
            this.Hide();
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

        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            urungoster urungso = new urungoster();
            urungso.Show();
            this.Hide();
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            urungiris gir = new urungiris();
            gir.Show();
            this.Hide();
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            urunsil silurun = new urunsil();
            silurun.Show();
            this.Hide();
        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            odemeler ode = new odemeler();
            ode.Show();
            this.Hide();
        }

        private void MenuItem_Click_8(object sender, RoutedEventArgs e)
        {
            gelenpara pa = new gelenpara();
            pa.Show();
            this.Hide();
        }

        private void MenuItem_Click_9(object sender, RoutedEventArgs e)
        {
            kasa kas = new kasa();
            kas.Show();
            this.Hide();
        }
    }
}
