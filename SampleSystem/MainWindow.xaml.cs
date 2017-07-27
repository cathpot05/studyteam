using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SampleSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            //foreach (Button wrapButton in second_row_grid.Children)
            //{
            //    Action<string> wrapButtonFunctions = (Buttons) =>
            //    {
            //        switch (Buttons)
            //        {
            //            case "btnUserWindow":
            //                {

            //                }
            //                 break;
            //        }
            //    };
                
            //}
        }

        private void btnRightMenuShow_Click(object sender, RoutedEventArgs e)
        {
            menuslide(true);
        }

        private void menuslide(bool isVisible)
        {
            //throw new NotImplementedException();

            string[] p = new string[] { "sbShowRightMenu", "sbHideRightMenu" };
             Storyboard sb = Resources[p[isVisible ? 0 : 1]] as Storyboard;
            sb.Begin(Notifs);
            if (isVisible)
            {
                btnRightMenuShow.Visibility = System.Windows.Visibility.Hidden;
                btnRightMenuHide.Visibility = System.Windows.Visibility.Visible;
            }
            else
            {
                btnRightMenuShow.Visibility = System.Windows.Visibility.Visible;
                btnRightMenuHide.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void btnRightMenuHide_Click(object sender, RoutedEventArgs e)
        {
            menuslide(false);
            Console.WriteLine("btnhide was click");
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            onLoadBooks();
        }

        private void onLoadBooks()
        {
            
            SqlConnect con = new SqlConnect();
            con.conOpen();
            if (con == null)
            {
                return;
            }
            else
            {
                string query = "SELECT A.*, (B.author_fname + ' ' + B.author_lname) AS Author FROM tblBooks A INNER JOIN tblAuthor B ON A.bookauthor_id = B.authorid";
                SqlCommand cmd = new SqlCommand(query, con.Con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                gridDataLoading.ItemsSource = dt.DefaultView;
                gridDataLoading.Columns[0].Visibility = Visibility.Collapsed;
                gridDataLoading.Columns[2].Visibility = Visibility.Collapsed;
                gridDataLoading.Columns[1].Header = "Book Title";
                gridDataLoading.Columns[3].Header = "Date Published";
                gridDataLoading.Columns[4].Header = "Quantity";
                gridDataLoading.Columns[5].Header = "Stocks";
                gridDataLoading.CanUserAddRows = false;
                con.conclose();
            }
            
        }

        private void onLoadAuthor()
        {
            SqlConnect con = new SqlConnect();
            con.conOpen();
            if(con == null)
            {
                return;
            }
            else
            {

                string q = "SELECT * FROM tblAuthor";
                SqlCommand cmd = new SqlCommand(q, con.Con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                DataTable dt = new DataTable();
                sda.Fill(dt);
                gridDataLoading.DataContext = dt.DefaultView;
                gridDataLoading.Columns[0].Visibility = Visibility.Collapsed;

            }
        }

        private void btnUserWindow_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnbooksWindow_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnAuthorWindow_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnborrowerWindow_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnCourseWindow_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnTransWindow_Click(object sender, RoutedEventArgs e)
        {

        }
    }

    public class MarginConverter : IValueConverter
    {
        public Dock Margin { get; set; } = Dock.Left;
        public double Multiplier { get; set; } = 1;

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            switch (this.Margin)
            {
                case Dock.Left:
                    return new Thickness((double)value * Multiplier, 0, 0, 0);
                case Dock.Top:
                    return new Thickness(0, (double)value * Multiplier, 0, 0);
                case Dock.Right:
                    return new Thickness(0, 0, (double)value * Multiplier, 0);
                case Dock.Bottom:
                    return new Thickness(0, 0, 0, (double)value * Multiplier);
                default:
                    return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return null;
        }
    }
}
