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

        private void buttonDashBoard_Click(object sender, RoutedEventArgs e)
        {
            gridHome.Children.Clear();

            UserControlDashBoard ucDashBoard = new UserControlDashBoard();
            gridHome.Children.Add(ucDashBoard);
        }

        private void buttonTask_Click(object sender, RoutedEventArgs e)
        {
            gridHome.Children.Clear();
            gridHome.Children.Add(gridHeader);
            labelCurrent.Visibility = Visibility.Visible;
            comboBoxCurrentTask.Visibility = Visibility.Visible;
            comboBoxCurrentTask.SelectedIndex = 0;
            buttonNew.Content = strNewTask;
            labelHeader.Content = "Tasks";
            labelCurrent.Content = "Tasks";
            gridHome.Children.Add(gridFilter);
            buttonNewAlt.Content = "New Task";
            gridHome.Children.Add(gridNew);


            RefreshDataCurrentTask();



        }

        private void comboBoxCurrentTask_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (buttonNew.Content == strNewTask)
            {

                if (comboBoxCurrentTask.SelectedIndex == 0)
                {

                    RefreshDataCurrentTask();

                }

                else
                {

                    RefreshDataPastTask();

                }

            }

            else if (buttonNew.Content == strNewExam)
            {
                if (comboBoxCurrentTask.SelectedIndex == 0)
                {

                    RefreshDataCurrentExam();

                }

                else
                {

                    RefreshDataPastExam();

                }
            }

        }

        private void textBoxFilterByYear_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void buttonNew_Click(object sender, RoutedEventArgs e)
        {

            if (buttonNew.Content == strNewTask)
            {
                gridHome.Children.Clear();
                gridHome.Children.Add(gridHeader);
                //gridFilter.Width = 459;
                //labelCurrent.Content = "Current Tasks";
                gridHome.Children.Add(gridFilter);
                gridHome.Children.Add(gridNewTask);

            }

            else if (buttonNew.Content == strNewExam)
            {

                gridHome.Children.Clear();
                gridHome.Children.Add(gridHeader);
                //gridFilter.Width = 459;
                gridHome.Children.Add(gridFilter);
                gridHome.Children.Add(gridExam);

            }

            else if (buttonNew.Content == strNewClass)
            {

                gridHome.Children.Clear();
                gridHome.Children.Add(gridHeader);
                //gridFilter.Width = 459;
                gridHome.Children.Add(gridFilter);
                gridHome.Children.Add(gridClass);

            }
        }

        private void buttonExam_Click(object sender, RoutedEventArgs e)
        {
            labelHeader.Content = "Exams";
            labelCurrent.Content = "Exams";
            buttonNew.Content = strNewExam;
            labelCurrent.Visibility = Visibility.Visible;
            comboBoxCurrentTask.Visibility = Visibility.Visible;
            comboBoxCurrentTask.SelectedIndex = 0;
            gridHome.Children.Clear();
            gridHome.Children.Add(gridHeader);
            gridHome.Children.Add(gridFilter);
            buttonNewAlt.Content = strNewExam;
            gridHome.Children.Add(gridNew);

            RefreshDataCurrentExam();

        }


	 private void buttonClasses_Click(object sender, RoutedEventArgs e)
        {
            labelHeader.Content = "Classes";
            buttonNew.Content = strNewClass;
            buttonNewAlt.Content = strNewClass;
            labelCurrent.Visibility = Visibility.Hidden;
            comboBoxCurrentTask.Visibility = Visibility.Hidden;
  
            gridHome.Children.Clear();
            gridHome.Children.Add(gridHeader);
            gridHome.Children.Add(gridFilter);
            gridHome.Children.Add(gridNew);

            RefreshDataClass();
        }

	private void buttonNCSave_Click(object sender, RoutedEventArgs e)
        {

            ModelClass model = new ModelClass();
            model.ClassInsertion(textBoxNCSubject.Text, textBoxNCModule.Text, textBoxNCRoom.Text, textBoxNCBuilding.Text, textBoxNCTeacher.Text, datePickerNCDate.Text, textBoxNCStartTime.Text, textBoxNCEndTime.Text);

            RefreshClass();
            RefreshDataClass();

        }
	
	private void buttonNCCancel_Click(object sender, RoutedEventArgs e)
        {
            RefreshClass();
        }

        private void buttonNECancel_Click(object sender, RoutedEventArgs e)
        {

            RefreshExam();
        
        }
        
    }
}
