using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace dashboard_Trial
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DateTime time = DateTime.Now;
            //string format = "MMM ddd d HH:mm yyyy";

            label2.Text = time.ToLongDateString();

            String conString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\cat lover\Documents\Visual Studio 2010\Projects\dashboard-Trial\dashboard-Trial\dashboardDatabase.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";

            //string conString = "Data Source=localhost;Initial Catalog=LoginScreen;Integrated Security=True";
            SqlConnection con = new SqlConnection(conString);

            string selectSql = " SELECT id FROM Table1 WHERE type = 'exam' ";
            SqlCommand cmd = new SqlCommand(selectSql, con);

            try
            {
                        con.Open();

                        using (SqlDataReader read = cmd.ExecuteReader())
                        {
                            while(read.Read())
                            {
                                //if ("exam" == read["type"].ToString())
                                    label7.Text += "  <>  " + (read["id"].ToString());

                                //textBox1.Text += "  :::  " + (read["id"].ToString());
                                //textBox2.Text += "  :::  " + (read["type"].ToString());

                                /*CustID.Text = (read["Customer_ID"].ToString());
                                CustName.Text = (read["Customer_Name"].ToString());
                                Add1.Text = (read["Address_1"].ToString());
                                Add2.Text = (read["Address_2"].ToString());
                                PostBox.Text = (read["Postcode"].ToString());
                                PassBox.Text = (read["Password"].ToString());
                                DatBox.Text = (read["Data_Important"].ToString());
                                LanNumb.Text = (read["Landline"].ToString());
                                MobNumber.Text = (read["Mobile"].ToString());
                                FaultRep.Text = (read["Fault_Report"].ToString());*/
                            }
                        }
                    }
                    finally
                    {
                        con.Close();
                    }

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
