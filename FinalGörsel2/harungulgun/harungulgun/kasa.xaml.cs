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
    /// Interaction logic for kasa.xaml
    /// </summary>
    public partial class kasa : Window
    {
        MySqlConnection bag = new MySqlConnection("Server = localhost; Database = stoktakibi; Uid = root; Pwd=;");
        DispatcherTimer zamanart;
        public kasa()
        {
            InitializeComponent();

            zamanart = new DispatcherTimer();
            zamanart.Interval = new TimeSpan(0, 0, 1);
            zamanart.Tick += Zamanart_Tick;
            zamanart.Start();



        }
        private void Zamanart_Tick(object sender, EventArgs e)
        {
            bag.Open();
            MySqlCommand cmd = new MySqlCommand("select miktar from kasa ", bag);
            int Count = Convert.ToInt32(cmd.ExecuteScalar());

            if (Count != 0)
            {

                MySqlDataReader oku = cmd.ExecuteReader();
                while (oku.Read())
                {
                    kasatoplam.Text = oku["miktar"].ToString();

                }
            }
            bag.Close();


        }

    }
}
