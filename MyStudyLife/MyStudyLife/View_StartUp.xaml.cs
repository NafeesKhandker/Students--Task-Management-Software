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

namespace MyStudyLife
{
    /// <summary>
    /// Interaction logic for View_Login.xaml
    /// </summary>
    public partial class View_StartUp : Window
    {
        public View_StartUp()
        {
            InitializeComponent();
         
            //gridHeader.Children.Clear();
            

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void image1_ImageFailed(object sender, ExceptionRoutedEventArgs e)
        {

        }


        private void buttonGetStarted_Click(object sender, RoutedEventArgs e)
        {

            System.Diagnostics.Process.Start("https://app.mystudylife.com/");

        }

        private void buttonSignUp_Click(object sender, RoutedEventArgs e)
        {
            View_SignUp signUp = new View_SignUp();
            App.Current.MainWindow = signUp;
            this.Close();
            signUp.Show();
        }

        private void buttonSignIn_Click(object sender, RoutedEventArgs e)
        {

            View_SignIn signin = new View_SignIn();
            
                    App.Current.MainWindow = signin;
                    this.Close();
                    signin.Show();
          
        }

    }
}
