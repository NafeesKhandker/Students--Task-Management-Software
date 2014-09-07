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
using System.Windows.Navigation;
using System.Windows.Shapes;
using MyStudentLifeController;
using MyStudentLifeModel;
using System.Data;

namespace MyStudyLife
{
    /// <summary>
    /// Interaction logic for UserControlSearch.xaml
    /// </summary>
    public partial class UserControlSearch : UserControl
    {

        public string newTask = "New Task";

        public UserControlSearch()
        {
            InitializeComponent();
            comboBoxFilter.SelectedIndex = 0;
        }

        private void textBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            ModelClass modelSearch = new ModelClass();

            if (textBoxSearch.Text != "")
            {
                if (comboBoxFilter.SelectedIndex == 0)
                {
                    DataTable dataTbl = modelSearch.SearchTask(textBoxSearch.Text);
                    dataGridSearch.ItemsSource = dataTbl.DefaultView;
                }

                else if (comboBoxFilter.SelectedIndex == 1)
                {
                    DataTable dataTbl = modelSearch.SearchExam(textBoxSearch.Text);
                    dataGridSearch.ItemsSource = dataTbl.DefaultView;
                }

                else if (comboBoxFilter.SelectedIndex == 2)
                {
                    DataTable dataTbl = modelSearch.SearchClass(textBoxSearch.Text);
                    dataGridSearch.ItemsSource = dataTbl.DefaultView;
                }
            }

            else
            {
                dataGridSearch.ItemsSource = null;
            }

        }

        private void comboBoxFilter_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ModelClass modelSearch = new ModelClass();

            if (textBoxSearch.Text != "")
            {
                if (comboBoxFilter.SelectedIndex == 0)
                {
                    DataTable dataTbl = modelSearch.SearchTask(textBoxSearch.Text);
                    dataGridSearch.ItemsSource = dataTbl.DefaultView;
                }

                else if (comboBoxFilter.SelectedIndex == 1)
                {
                    DataTable dataTbl = modelSearch.SearchExam(textBoxSearch.Text);
                    dataGridSearch.ItemsSource = dataTbl.DefaultView;
                }

                else if (comboBoxFilter.SelectedIndex == 2)
                {
                    DataTable dataTbl = modelSearch.SearchClass(textBoxSearch.Text);
                    dataGridSearch.ItemsSource = dataTbl.DefaultView;
                }
            }

            else
            {
                dataGridSearch.ItemsSource = null;
            }
        }
    }
}
