
using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;
using System.Data;

namespace SampleSystem
{
    /// <summary>
    /// Interaction logic for AuthorData.xaml
    /// </summary>
    public partial class AuthorData : UserControl
    {
        public AuthorData()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            AuthorLoad();
        }

        private void AuthorLoad()
        {
            SqlConnect con = new SqlConnect();
            con.conOpen();
            if (con == null)
            {
                return;
            }
            else
            {

                string q = "SELECT * , (author_fname + '  ' + author_lname )as Author FROM tblAuthor";
                SqlCommand cmd = new SqlCommand(q, con.Con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgAuthor.DataContext = dt.DefaultView;
                dgAuthor.Columns[0].Visibility = Visibility.Collapsed;
                dgAuthor.Columns[1].Visibility = Visibility.Collapsed;
                dgAuthor.Columns[2].Visibility = Visibility.Collapsed;

            }
            con.conclose();
        }
        
        private void txtUASearch_GotFocus(object sender, RoutedEventArgs e)
        {
            txtUASearchToolTip.Visibility = Visibility.Hidden;
        }

        private void txtUASearch_LostFocus(object sender, RoutedEventArgs e)
        {
            if (this.txtUASearch.Text == "")
            {
                txtUASearchToolTip.Visibility = Visibility.Visible;
            }
        }
    }
}
