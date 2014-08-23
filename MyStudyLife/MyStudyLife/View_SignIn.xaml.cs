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
using System.Diagnostics;

namespace MyStudyLife
{
    /// <summary>
    /// Interaction logic for View_SignIn.xaml
    /// </summary>
    public partial class View_SignIn : Window
    {
        public View_SignIn()
        {
            InitializeComponent();
        }

        private void buttonSignIn_Click(object sender, RoutedEventArgs e)
        {
            int status;
            ModelClass model = new ModelClass();
            status = model.SignIn(textBoxEmail.Text, passwordBoxPassword.Password);

            switch (status)
            {
                case 0:
                    labelAlert.Content = "Wrong Username or Password!";
                    textBoxEmail.Text = null;
                    passwordBoxPassword.Password = null;
                    break;

                case 1:
                    View_home home = new View_home();
                    App.Current.MainWindow = home;
                    this.Close();
                    home.Show();
                    break;

                case 911:
                    System.Windows.MessageBox.Show("Can not Sign Up because of a severe Database problem! Please try later.");
                    break;

                default:
                    labelAlert.Content = "Duplicate Username and Password!";
                    break;

            }
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

        private void WnidowSignIn_Loaded(object sender, RoutedEventArgs e)
        {

        }
    }
}
