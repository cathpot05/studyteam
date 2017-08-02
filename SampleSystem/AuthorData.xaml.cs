
using System.Windows;
using System.Windows.Controls;
using System.Data.SqlClient;
using System.Data;
using System;
using System.Windows.Media;
using System.Linq;

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
            #region Button's Func_Leave Mouse
             foreach (StackPanel CrudPanels in FunctionButtons.Children)
            {
                foreach(Button CrudButtons in CrudPanels.Children.OfType<Button>())
                {
                    Action<string> CrudButtonFunctions = (Buttons) =>
                    {
                        switch (Buttons)
                        {
                            case "btnA_Add":
                                {
                                    btnA_Add.Background = (ImageBrush)Resources["AddNormal"];
                                }
                                break;
                            case "btnA_Edit":
                                {
                                    btnA_Edit.Background = (ImageBrush)Resources["EditNormal"];
                                }
                                break;
                            case "btnA_Delete":
                                {
                                    btnA_Delete.Background = (ImageBrush)Resources["DeleteNormal"];
                                }
                                break;
                            case "btnA_Save":
                                {
                                    btnA_Save.Background = (ImageBrush)Resources["SaveNormal"];
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
            foreach (StackPanel CrudPanels in FunctionButtons.Children)
            {
                foreach (Button CrudButtons in CrudPanels.Children.OfType<Button>())
                {
                    Action<string> CrudButtonFunctions = (Buttons) =>
                    {
                        switch (Buttons)
                        {
                            case "btnA_Add":
                                {
                                    btnA_Add.Background = (ImageBrush)Resources["AddPress"];
                                }
                                break;
                            case "btnA_Edit":
                                {
                                    btnA_Edit.Background = (ImageBrush)Resources["EditPress"];
                                }
                                break;
                            case "btnA_Delete":
                                {
                                    btnA_Delete.Background = (ImageBrush)Resources["DeletePress"];
                                }
                                break;
                            case "btnA_Save":
                                {
                                    btnA_Save.Background = (ImageBrush)Resources["SavePress"];
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

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            AuthorLoad("");
            enabledNewTransbutton();

        }

        private void clearControls()
        {
            txtAuthorFname.Text = "";
            txtAuthorLname.Text = "";
            txtAuthoriD.Text = "";
        }

        private void enabledNewTransbutton()
        {
            btnA_Edit.Background = (ImageBrush)Resources["EditPress"];
            btnA_Delete.Background = (ImageBrush)Resources["DeletePress"];
            btnA_Save.Background = (ImageBrush)Resources["SaveNormal"];
            //var editImg = new ImageBrush();
            //editImg.ImageSource = new BitmapImage(new Uri(@"Images\crud_edit_disable.png", UriKind.Relative));
            //btnA_Edit.Background = editImg;

            btnA_Edit.IsEnabled = false;
            btnA_Delete.IsEnabled = false;
            btnA_Save.IsEnabled = true;
            btnA_Add.IsEnabled = true;
        }

        private void modifyTrans()
        {
            btnA_Edit.Background = (ImageBrush)Resources["EditNormal"];
            btnA_Delete.Background = (ImageBrush)Resources["DeleteNormal"];
            btnA_Save.Background = (ImageBrush)Resources["SavePress"];


            btnA_Edit.IsEnabled = true;
            btnA_Delete.IsEnabled = true;
            btnA_Save.IsEnabled = false;

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

        private void btnA_Add_Click(object sender, RoutedEventArgs e)
        {
            clearControls();
            enabledNewTransbutton();

        }

        private void btnA_Edit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //let's check first if the textboxes are empty since we cannot allow a blank data
                if(txtAuthorFname.Text.Trim() == null || txtAuthorFname.Text.Trim() == null)
                {
                    MessageBox.Show("Author name cannot be empty");
                    return;
                }

                SqlConnect con = new SqlConnect();
                con.conOpen();
                if(con  != null)
                {
                    //lets check first if the data trying to change is already exist.
                    string check = "SELECT TOP 1 * FROM tblAuthor WHERE author_fname = @fname and author_lname = @lname";
                    SqlCommand cmdcheck = new SqlCommand(check, con.Con);
                    cmdcheck.Parameters.AddWithValue("@fname", txtAuthorFname.Text.Trim());
                    cmdcheck.Parameters.AddWithValue("@lname", txtAuthorLname.Text.Trim());
                    SqlDataReader sdr = cmdcheck.ExecuteReader();

                    if (sdr.Read()) //if theres a record
                    {
                        MessageBox.Show("Cannot update record, the data you are trying to change already exist.");
                        sdr.Close();
                        return;
                    }
                    else //we can change or update it
                    {
                        sdr.Close();
                        string query = "UPDATE tblAuthor SET author_fname = @fname, author_lname = @lname WHERE authorid = @id";
                        SqlCommand cmd = new SqlCommand(query, con.Con);
                        cmd.Parameters.AddWithValue("@fname", txtAuthorFname.Text.Trim());
                        cmd.Parameters.AddWithValue("@lname", txtAuthorLname.Text.Trim());
                        cmd.Parameters.AddWithValue("@id", txtAuthoriD.Text.Trim());
                        cmd.ExecuteNonQuery();
                        AuthorLoad("");
                        enabledNewTransbutton();
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

        private void btnA_Delete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SqlConnect con = new SqlConnect();
                con.conOpen();
                if (con != null)
                {
                    //check first if theres any book from tblBooks that uses the id of author
                    string check = "SELECT TOP 1 * FROM tblBooks WHERE bookauthor_id = @id";
                    SqlCommand cmdcheck = new SqlCommand(check, con.Con);
                    cmdcheck.Parameters.AddWithValue("@id", txtAuthoriD.Text.Trim());
                    SqlDataReader sdr = cmdcheck.ExecuteReader();

                    if (sdr.Read()) //if theres a record
                    {
                        string booktitle = sdr["booktitle"].ToString(); // if ever the booktitle is ask, we can use this.
                        MessageBox.Show("Cannot delete record, there's a reference from book list.");
                        sdr.Close();
                        return;
                    }else //we can proceed to deleting of that record
                    {
                        sdr.Close();
                        string query = "DELETE FROM tblAuthor WHERE authorid = @id";
                        SqlCommand cmd = new SqlCommand(query, con.Con);
                        cmd.Parameters.AddWithValue("@id", txtAuthoriD.Text.Trim());
                        cmd.ExecuteNonQuery();
                        AuthorLoad("");
                        enabledNewTransbutton();
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

        private void btnA_Save_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //let's check first if textboxes are empty since we cannot insert blank data
                if (txtAuthorFname.Text.Trim() == null || txtAuthorLname.Text.Trim() == null)
                {
                    MessageBox.Show("Author name cannot be empty.");
                    return;
                }
                SqlConnect con = new SqlConnect();
                con.conOpen();
                if (con != null)
                {
                    //check first if the record trying to add is already exist
                    string check = "SELECT TOP 1 * FROM tblAuthor WHERE author_fname = @fname and author_lname = @lname";
                    SqlCommand cmdcheck = new SqlCommand(check, con.Con);
                    cmdcheck.Parameters.AddWithValue("@fname", txtAuthorFname.Text.Trim());
                    cmdcheck.Parameters.AddWithValue("@lname", txtAuthorLname.Text.Trim());
                    SqlDataReader sdr = cmdcheck.ExecuteReader();

                    if (sdr.Read()) //if theres a record
                    {
                        MessageBox.Show("Cannot Insert. The record you are trying to add is already exist. \n Author Firstname: "+txtAuthorFname.Text.Trim()+ " \n Author LastName: " +txtAuthorLname.Text.Trim()+" ");
                        sdr.Close();
                        return;
                    }
                    else //let's insert and add the data
                    {
                        sdr.Close();
                        string query = "INSERT INTO tblAuthor (author_fname, author_lname) VALUES (@fname, @lname)";
                        SqlCommand cmd = new SqlCommand(query, con.Con);
                        cmd.Parameters.AddWithValue("@fname", txtAuthorFname.Text.Trim());
                        cmd.Parameters.AddWithValue("@lname", txtAuthorLname.Text.Trim());
                        cmd.ExecuteNonQuery();
                        AuthorLoad("");
                        enabledNewTransbutton();
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
                txtAuthoriD.Text = x[0].ToString();
                txtAuthorFname.Text = x[1].ToString();
                txtAuthorLname.Text = x[2].ToString();
            }
            modifyTrans();
        }

        private void txtUASearch_TextChanged(object sender, TextChangedEventArgs e)
        {

            AuthorLoad(this.txtUASearch.Text.Trim());
        }
    }
}
