using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows;
using System.Collections;

namespace SampleSystem
{
    class CrudConfiguration
    {
        public bool saveTrans(string table, string[] cols, string[] vals)
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
                    string query = "INSERT INTO " + table + " (" + getColumns(cols) + ") VALUES (" + separateParam(param) + ")   ";
                    SqlCommand cmd = new SqlCommand(query, con.Con);
                    int count = 0;
                    foreach (string paramX in vals)
                    {
                        var valParam = "@param" + count.ToString();
                        cmd.Parameters.AddWithValue(valParam, paramX);
                        Console.WriteLine("param:" + valParam + "   value:" + paramX);
                        count += 1;
                    }
                    Console.WriteLine(query);
                    cmd.ExecuteNonQuery();
                    
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
                
            }
            return true;
        }

        public bool updateTrans(string table, string[] cols, string[] vals, Dictionary<string, string> conds)
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
                if (con != null)
                {
                    string query = "UPDATE " + table + " SET "+ joinedColsVals(cols, param) + " WHERE "+ iterateCond(conds);
                    SqlCommand cmd = new SqlCommand(query, con.Con);
                    int count = 0;
                    foreach (string paramX in vals)
                    {
                        var valParam = "@param" + count.ToString();
                        cmd.Parameters.AddWithValue(valParam, paramX);
                        Console.WriteLine("param:" + valParam + "   value:" + paramX);
                        count += 1;
                    }
                    Console.WriteLine(query);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }
            return true;
        }

        public bool deleteTrans(string table, Dictionary<string, string> conds)
        {
            try
            {
                SqlConnect con = new SqlConnect();
                con.conOpen();
                if (con != null)
                {
                    string query = "DELETE FROM  " + table + " WHERE " + iterateCond(conds);
                    SqlCommand cmd = new SqlCommand(query, con.Con);
                    Console.WriteLine(query);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;

            }
            return true;
        }

        public string iterateCond(Dictionary<string, string> condtns)
        {
            string concatConds = "";
            string last = condtns.Values.Last();
            foreach(var item in condtns)
            {
                if (!item.Value.Equals(last))
                {
                    concatConds += item.Key + "=" + item.Value + ", ";
                }
                else
                {
                    concatConds += item.Key + "=" + item.Value;
                }
                
            }
            return concatConds;
        }

        public string joinedColsVals(string[] cols, string[] vals)
        {
            string concatVals = "";
            for(int x = 0; x < cols.Length; x++)
            {
                if(cols[cols.Length - 1] == cols[x])
                {
                    concatVals += cols[x] + " = " + vals[x];
                }
                else
                {
                    concatVals += cols[x] + " = " + vals[x] + ", ";
                }
                
            }
            Console.WriteLine(concatVals);
            return concatVals;
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
                if (!x.Equals(lastelem))
                {
                    definedvals += x + ",";
                }
                else
                {
                    definedvals += x;
                }
            return definedvals;
        }

    }

}
