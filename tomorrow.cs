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


        }

        public List<string> getTomorrowBy(string columnName)
        {

            
            
        }


    }
}
