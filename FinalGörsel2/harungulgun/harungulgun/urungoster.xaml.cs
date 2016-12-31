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
using System.Threading;
using System.Windows.Threading;
using System.Data;
using MySql.Data.MySqlClient;

namespace harungulgun
{
    /// <summary>
    /// Interaction logic for urungoster.xaml
    /// </summary>
    public partial class urungoster : Window
    {
        
        MySqlConnection bag = new MySqlConnection("Server = localhost; Database = stoktakibi; Uid = root; Pwd=;");
        DispatcherTimer zamana;
        public urungoster()
        {
            InitializeComponent();
            zamana = new DispatcherTimer();
            zamana.Interval = new TimeSpan(0, 0, 1);
            zamana.Tick += Zamana_Tick;
            zamana.Start();
            
        }
        private void Zamana_Tick(object sender, EventArgs e)
        {
            MySqlCommand asd = new MySqlCommand("Select * from urunler", bag);
            MySqlDataAdapter ad = new MySqlDataAdapter(asd);
            DataTable ta = new DataTable();
            ad.Fill(ta);
            urungostera.ItemsSource = ta.AsDataView();

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            AnaEkran ana = new AnaEkran();
            ana.Show();
            this.Hide();
        }
    }
}
