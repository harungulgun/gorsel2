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
    /// Interaction logic for odemeler.xaml
    /// </summary>
    public partial class odemeler : Window
    {
        MySqlConnection bag = new MySqlConnection("Server = localhost; Database = stoktakibi; Uid = root; Pwd=;");
        DispatcherTimer zamanab;
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

            zamanab = new DispatcherTimer();
            odemeliste();
        }
        private void odemeliste()
        {
            MySqlCommand cm = new MySqlCommand("Select * from odemeler", bag);
            MySqlDataAdapter ad = new MySqlDataAdapter(cm);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            odemelistele.ItemsSource = tb.AsDataView();

        }
        private void Zamanab_Tick(object sender, EventArgs e)
        {

            odemeliste();

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
            MySqlCommand ekle = new MySqlCommand("INSERT INTO odemeler(odemeTuru,OdemeTipi,aciklama,tutar) VALUES ('" + odemetur.Text + "','" + odemetipi.Text+ "','" + aciklama.Text + "','" + tutar.Text + "')", bag);
            ekle.ExecuteNonQuery();
            ekle.Dispose();
            bag.Close();
            zamanab.Interval = new TimeSpan(0, 0, 3);
            zamanab.Tick += Zamanab_Tick;
            zamanab.Start();
            odemeliste();
        }

        private void odemeyisil_Click(object sender, RoutedEventArgs e)
        {
            if (odemelistele.SelectedIndex != -1)
            {
                bag.Open();
                DataRowView satir = (DataRowView)odemelistele.SelectedItem;
                if (odemelistele.SelectedIndex == -1) return;
                MySqlCommand sil = new MySqlCommand("delete from odemeler where id='" + satir[0] + "'", bag);
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
                MessageBox.Show("Herhangi bir alan seçmediniz.","HATA",MessageBoxButton.OK,MessageBoxImage.Error);
            }
           
        }
    }
}
