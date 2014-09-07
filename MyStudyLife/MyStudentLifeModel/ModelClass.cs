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

        public static string userEmail = "nafees.ku11@gmail.com";
        public string connectionString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\Nafees Khandker\Documents\Visual Studio 2010\Projects\MyStudyLife\MyStudentLifeModel\DBMyStudyLife.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

        public void UserKey(string email)
        {

            userEmail = email;
        
        }


        public bool SignUpInsertion(string firstName, string lastName, string email, string password)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {

                string query = "INSERT INTO Tbl_SignUpInfo (First_Name, Last_Name, Email, Password) VALUES ('"+firstName+"', '"+lastName+"' , '"+email+"', '"+password+"')";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
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

        public int SignIn(string email, string password)
        {

            int count = 0;
            SqlConnection conn = new SqlConnection(connectionString);
            try
            {

                string query = "SELECT First_Name, Last_Name, Email, Password FROM Tbl_SignUpInfo WHERE (Email = '"+email+"') AND (Password = '"+password+"')";
              
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader;
                conn.Open();

                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    count++;
                }

                return count;

            }

            catch (Exception)
            {

                return 911;

            }

            finally
            {

                conn.Close();
            
            }

        }

        public DataTable FilterTask(string subject)
        {

            SqlConnection conn = new SqlConnection(connectionString);
            try
            {

                string query = "SELECT Title, Subject, Type, DueDate FROM Tbl_Task WHERE UPPER(Subject) LIKE '%" + subject + "%'";

                SqlCommand cmd = new SqlCommand(query, conn);
                conn.Open();
                cmd.ExecuteNonQuery();

                SqlDataAdapter dataAdp = new SqlDataAdapter(cmd);
                DataTable dataTbl = new DataTable("Tbl_Task");
                dataAdp.Fill(dataTbl);
                dataAdp.Update(dataTbl);
                return dataTbl;

            }

            catch (Exception e)
            {

                conn.Close();
                return null;

            }

            finally
            {

                conn.Close();

            }


        }
        
    }
}
