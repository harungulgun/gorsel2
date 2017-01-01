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
    /// Interaction logic for personelSil.xaml
    /// </summary>
    public partial class personelSil : Window
    {
        MySqlConnection bag = new MySqlConnection("Server = localhost; Database = stoktakibi; Uid = root; Pwd=;");
        DispatcherTimer zamanab;
        public personelSil()
        {
            InitializeComponent();
            zamanab = new DispatcherTimer();
            perssgosterr();
        }
        public void perssgosterr()
        {

            MySqlCommand asd = new MySqlCommand("select * from personel order by tarih desc", bag);
            MySqlDataAdapter ad = new MySqlDataAdapter(asd);
            DataTable ta = new DataTable();
            ad.Fill(ta);
            personelgoster.ItemsSource = ta.AsDataView();
        }
        private void Zamanab_Tick(object sender, EventArgs e)
        {

            perssgosterr();


        }
        private void persil_Click(object sender, RoutedEventArgs e)
        {
            if (personelgoster.SelectedIndex != -1)
            {
                bag.Open();
            DataRowView satir = (DataRowView)personelgoster.SelectedItem;
            if (personelgoster.SelectedIndex == -1) return;
            MySqlCommand sil = new MySqlCommand("delete from personel where id='" + satir[0] + "'", bag);
            MySqlDataAdapter adabtor = new MySqlDataAdapter(sil);
            sil.ExecuteNonQuery();
            sil.Dispose();
            bag.Close();
            zamanab.Interval = new TimeSpan(0, 0, 3);
            zamanab.Tick += Zamanab_Tick;
            zamanab.Start();
            }
            else
            {
                MessageBox.Show("Herhangi bir alan seçmediniz.", "HATA", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            AnaEkran ana = new AnaEkran();
            ana.Show();
            this.Hide();
        }
    }
}
