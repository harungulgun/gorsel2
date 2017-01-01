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
    /// Interaction logic for gelenpara.xaml
    /// </summary>
    public partial class gelenpara : Window
    {
        MySqlConnection bag = new MySqlConnection("Server = localhost; Database = stoktakibi; Uid = root; Pwd=;");
        DispatcherTimer zamanabaab;
        public gelenpara()
        {
            InitializeComponent();
            paratipi.Items.Add("TL");
            paratipi.Items.Add("USD");
            paratipi.Items.Add("Euro");
            paratipi.Items.Add("Çek");     

            gelenparalarlistele();
        }
        private void gelenparalarlistele() {

            MySqlCommand cm = new MySqlCommand("Select * from gelenpara", bag);
            MySqlDataAdapter ad = new MySqlDataAdapter(cm);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            gelenlistele.ItemsSource = tb.AsDataView();

        }
        private void kasayaekle_Click(object sender, RoutedEventArgs e)
        {
            bag.Open();
            MySqlCommand ekle = new MySqlCommand("INSERT INTO gelenpara(kimden,paratipi,tutar) VALUES ('" + kimden.Text + "','" + paratipi.Text+ "','" + tutar.Text + "')", bag);
            ekle.ExecuteNonQuery();
            ekle.Dispose();
            bag.Close();
            gelenparalarlistele();
            bag.Close();
        }

        private void kasadansil_Click(object sender, RoutedEventArgs e)
        {
            if (gelenlistele.SelectedIndex != -1)
            {
                bag.Open();
                DataRowView satir = (DataRowView)gelenlistele.SelectedItem;
                if (gelenlistele.SelectedIndex == -1) return;
                MySqlCommand sil = new MySqlCommand("delete from gelenpara where id='" + satir[0] + "'", bag);
                MySqlDataAdapter adabtor = new MySqlDataAdapter(sil);
                sil.ExecuteNonQuery();
                sil.Dispose();
                bag.Close();
                gelenparalarlistele();
            }
            else
            {
                MessageBox.Show("Herhangi bir alan seçmediniz.", "HATA", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
