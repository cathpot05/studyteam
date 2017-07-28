
using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;
using System.Data;
using System;

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

                try
                {
                    string q = "SELECT * , (author_fname + ' ' + author_lname )as Author FROM tblAuthor";
                    SqlCommand cmd = new SqlCommand(q, con.Con);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgAuthor.ItemsSource = dt.DefaultView;
                    dgAuthor.Columns[0].Visibility = Visibility.Collapsed;
                    dgAuthor.Columns[1].Visibility = Visibility.Collapsed;
                    dgAuthor.Columns[2].Visibility = Visibility.Collapsed;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

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
