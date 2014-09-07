using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Datetime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            //connection string name
            string conString = @"Data Source=.\SQLEXPRESS;AttachDbFilename=C:\Users\cat lover\Documents\Visual Studio 2010\Projects\Datetime\Datetime\Database1.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
            
            //table name
            string tableName = "Table1";
            
            //date time format
            //date is kept in database as string, this makes access easier
            //if you have set the type of date in database as 'Date' (not 'string') then create a column of type 'string' and keep the date in string format their
            //you can easily pick date from date-time-picker and save them to database as string
            string dateTimeFormat = "d/M/yyyy";


            //lists for keeping primary keys of todays task and tomorrows tasks
            List<string> list1 = new List<string>();
            List<string> list2 = new List<string>();

            //create these classes and pass the parameters with the constructors
            Today today = new Today(conString, tableName, dateTimeFormat);
            Tomorrow tomorrow = new Tomorrow(conString, tableName, dateTimeFormat);

            //name of the column that you want to save in list
            string columnName = "name";

            //methods return a list
            list1 = today.getTodayBy(columnName);           
            list2 = tomorrow.getTomorrowBy(columnName);

            //output
            int sz1 = list1.Count - 1;

            for (int i = 0; i <= sz1; i++)
                textBox1.Text += list1[i];

            int sz2 = list2.Count - 1;

            for (int i = 0; i <= sz2; i++)
                textBox2.Text += list2[i];
            


           





            



            

            

        }
    }
}
