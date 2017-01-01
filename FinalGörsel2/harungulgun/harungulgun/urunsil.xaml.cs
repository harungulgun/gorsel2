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
    /// Interaction logic for urunsil.xaml
    /// </summary>
    public partial class urunsil : Window
    {
        MySqlConnection bag = new MySqlConnection("Server = localhost; Database = stoktakibi; Uid = root; Pwd=;");
        public urunsil()
        {
            InitializeComponent();
            urunlerigoster();
        }
        private void urunlerigoster()
        {
            MySqlCommand asd = new MySqlCommand("select * from urunler", bag);
            MySqlDataAdapter ad = new MySqlDataAdapter(asd);
            DataTable ta = new DataTable();
            ad.Fill(ta);
            sildata.ItemsSource = ta.AsDataView();
        } 
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            AnaEkran ana = new AnaEkran();
            ana.Show();
            this.Hide();
        }

        private void urunekle_Click(object sender, RoutedEventArgs e)
        {
            if (sildata.SelectedIndex != -1)
            {
                bag.Open();
            DataRowView satir = (DataRowView)sildata.SelectedItem;
            if (sildata.SelectedIndex == -1) return;
            MySqlCommand sil = new MySqlCommand("delete from urunler where id='" + satir[0] + "'", bag);
            MySqlDataAdapter adabtor = new MySqlDataAdapter(sil);
            sil.ExecuteNonQuery();
            sil.Dispose();
            bag.Close();
            urunlerigoster();
            }
            else
            {
                MessageBox.Show("Herhangi bir alan seçmediniz.", "HATA", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
