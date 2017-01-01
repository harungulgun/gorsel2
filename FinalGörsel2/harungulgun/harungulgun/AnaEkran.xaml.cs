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

namespace harungulgun
{
    /// <summary>
    /// Interaction logic for AnaEkran.xaml
    /// </summary>
    public partial class AnaEkran : Window
    {

        public AnaEkran()
        {
            InitializeComponent();
              
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
    }
}
