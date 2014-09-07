using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Datetime
{
    class Today
    {
        string today;        
        string conString;
        string selectTodaySql;
        string TableName;

        SqlConnection con;
        SqlCommand cmd;

        public Today(string conStringName, string table, string dateTimeFormat)
        {
            TableName = table;
            today = DateTime.Now.ToString(dateTimeFormat);            
            conString = conStringName;
            con = new SqlConnection(conString);
            selectTodaySql = " SELECT * FROM " + TableName + " WHERE date = @today";
            cmd = new SqlCommand(selectTodaySql, con);
            cmd.Parameters.Add(new SqlParameter("today", today));

        }

        public List<string> getTodayBy(string columnName)
        {


            List<string> list = new List<string>();

            try
            {
                con.Open();

                using (SqlDataReader read = cmd.ExecuteReader())
                {
                    while (read.Read())
                    {
                        list.Add((read[columnName].ToString()));
                    }
                }

                
            }
            finally
            {
                con.Close();
            }

            return list;
        }
        }
    }

