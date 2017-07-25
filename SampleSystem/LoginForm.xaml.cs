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
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;

namespace SampleSystem
{
    /// <summary>
    /// Interaction logic for LoginForm.xaml
    /// </summary>
    public partial class LoginForm : Window
    {
        MainWindow n = new MainWindow();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            SqlConnect con = new SqlConnect();
            con.conOpen();
            if(con == null)
            {
                return;  

            }else
            {
                Console.WriteLine("Successfully Connected");
                SqlCommand cmd = new SqlCommand("SELECT * FROM tblUsers WHERE username = @username and password = @password ", con.Con);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", txtPassword.Password);

                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (sda.Fill(dt) > 0)
                {
                    Console.WriteLine("Valid Account");
                    con.conclose();
                    this.Close();
                    n.Show();
                }
                else
                {
                    Console.WriteLine("Invalid Account");
                }


                //SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM tblUsers WHERE username = '"+ txtUsername.Text +"' and password = '"+ txtPassword.Password +"' ", con.Con);
                //parametarized
                //string sql = "SELECT * FROM tblUsers WHERE username = @username and password = @password ";
                //using (SqlCommand cmd = new SqlCommand(sql, con.Con))
                //{
                //    var acctParam = new SqlParameter("username", SqlDbType.VarChar);
                //    acctParam.Value = txtUsername.Text;
                //    cmd.Parameters.Add(acctParam);
                //    var results = cmd.ExecuteReader();
                //}
            }
        }
    }
}
