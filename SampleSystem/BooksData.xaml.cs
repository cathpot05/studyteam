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
using System.Data;

namespace SampleSystem
{
    /// <summary>
    /// Interaction logic for BooksData.xaml
    /// </summary>
    public partial class BooksData : UserControl
    {
        public BooksData()
        {
            InitializeComponent();
        }

        private void txtUBSearch_GotFocus(object sender, RoutedEventArgs e)
        {
            txtSearchToolTip.Visibility = Visibility.Hidden;
        }

        private void txtUBSearch_LostFocus(object sender, RoutedEventArgs e)
        {
            if(this.txtUBSearch.Text == "")
            {
                txtSearchToolTip.Visibility = Visibility.Visible;
            }
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            comboBoxLoad();
            gridLoading();
        }

        private void gridLoading()
        {
            SqlConnect con = new SqlConnect();
            con.conOpen();
            if(con != null)
            {
                string q = "SELECT A.*, (B.author_fname + ' ' + B.author_lname) AS Author FROM tblBooks A INNER JOIN tblAuthor B ON A.bookauthor_id = B.authorid";
                SqlCommand cmd = new SqlCommand(q, con.Con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgBooks.ItemsSource = dt.DefaultView;
                dgBooks.Columns[0].Visibility = Visibility.Collapsed;
                dgBooks.Columns[1].Header = "Book Title";
                dgBooks.Columns[2].Header = "Author";
                dgBooks.Columns[3].Header = "Published";
                dgBooks.Columns[4].Header = "Quantity";
                dgBooks.Columns[5].Header = "Stocks";
            }
            else
            {
                return;
            }
            con.conclose();
        }

        private void comboBoxLoad()
        {
            SqlConnect con = new SqlConnect();
            con.conOpen();
            if (con != null)
            {
                string q = "SELECT * , (author_fname + ' ' + author_lname) as Author FROM tblAuthor";
                SqlCommand cmd = new SqlCommand(q, con.Con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet dt= new DataSet();
                sda.Fill(dt, "tblAuthor");
                cboBauthor.ItemsSource = dt.Tables[0].DefaultView;
                cboBauthor.DisplayMemberPath = dt.Tables[0].Columns["Author"].ToString();
                cboBauthor.SelectedValuePath = dt.Tables[0].Columns["authorid"].ToString();

            }
            else
            {
                return;
            }
            con.conclose();
        }
    }
}
