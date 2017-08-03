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
    /// Interaction logic for CourseUC.xaml
    /// </summary>
    public partial class CourseUC : UserControl
    {
        public CourseUC()
        {
            InitializeComponent();
            #region Button's Func_Leave Mouse
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

        private void modifyTrans()
        {
            btnA_Edit.Background = (ImageBrush)Resources["EditNormal"];
            btnA_Delete.Background = (ImageBrush)Resources["DeleteNormal"];
            btnA_Save.Background = (ImageBrush)Resources["SavePress"];


            btnA_Edit.IsEnabled = true;
            btnA_Delete.IsEnabled = true;
            btnA_Save.IsEnabled = false;
        }

        private void enabledNewTransbutton()
        {
            btnA_Edit.Background = (ImageBrush)Resources["EditPress"];
            btnA_Delete.Background = (ImageBrush)Resources["DeletePress"];
            btnA_Save.Background = (ImageBrush)Resources["SaveNormal"];
            btnA_Edit.IsEnabled = false;
            btnA_Delete.IsEnabled = false;
            btnA_Save.IsEnabled = true;
            btnA_Add.IsEnabled = true;
        }

        private void CourseLoad(string value)
        {
            var _condition = "";
            if (value == "")
            {
                _condition = "";
            }
            else
            {
                _condition = "WHERE coursecode LIKE '%" + @value + "%' OR coursedesc LIKE '%" + @value + "%'";

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
                    string q = "SELECT * FROM tblCourse " + _condition;
                    SqlCommand cmd = new SqlCommand(q, con.Con);
                    cmd.Parameters.AddWithValue("@value", value);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    DataSet ds = new DataSet();
                    DataTable dt = new DataTable();
                    sda.Fill(dt);
                    dgCourse.ItemsSource = dt.DefaultView;
                    dgCourse.Columns[0].Visibility = Visibility.Collapsed;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            con.conclose();
        }


        private void clearControls()
        {
            txtCcode.Text = "";
            txtCourseiD.Text = "";
            txtCdesc.Text = "";
        }

        private void dgCourse_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (dgCourse.SelectedIndex != -1)
            {

                DataRowView x = (DataRowView)dgCourse.SelectedItems[0];
                txtCourseiD.Text = x[0].ToString();
                txtCcode.Text = x[1].ToString();
                txtCdesc.Text = x[2].ToString();
            }
            modifyTrans();

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
                if (txtCcode.Text.Trim() == null || txtCdesc.Text.Trim() == null)
                {
                    MessageBox.Show("Course Data cannot be empty");
                    return;
                }

                SqlConnect con = new SqlConnect();
                con.conOpen();
                if (con != null)
                {
                    //let's check first if the data trying to change is already exist.
                    string check = "SELECT TOP 1 * FROM tblCourse WHERE coursecode = @course and courseid <> @id";
                    SqlCommand cmdcheck = new SqlCommand(check, con.Con);
                    cmdcheck.Parameters.AddWithValue("@course", txtCcode.Text.Trim());
                    cmdcheck.Parameters.AddWithValue("@id", txtCourseiD.Text.Trim());
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
                        string query = "UPDATE tblcourse SET coursecode = @ccode, coursedesc = @cdesc WHERE courseid = @id";
                        SqlCommand cmd = new SqlCommand(query, con.Con);
                        cmd.Parameters.AddWithValue("@ccode", txtCcode.Text.Trim());
                        cmd.Parameters.AddWithValue("@cdesc", txtCdesc.Text.Trim());
                        cmd.Parameters.AddWithValue("@id", txtCourseiD.Text.Trim());
                        cmd.ExecuteNonQuery();
                        CourseLoad("");
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

        private void btnA_Delete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnA_Save_Click(object sender, RoutedEventArgs e)
        {

        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            CourseLoad("");
        }
    }
}
