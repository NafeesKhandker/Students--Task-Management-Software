using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace Datetime
{
    class Tomorrow
    {
        string tomorrow;
        string conString;        
        string selectTomorrowSql;        
        string TableName;

        SqlConnection con;
        SqlCommand cmd;

        public Tomorrow(string conStringName, string table, string dateTimeFormat)
        {
            TableName = table;            
            tomorrow = DateTime.Now.AddDays(1).ToString(dateTimeFormat);
            conString = conStringName;
            con = new SqlConnection(conString);
            selectTomorrowSql = " SELECT * FROM " + TableName + " WHERE date = @tomorrow";
            cmd = new SqlCommand(selectTomorrowSql, con);
            cmd.Parameters.Add(new SqlParameter("tomorrow", tomorrow));

        }

        public List<string> getTomorrowBy(string columnName)
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
