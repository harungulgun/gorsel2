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
        public int yap;
        public int tog;
        public int tok;
        public gelenpara()
        {
            InitializeComponent();
            paratipi.Items.Add("TL");
            paratipi.Items.Add("USD");
            paratipi.Items.Add("Euro");
            paratipi.Items.Add("Çek");

            gelenparalarlistele();



            kasasillistele.Visibility = Visibility.Hidden;
            kasadansil.Visibility = Visibility.Hidden;
          


        }
        private void gelenparalarlistele() {

            MySqlCommand cm = new MySqlCommand("Select * from gelenpara", bag);
            MySqlDataAdapter ad = new MySqlDataAdapter(cm);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            gelenlistele.ItemsSource = tb.AsDataView();

        }/*
        private void gelenkasalistele(){
            MySqlCommand cm = new MySqlCommand("Select * from kasa", bag);
            MySqlDataAdapter ad = new MySqlDataAdapter(cm);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            kasasillistele.ItemsSource = tb.AsDataView();
        }*/
        private void kasayaekle_Click(object sender, RoutedEventArgs e)
        {
            bag.Open();
            MySqlCommand ekle = new MySqlCommand("INSERT INTO gelenpara(kimden,paratipi,tutar) VALUES ('" + kimden.Text + "','" + paratipi.Text+ "','" + tutar.Text + "')", bag);
            ekle.ExecuteNonQuery();
            ekle.Dispose();
            bag.Close();
            gelenparalarlistele();
            bag.Close();
            kasayadaekle();
            kkgoster();
            kasasillistele.Visibility = Visibility.Visible;

        }
        private void kasayadaekle()
        {
            bag.Open();
            MySqlCommand kasayaekle = new MySqlCommand("INSERT INTO kasa(kimden,paratipi,miktar) VALUES ('" + kimden.Text + "','" + paratipi.Text + "','" + tutar.Text + "')", bag);
            kasayaekle.ExecuteNonQuery();
            kasayaekle.Dispose();
            bag.Close();

        }
        private void kasadandasil()
        {
            /*
            
                        bag.Open();
                        DataRowView sat = (DataRowView)gelenlistele.SelectedItem;
                        if (gelenlistele.SelectedIndex == -1) return;
                        MySqlCommand sil = new MySqlCommand("delete from kasa where miktar='" + sat[3] + "'", bag);
                        MySqlDataAdapter adabtor = new MySqlDataAdapter(sil);
                        sil.ExecuteNonQuery();
                        sil.Dispose();
                        bag.Close();
                        
                        BURAYA DAHA SONRA BAKILACAK
             

           */

        }
        private void yoruldum()
        {
            MySqlCommand cma = new MySqlCommand("Select * from gelenpara", bag);
            MySqlDataAdapter ad = new MySqlDataAdapter(cma);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            gelenlistele.ItemsSource = tb.AsDataView();


        }
        private void kasadansil_Click(object sender, RoutedEventArgs e)
        {
           
                if (gelenlistele.SelectedIndex != -1)
                {
                    bag.Open();
                    DataRowView satir = (DataRowView)gelenlistele.SelectedItem;
                    if (gelenlistele.SelectedIndex == -1) return;
                    MySqlCommand sillll = new MySqlCommand("delete from gelenpara where id='" + satir[0] + "'", bag);
                    MySqlDataAdapter adabtoor = new MySqlDataAdapter(sillll);
                    sillll.ExecuteNonQuery();
                    sillll.Dispose();


                    bag.Close();
                    kasadandasil();
                    kkgoster();
                    yoruldum();

                    return;


                }

                else
                {
                    MessageBox.Show("Herhangi bir alan seçmediniz.", "HATA", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            
           
                if (kasasillistele.SelectedIndex != -1)
                {
                    bag.Open();
                    DataRowView satir = (DataRowView)kasasillistele.SelectedItem;
                    if (kasasillistele.SelectedIndex == -1) return;
                    MySqlCommand sillll = new MySqlCommand("delete from kasa where id='" + satir[0] + "'", bag);
                    MySqlDataAdapter adabtoor = new MySqlDataAdapter(sillll);
                    sillll.ExecuteNonQuery();
                    sillll.Dispose();


                    bag.Close();
                    kasadandasil();
                    kkgoster();
                    yoruldum();
                    return;


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
        kasa kk = new kasa();
        private void kkgoster()
        {
            MySqlCommand cm = new MySqlCommand("Select * from kasa", bag);
            MySqlDataAdapter ad = new MySqlDataAdapter(cm);
            DataTable tb = new DataTable();
            ad.Fill(tb);
            kasasillistele.ItemsSource = tb.AsDataView();

        }

        private void eklenensil_Click(object sender, RoutedEventArgs e)
        {
            kasasillistele.Visibility = Visibility.Visible;
            kasadansil.Visibility = Visibility.Visible;
            kasayaekle.Visibility = Visibility.Visible;
            kkgoster();
            eklenensil.Visibility = Visibility.Visible;
           

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
