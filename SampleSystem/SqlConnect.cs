using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows;

namespace SampleSystem
{
    class SqlConnect
    {

        public SqlConnection Con { get; set; }
        public string conString { get; set; }


        public void conOpen()
        {
            conString = @"Data Source= P2B4RND231\SQLEXPRESS; Initial Catalog= DBLib; Integrated Security = True;";
            Con = new SqlConnection(conString);
            try
            {
                Con.Open();
            }
            catch (Exception ex) {
                MessageBox.Show("Please check the connection.");
                Console.Write("Cannot connect. Check the connection");
            }
        }

        public void conclose()
        {
            Con.Close();
        }


    }

    
}
