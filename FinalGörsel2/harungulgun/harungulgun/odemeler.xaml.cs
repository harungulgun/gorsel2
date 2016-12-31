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
    /// Interaction logic for odemeler.xaml
    /// </summary>
    public partial class odemeler : Window
    {
        public odemeler()
        {
            InitializeComponent();
            odemetur.Items.Add("Personel Ödemesi");
            odemetur.Items.Add("Firma Ödemesi");
            odemetur.Items.Add("Kırtasiye Ödemesi");
            odemetur.Items.Add("Diğer Ödemeler");


            odemetipi.Items.Add("TL");
            odemetipi.Items.Add("USD");
            odemetipi.Items.Add("Euro");
            odemetipi.Items.Add("Çek");
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            AnaEkran ana = new AnaEkran();
            ana.Show();
            this.Hide();
            
        }

        private void urunekle_Click(object sender, RoutedEventArgs e)
        {
         
        }
    }
}
