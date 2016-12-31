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
    /// Interaction logic for urungiris.xaml
    /// </summary>
    public partial class urungiris : Window
    {
        public urungiris()
        {
            InitializeComponent();
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
