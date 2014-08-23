using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;


namespace MyStudentLifeModel
{
    public class ModelClass
    {
       
        String connectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Nafees Khandker\Documents\Visual Studio 2010\Projects\MyStudyLife\MyStudentLifeModel\DBMyStudyLife.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

        public bool SignUpInsertion(string firstName, string lastName, string email, string password)
        {

            SqlConnection conn = new SqlConnection(connectionString);
            try
            {

                string query = "INSERT INTO Tbl_SignUpInfo (First_Name, Last_Name, Email, Password) VALUES (@firstName, @lastName, @email, @password)";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                /*string connString = "server=localHost;user id=root;persistsecurityinfo=True;database=DBMyStdLife";
                string query = "INSERT INTO `dbmystdlife`.`tblsignup`(`FirstName`,`LastName`,`Email`,`Password`) VALUES (firstName, lastName, email, password);";

                MySqlConnection conn = new MySqlConnection(connString);
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader dataReader;

                conn.Open();
                dataReader = cmd.ExecuteReader();

                while (dataReader.Read())
                {

                }

                conn.Close();*/
                return true;
            }

            catch (Exception e)
            {

                conn.Close();
                return false;

            }

            finally
            {

                conn.Close();

            }
        }

        public void SignIn()
        {

           
           

        }
    }
}
