using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SampleSystem
{
    class CrudConfiguration
    {
        //public string function;
        //public string table;
        //public string[] columns;
        //public string[] values;
        //public string[] conditionValues;


        public bool saveTrans(string table, string[] cols, string[] vals, string[] conditions)
        {
            SqlConnect con = new SqlConnect();
            con.conOpen();

            var columns = getColumns(cols);
            var values = setVals(vals);
            if (con != null)
            {
                string query = "INSERT INTO "+table+ " (" +columns+ ") VALUES ("+ values + ")";
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
            if (!vals.Equals(lastelem))
            {
                definedvals += vals + ",";
            }
            else
            {
                definedvals += vals;
            }
            return definedvals;
                 
        }

    }

}
