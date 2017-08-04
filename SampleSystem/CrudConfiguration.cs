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
    class CrudConfiguration
    {
        public bool saveTrans(string table, string[] cols, string[] vals, string conditions)
        {
           try
            {
                SqlConnect con = new SqlConnect();
                con.conOpen();
                string[] param = new string[vals.Length];
                for (int y = 0; y < vals.Length; y++)
                {
                    param[y] = "@param" + y.ToString();
                }
                //param = param.TrimEnd(param[param.Length - 1]);

                if (con != null)
                {
                    string query = "INSERT INTO " + table + " (" + getColumns(cols) + ") VALUES (" + separateParam(param) + ") " + conditions + "  ";
                    SqlCommand cmd = new SqlCommand(query, con.Con);
                    int count = 0;
                    foreach (string paramX in vals)
                    {
                        var valParam = "@param" + count.ToString();
                        cmd.Parameters.AddWithValue(valParam, paramX.Trim());
                        count += 1;
                    }
                    cmd.ExecuteNonQuery();
                    Console.WriteLine(query);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            return true;
        }

        public string getColumns(string[] columns)
        {
            string definedCol = "";
            string last = columns.Last();
            foreach(string col in columns)
            {
                if (!col.Equals(last))
                {
                    definedCol += col + ",";
                }
                else
                {
                    definedCol += col;
                }
            }
            return definedCol;
        }

        public string setVals(string[] vals)
        {
            string definedvals = "";
            string lastelem = vals.Last();
            foreach (string x in vals) { 
                if (!x.Equals(lastelem))
                {
                    definedvals += "'" + x + "' ,";
                }
                else
                {
                    definedvals += "'" + x + "'";
                }
            }
            return definedvals;
                 
        }


        public string separateParam(string[] vals)
        {
            string definedvals = "";
            string lastelem = vals.Last();
            foreach (string x in vals)
            {
                definedvals += x;
            }
            return definedvals;
        }

    }

}
