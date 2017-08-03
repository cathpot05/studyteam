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
            #region Button's Func_Leave Mouse
            foreach (StackPanel CrudPanels in FunctionButtons_Book.Children)
            {
                foreach (Button CrudButtons in CrudPanels.Children.OfType<Button>())
                {
                    Action<string> CrudButtonFunctions = (Buttons) =>
                    {
                        switch (Buttons)
                        {
                            case "btnB_Add":
                                {
                                    btnB_Add.Background = (ImageBrush)Resources["AddNormal"];
                                }
                                break;
                            case "btnB_Edit":
                                {
                                    btnB_Edit.Background = (ImageBrush)Resources["EditNormal"];
                                }
                                break;
                            case "btnB_Delete":
                                {
                                    btnB_Delete.Background = (ImageBrush)Resources["DeleteNormal"];
                                }
                                break;
                            case "btnB_Save":
                                {
                                    btnB_Save.Background = (ImageBrush)Resources["SaveNormal"];
                                }
                                break;
                        }
                    };
                    CrudButtons.MouseLeave += delegate
                    {
                        CrudButtonFunctions(CrudButtons.Name);
                    };

                    CrudButtons.TouchLeave += delegate
                    {
                        CrudButtonFunctions(CrudButtons.Name);
                    };
                }


            }
            #endregion


            #region Button's Enter Mouse
            foreach (StackPanel CrudPanels in FunctionButtons_Book.Children)
            {
                foreach (Button CrudButtons in CrudPanels.Children.OfType<Button>())
                {
                    Action<string> CrudButtonFunctions = (Buttons) =>
                    {
                        switch (Buttons)
                        {
                            case "btnB_Add":
                                {
                                    btnB_Add.Background = (ImageBrush)Resources["AddPress"];
                                }
                                break;
                            case "btnB_Edit":
                                {
                                    btnB_Edit.Background = (ImageBrush)Resources["EditPress"];
                                }
                                break;
                            case "btnB_Delete":
                                {
                                    btnB_Delete.Background = (ImageBrush)Resources["DeletePress"];
                                }
                                break;
                            case "btnB_Save":
                                {
                                    btnB_Save.Background = (ImageBrush)Resources["SavePress"];
                                }
                                break;
                        }
                    };
                    CrudButtons.MouseEnter += delegate
                    {
                        CrudButtonFunctions(CrudButtons.Name);
                    };

                    CrudButtons.TouchEnter += delegate
                    {
                        CrudButtonFunctions(CrudButtons.Name);
                    };
                }


            }
            #endregion
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

        private void clearControls()
        {
            txtBookId.Text = "";
            txtbQty.Text = "";
            txtbStocks.Text = "";
            txtbTitle.Text = "";
            cboBauthor.Text = "";
            dP_datePublished.Text = "";
        }

        private void enabledNewTransbutton()
        {
            btnB_Edit.Background = (ImageBrush)Resources["EditPress"];
            btnB_Delete.Background = (ImageBrush)Resources["DeletePress"];
            btnB_Save.Background = (ImageBrush)Resources["SaveNormal"];
            //var editImg = new ImageBrush();
            //editImg.ImageSource = new BitmapImage(new Uri(@"Images\crud_edit_disable.png", UriKind.Relative));
            //btnA_Edit.Background = editImg;

            btnB_Edit.IsEnabled = false;
            btnB_Delete.IsEnabled = false;
            btnB_Save.IsEnabled = true;
            btnB_Add.IsEnabled = true;
        }

        private void modifyTrans()
        {
            btnB_Edit.Background = (ImageBrush)Resources["EditNormal"];
            btnB_Delete.Background = (ImageBrush)Resources["DeleteNormal"];
            btnB_Save.Background = (ImageBrush)Resources["SavePress"];


            btnB_Edit.IsEnabled = true;
            btnB_Delete.IsEnabled = true;
            btnB_Save.IsEnabled = false;

        }


        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            comboBoxLoad();
            gridLoading("");
        }

        private void gridLoading(string value)
        {
            var _condition = "";
            if (value == "")
            {
                _condition = "";
            }
            else
            {
                _condition = "WHERE A.booktitle LIKE '%" + @value + "%' OR B.author_fname LIKE '%" + @value + "%' OR B.author_lname LIKE '%" + @value + "%'";

            }

            SqlConnect con = new SqlConnect();
            con.conOpen();
            if(con != null)
            {
                string q = "SELECT A.*, (B.author_fname + ' ' + B.author_lname) AS Author FROM tblBooks A INNER JOIN tblAuthor B ON A.bookauthor_id = B.authorid " +_condition;
                SqlCommand cmd = new SqlCommand(q, con.Con);
                cmd.Parameters.AddWithValue("@value", value);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgBooks.ItemsSource = dt.DefaultView;
                dgBooks.Columns[0].Visibility = Visibility.Collapsed;
                dgBooks.Columns[2].Visibility = Visibility.Collapsed;
                dgBooks.Columns[1].Header = "Book Title";
                dgBooks.Columns[6].Header = "Author";
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

        public void comboBoxLoad()
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

        private void dgBooks_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (dgBooks.SelectedIndex != -1)
            {

                DataRowView x = (DataRowView)dgBooks.SelectedItems[0];
                txtBookId.Text = x[0].ToString();
                txtbTitle.Text = x[1].ToString();
                cboBauthor.SelectedValue = x[2].ToString();
                DateTime dppub = DateTime.Parse(x[3].ToString());
                dP_datePublished.SelectedDate = dppub;
                txtbQty.Text = x[4].ToString();
                txtbStocks.Text = x[5].ToString();

            }
            modifyTrans();
        }

        private void btnB_Add_Click(object sender, RoutedEventArgs e)
        {
            clearControls();
            enabledNewTransbutton();
        }

        private void btnB_Edit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //let's check first if the textboxes are empty since we cannot allow a blank data
                if (txtbTitle.Text.Trim() == null || txtbQty.Text.Trim() == null || cboBauthor.Text == null || dP_datePublished.Text== null) 
                {
                    MessageBox.Show("Book info cannot be empty");
                    return;
                }
                if (Convert.ToInt32(txtbQty.Text) < 0)
                {
                    MessageBox.Show("Quantity cannot be less than zero");
                    return;
                }

                SqlConnect con = new SqlConnect();
                con.conOpen();
                if (con != null)
                {
                    //let's check first if the data trying to change is already exist.
                    
                    string check = "SELECT TOP 1 * FROM tblBooks WHERE booktitle = @title and bookid <> @id";
                    SqlCommand cmdcheck = new SqlCommand(check, con.Con);
                    cmdcheck.Parameters.AddWithValue("@title", txtbTitle.Text.Trim());
                    cmdcheck.Parameters.AddWithValue("@id", txtBookId.Text.Trim());
                    SqlDataReader sdr = cmdcheck.ExecuteReader();

                    if (sdr.Read()) //if theres a record, return, meaning we cannot allow it
                    {
                        MessageBox.Show("Cannot update record, the data you are trying to change already exist.");
                        sdr.Close();
                        return;
                    }
                    else //we can change or update it
                    {
                        sdr.Close();
                        string query = "UPDATE tblBooks SET booktitle = @title, bookauthor_id = @author, datepublished = @dtpub, qty = @qty WHERE bookid = @id";
                        SqlCommand cmd = new SqlCommand(query, con.Con);
                        cmd.Parameters.AddWithValue("@id", txtBookId.Text.Trim());
                        cmd.Parameters.AddWithValue("@title", txtbTitle.Text.Trim());
                        cmd.Parameters.AddWithValue("@author", cboBauthor.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@dtpub", dP_datePublished.Text.Trim());
                        cmd.Parameters.AddWithValue("@qty", txtbQty.Text.Trim());
                        //cmd.Parameters.AddWithValue("@stocks", txtbStocks.Text.Trim());

                        cmd.ExecuteNonQuery();
                        gridLoading("");
                        enabledNewTransbutton();
                        clearControls();

                    }

                }
                else
                {
                    return;
                }
                con.conclose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnB_Delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                SqlConnect con = new SqlConnect();
                con.conOpen();
                if (con != null)
                {
                    //let's check first if the data trying to delete has a record in our main transactions.
                    string check = "SELECT TOP 1 * FROM tblTransaction WHERE book_id = @id";
                    SqlCommand cmdcheck = new SqlCommand(check, con.Con);
                    cmdcheck.Parameters.AddWithValue("@id", txtBookId.Text.Trim());
                    SqlDataReader sdr = cmdcheck.ExecuteReader();

                    if (sdr.Read()) //if theres a record, return, meaning we cannot allow it
                    {
                        MessageBox.Show("Cannot delete record, the data you are trying to delete has a history on main transaction. Make it inactive instead");
                        sdr.Close();
                        return;
                    }
                    else //we can change or update it
                    {
                        sdr.Close();
                        string query = "DELETE FROM tblBooks WHERE bookid = @id";
                        SqlCommand cmd = new SqlCommand(query, con.Con);
                        cmd.Parameters.AddWithValue("@id", txtBookId.Text.Trim());
                        cmd.ExecuteNonQuery();
                        gridLoading("");
                        enabledNewTransbutton();
                        clearControls();
                    }

                }
                else
                {
                    return;
                }
                con.conclose();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

         }

        private void btnB_Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //let's check first if the textboxes are empty since we cannot allow a blank data
                if (txtbTitle.Text.Trim() == null || txtbQty.Text.Trim() == null || cboBauthor.Text == null || dP_datePublished.Text == null)
                {
                    MessageBox.Show("Book info cannot be empty");
                    return;
                }
                if (Convert.ToInt32(txtbQty.Text) < 0)
                {
                    MessageBox.Show("Quantity cannot be less than zero");
                    return;
                }

                SqlConnect con = new SqlConnect();
                con.conOpen();
                if (con != null)
                {
                    //let's check first if the data trying to change is already exist.
                    string check = "SELECT TOP 1 * FROM tblBooks WHERE booktitle = @title";
                    SqlCommand cmdcheck = new SqlCommand(check, con.Con);
                    cmdcheck.Parameters.AddWithValue("@title", txtbTitle.Text.Trim());
                    SqlDataReader sdr = cmdcheck.ExecuteReader();

                    if (sdr.Read()) //if theres a record, return, meaning we cannot allow it
                    {
                        MessageBox.Show("Cannot add this record, the data you are trying to change already exist.");
                        sdr.Close();
                        return;
                    }
                    else //we can add or insert it
                    {
                        sdr.Close();
                        string query = "INSERT INTO tblBooks (booktitle, bookauthor_id, datepublished, qty, stocks) VALUES (@title, @author, @dtpub, @qty, @qty)";
                        SqlCommand cmd = new SqlCommand(query, con.Con);
                        cmd.Parameters.AddWithValue("@title", txtbTitle.Text.Trim());
                        cmd.Parameters.AddWithValue("@author", cboBauthor.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@dtpub", dP_datePublished.Text.Trim());
                        cmd.Parameters.AddWithValue("@qty", txtbQty.Text.Trim());
                        //cmd.Parameters.AddWithValue("@stocks", txtbStocks.Text.Trim());

                        cmd.ExecuteNonQuery();
                        gridLoading("");
                        enabledNewTransbutton();
                        clearControls();

                    }

                }
                else
                {
                    return;
                }
                con.conclose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtUBSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            gridLoading(this.txtUBSearch.Text.Trim());
        }
    }
}
