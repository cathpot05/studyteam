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
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SampleSystem
{
    /// <summary>
    /// Interaction logic for BarrowerUC.xaml
    /// </summary>
    public partial class BarrowerUC : UserControl
    {
        public BarrowerUC()
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
        private void clearControls()
        {
            txtBarrowerId.Text = "";
            txtFname.Text = "";
            txtLname.Text = "";
            cboCourse.Text = "";
        }
        public void loadCourse()
        {
            SqlConnect con = new SqlConnect();
            con.conOpen();
            if (con != null)
            {
                string q = "SELECT course_id, coursecode FROM tblCourse";
                SqlCommand cmd = new SqlCommand(q, con.Con);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataSet dt = new DataSet();
                sda.Fill(dt, "tblCourse");
                cboCourse.ItemsSource = dt.Tables[0].DefaultView;
                cboCourse.DisplayMemberPath = dt.Tables[0].Columns["coursecode"].ToString();
                cboCourse.SelectedValuePath = dt.Tables[0].Columns["course_id"].ToString();
            }
            else
            {
                return;
            }
            con.conclose();
        }


        private void gridBarrowerLoad(string value)
        {
            var _condition = "";
            if (value == "")
            {
                _condition = "";
            }
            else
            {
                _condition = "WHERE A.barrower_fname LIKE '%" + @value + "%' OR A.barrower_lastname LIKE '%" + @value + "%' OR B.coursecode LIKE '%" + @value + "%'";

            }

            SqlConnect con = new SqlConnect();
            con.conOpen();
            if (con != null)
            {
                string q = "SELECT A.*, B.course_id FROM tblBarrower A INNER JOIN tblCourse B ON A.course = B.course_id " + _condition;
                SqlCommand cmd = new SqlCommand(q, con.Con);
                cmd.Parameters.AddWithValue("@value", value);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                dgBarrower.ItemsSource = dt.DefaultView;
                dgBarrower.Columns[0].Header = "Barrower Id";
                dgBarrower.Columns[1].Header = "First Name";
                dgBarrower.Columns[2].Header = "Last Name";
                dgBarrower.Columns[3].Header = "Course";
            }
                
            else
            {
                return;
            }
            con.conclose();
        }

        private void txtUBSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            gridBarrowerLoad(this.txtUBSearch.Text.Trim());
        }

        private void txtUBSearch_LostFocus(object sender, RoutedEventArgs e)
        {
            if (this.txtUBSearch.Text == "")
            {
                txtSearchToolTip.Visibility = Visibility.Visible;
            }

        }

        private void txtUBSearch_GotFocus(object sender, RoutedEventArgs e)
        {
            txtSearchToolTip.Visibility = Visibility.Hidden;
        }

        private void enabledNewTransbutton()
        {
            btnB_Edit.Background = (ImageBrush)Resources["EditPress"];
            btnB_Delete.Background = (ImageBrush)Resources["DeletePress"];
            btnB_Save.Background = (ImageBrush)Resources["SaveNormal"];
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

        private void genKeyId()
        {
            SqlConnect con = new SqlConnect();
            con.conOpen();
            if (con !=null)
            {
                string q = "update tblSettings SET PrevVal = (SELECT NextVal FROM tblSettings WHERE id = 1 ) , NextVal = (SELECT(NextVal + 1) FROM tblSettings WHERE id = 1 ) WHERE id = 1";
                SqlCommand cmd = new SqlCommand(q, con.Con);
                cmd.ExecuteNonQuery();

                string query = "SELECT NextVal FROM tblSettings where id = 1";
                SqlCommand x = new SqlCommand(query, con.Con);
                SqlDataReader sdr = x.ExecuteReader();
                string latestval = "";
                while (sdr.Read())
                {
                    latestval = sdr["NextVal"].ToString();
                }

                string sdate = DateTime.Now.ToString();
                DateTime convertsdate = Convert.ToDateTime(sdate.ToString());
                string year = convertsdate.Year.ToString();
                string format = "101-"+year.ToString()+"-"+latestval.ToString();
                txtBarrowerId.Text = format;

            }
            else
            {
                return;
            }
            con.conclose();
        }

        private void dgBarrower_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {

            if (dgBarrower.SelectedIndex != -1)
            {
                DataRowView x = (DataRowView)dgBarrower.SelectedItems[0];
                txtBarrowerId.Text = x[0].ToString();
                txtFname.Text = x[1].ToString();
                txtLname.Text = x[2].ToString();
                cboCourse.SelectedValue = x[2].ToString();

            }
            modifyTrans();
        }

        private void btnB_Add_Click(object sender, RoutedEventArgs e)
        {
            clearControls();
            enabledNewTransbutton();
            genKeyId();
        }

        private void btnB_Edit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //let's check first if the textboxes are empty since we cannot allow a blank data
                if (txtFname.Text.Trim() == null || txtLname.Text.Trim() == null || cboCourse.Text == null)
                {
                    MessageBox.Show("Barrower information cannot be empty");
                    return;
                }
                SqlConnect con = new SqlConnect();
                con.conOpen();
                if (con != null)
                {
                    //let's check first if the data trying to change is already exist.

                    string check = "SELECT TOP 1 * FROM tblBarrower WHERE barrower_fname = @fname and barrower_lname = @lname and course = @course and barrower_id <> @id";
                    SqlCommand cmdcheck = new SqlCommand(check, con.Con);
                    cmdcheck.Parameters.AddWithValue("@fname", txtFname.Text.Trim());
                    cmdcheck.Parameters.AddWithValue("@lname", txtLname.Text.Trim());
                    cmdcheck.Parameters.AddWithValue("@course", cboCourse.SelectedValue.ToString());
                    cmdcheck.Parameters.AddWithValue("@id", txtBarrowerId.Text.Trim());
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
                        string query = "UPDATE tblBarrower SET  barrower_fname = @fname, barrower_lname = @lname, course = @course WHERE barrower_id = @id";
                        SqlCommand cmd = new SqlCommand(query, con.Con);
                        cmd.Parameters.AddWithValue("@fname", txtFname.Text.Trim());
                        cmd.Parameters.AddWithValue("@lname", txtLname.Text.Trim());
                        cmd.Parameters.AddWithValue("@course", cboCourse.SelectedValue.ToString());
                        cmd.Parameters.AddWithValue("@id", txtBarrowerId.Text.Trim());

                        cmd.ExecuteNonQuery();
                        gridBarrowerLoad("");
                        enabledNewTransbutton();
                        clearControls();
                        MessageBox.Show("Record updated successfully");
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
                    string check = "SELECT TOP 1 * FROM tblTransaction WHERE barrower_id = @id";
                    SqlCommand cmdcheck = new SqlCommand(check, con.Con);
                    cmdcheck.Parameters.AddWithValue("@id", txtBarrowerId.Text.Trim());
                    SqlDataReader sdr = cmdcheck.ExecuteReader();

                    if (sdr.Read()) //if theres a record, return, meaning we cannot allow it
                    {
                        MessageBox.Show("Cannot delete record, the data you are trying to delete has a history on main transaction.");
                        sdr.Close();
                        return;
                    }
                    else //we can change or update it
                    {
                        sdr.Close();
                        string query = "DELETE FROM tblBarrower WHERE barrower_id = @id";
                        SqlCommand cmd = new SqlCommand(query, con.Con);
                        cmd.Parameters.AddWithValue("@id", txtBarrowerId.Text.Trim());
                        cmd.ExecuteNonQuery();
                        gridBarrowerLoad("");
                        enabledNewTransbutton();
                        clearControls();
                        MessageBox.Show("Record deleted successfully");
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

        private void btnB_Save_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                //let's check first if the textboxes are empty since we cannot allow a blank data
                if (txtBarrowerId.Text.Trim() == null || txtFname.Text.Trim() == null || txtLname.Text == null)
                {
                    MessageBox.Show("Barrower info cannot be empty");
                    return;
                }

                SqlConnect con = new SqlConnect();
                con.conOpen();
                if (con != null)
                {
                    //let's check first if the data trying to change is already exist.
                    string check = "SELECT TOP 1 * FROM tblBarrower WHERE barrower_fname = @fname and barrower_lname = @lname";
                    SqlCommand cmdcheck = new SqlCommand(check, con.Con);
                    cmdcheck.Parameters.AddWithValue("@fname", txtFname.Text.Trim());
                    cmdcheck.Parameters.AddWithValue("@lname", txtFname.Text.Trim());
                    SqlDataReader sdr = cmdcheck.ExecuteReader();

                    if (sdr.Read()) //if theres a record, return, meaning we cannot allow it
                    {
                        MessageBox.Show("Cannot add this record, the data you are trying to insert already exist.");
                        sdr.Close();
                        return;
                    }
                    else //we can add or insert it
                    {
                        sdr.Close();
                        string query = "INSERT INTO tblBarrower (barrower_id, bookauthor_id, barrower_fname, barrower_lname, course) VALUES (@id, @fname, @lname, @course)";
                        SqlCommand cmd = new SqlCommand(query, con.Con);
                        cmd.Parameters.AddWithValue("@id", txtBarrowerId.Text.Trim());
                        cmd.Parameters.AddWithValue("@fname", txtFname.Text.Trim());
                        cmd.Parameters.AddWithValue("@lname", txtLname.Text.Trim());
                        cmd.Parameters.AddWithValue("@course", cboCourse.SelectedValue.ToString());
                        //cmd.Parameters.AddWithValue("@stocks", txtbStocks.Text.Trim());

                        cmd.ExecuteNonQuery();
                        gridBarrowerLoad("");
                        enabledNewTransbutton();
                        clearControls();
                        MessageBox.Show("Record saved successfully");
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

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            gridBarrowerLoad("");
            loadCourse();
        }
    }
}
