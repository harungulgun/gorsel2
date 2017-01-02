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
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            AnaEkran ana = new AnaEkran();
            ana.Show();
            this.Hide();
            
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
                odemeliste();
            }
            else
            {
                MessageBox.Show("Herhangi bir alan seçmediniz.","HATA",MessageBoxButton.OK,MessageBoxImage.Error);
            }
           
        }
        private void odemeekle_Click(object sender, RoutedEventArgs e)
        {
            bag.Open();
            MySqlCommand ekle = new MySqlCommand("INSERT INTO odemeler(odemeTuru,OdemeTipi,aciklama,tutar) VALUES ('" + odemetur.Text + "','" + odemetipi.Text + "','" + aciklama.Text + "','" + tutar.Text + "')", bag);
            ekle.ExecuteNonQuery();
            ekle.Dispose();
            bag.Close();
            odemeliste();
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
            urungoster urungso = new urungoster();
            urungso.Show();
            this.Hide();
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            urungiris gir = new urungiris();
            gir.Show();
            this.Hide();
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            urunsil silurun = new urunsil();
            silurun.Show();
            this.Hide();
        }

        private void MenuItem_Click_6(object sender, RoutedEventArgs e)
        {
            odemeler ode = new odemeler();
            ode.Show();
            this.Hide();
        }

        private void MenuItem_Click_7(object sender, RoutedEventArgs e)
        {
            gelenpara pa = new gelenpara();
            pa.Show();
            this.Hide();
        }

        private void MenuItem_Click_8(object sender, RoutedEventArgs e)
        {
            kasa kas = new kasa();
            kas.Show();
            this.Hide();
        }
    }
}
