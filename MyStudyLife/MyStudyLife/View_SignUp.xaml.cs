﻿using System;
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
using System.Windows.Forms;
using System.Diagnostics;
using System.Text.RegularExpressions;
using MyStudentLifeController;
using MyStudentLifeModel;


namespace MyStudyLife
{
    /// <summary>
    /// Interaction logic for View_SignUp.xaml
    /// </summary>
    public partial class View_SignUp : Window
    {
        public View_SignUp()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, RoutedEventArgs e)
        {
            View_StartUp startUp = new View_StartUp();
            App.Current.MainWindow = startUp;
            this.Close();
            startUp.Show();
        }

        private void buttonQuit_Click(object sender, RoutedEventArgs e)
        {

            MessageBoxResult result = System.Windows.MessageBox.Show("Do you want to quit this application?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Question);
            if (result == MessageBoxResult.Yes)
            {
                Process.GetCurrentProcess().Kill();
            }

        }

        private void passwordBoxPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {

           
        }

        private void textBoxFirstName_TextChanged(object sender, TextChangedEventArgs e)
        {
          
        }

        private void WindowSignUp_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void buttonSignUp_Click(object sender, RoutedEventArgs e)
        {

            
            
        }

        private void textBoxEmail_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void textBoxConfirmEmail_TextChanged(object sender, TextChangedEventArgs e)
        {

            
        }

        private void passwordBoxConfirmPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {

            

        }

        

    }
}