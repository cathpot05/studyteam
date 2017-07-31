
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
            AuthorLoad("");
        }

        private void clearControls()
        {
            txtAuthorFname.Text = "";
            txtAuthorLname.Text = "";
        }


        private void AuthorLoad(string value)
        {
            var _condition = "";
            if (value == "")
            {
                _condition = "";
            }else
            {
                //_condition = "WHERE author_fname LIKE '%" + value + "%' OR author_lname LIKE '%" + value + "%'";
                _condition = "WHERE author_fname LIKE '%"+ @value +"%' OR author_lname LIKE '%"+ @value +"%'";
                
            }

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
                    string q = "SELECT * , (author_fname + ' ' + author_lname )as Author FROM tblAuthor " + _condition;
                    SqlCommand cmd = new SqlCommand(q, con.Con);
                    cmd.Parameters.AddWithValue("@value", value);
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

        //void getTheValue(object sender, RoutedEventArgs e)
        //{

        //}

        private void btnA_Add_Click(object sender, RoutedEventArgs e)
        {
            clearControls();
            CrudConfiguration func = new CrudConfiguration();
            func.getFunction("INSERT");

        }

        private void btnA_Edit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnA_Delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnA_Save_Click(object sender, RoutedEventArgs e)
        {

        }

        //private void dgAuthor_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        //{
        //    var grid = sender as DataGrid;
        //    var value = grid.SelectedValue; //SelectedItem
        //}

        private void dgAuthor_MouseLeftButtonUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            if (dgAuthor.SelectedIndex != -1)
            {
                DataRowView x = (DataRowView)dgAuthor.SelectedItems[0];
                txtAuthorFname.Text = x[1].ToString();
                txtAuthorLname.Text = x[2].ToString();
            }
        }

        private void txtUASearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            AuthorLoad(this.txtUASearch.Text);
        }
    }
}
