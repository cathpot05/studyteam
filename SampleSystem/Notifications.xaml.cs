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
using System.Data.SqlClient;

namespace SampleSystem
{
    /// <summary>
    /// Interaction logic for Notifications.xaml
    /// </summary>
    public partial class Notifications : UserControl
    {
        public Notifications()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnect con = new SqlConnect();
            con.conOpen();
            if (con == null) {
                return;
            }
            else {
                string query = "SELECT COUNT(*) FROM tblTransaction WHERE status = 0";
                SqlCommand cmd = new SqlCommand(query, con.Con);
                SqlDataReader sdr = cmd.ExecuteReader();

            }
        }
    }
}
