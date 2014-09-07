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
            

        }

        public List<string> getTodayBy(string columnName)
        {


            

        }
    }

