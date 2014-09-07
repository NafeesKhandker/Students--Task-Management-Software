using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using MyStudentLifeModel;
using System.Data;

namespace MyStudyLife
{
    /// <summary>
    /// Interaction logic for View_Home1.xaml
    /// </summary>
    public partial class View_Home : Window
    {

        public string strNewTask = "New Task";
        public string strNewExam = "New Exam";
        public string strNewClass = "New Class";

        public View_Home()
        {
            InitializeComponent();
            gridHome.Children.Clear();

            gridHome.Children.Clear();

            UserControlDashBoard ucDashBoard = new UserControlDashBoard();
            gridHome.Children.Add(ucDashBoard);
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void buttonCalender_Click(object sender, RoutedEventArgs e)
        {

        }

        

        
    }
}
