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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MySql.Data.MySqlClient;

namespace harungulgun
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
          
        }
        MySqlConnection bag = new MySqlConnection("Server = localhost; Database = stoktakibi; Uid = root; Pwd=;");
        private void button_Click(object sender, RoutedEventArgs e)
        {

            bag.Open();
            MySqlCommand girisyap = new MySqlCommand("Select * from kulgir where kulad='" + kulad.Text.ToString()+"' and sifre = '"+parola.Text.ToString()+"'",bag);
            MySqlDataReader rd = girisyap.ExecuteReader();
            if (rd.Read())
            {
                AnaEkran ana = new AnaEkran();
                ana.girisgkulad.Text = "Selam " + kulad.Text + " Hoşgeldin";
                ana.Show();
                this.Close();

            }
            else
            {
             MessageBox.Show("Kullanıcı Adı veya Parola hatalı.","Hatalı Giriş",MessageBoxButton.OK,MessageBoxImage.Error);
            }
            bag.Close();

        }
    }
}
