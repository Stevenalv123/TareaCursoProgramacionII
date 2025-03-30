using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ProyectoFinalProgramacionII.Pages
{
    public partial class SigninPage : Page
    {
        public SigninPage()
        {
            InitializeComponent();
        }
        private void TextEmail_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TxtEmail.Focus();
        }
        private void TxtEmail_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtEmail.Text))
            {
                TextEmail.Visibility = Visibility.Collapsed;
            }
            else
            {
                TextEmail.Visibility = Visibility.Visible;
            }
        }
        private void TextPassword_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TxtPassword.Focus();
        }
        private void TxtPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtPassword.Password))
            {
                TextPassword.Visibility = Visibility.Collapsed;
            }
            else
            {
                TextPassword.Visibility = Visibility.Visible;
            }
        }
        private void TextConfirmPassword_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TxtConfirmPassword.Focus();
        }
        private void TxtConfirmPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtConfirmPassword.Password))
            {
                TxtConfirmPassword.Visibility = Visibility.Collapsed;
            }
            else
            {
                TxtConfirmPassword.Visibility = Visibility.Visible;
            }
        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BtnSignIn_Click(object sender, RoutedEventArgs e)
        {
            if (TxtPassword.Password==TxtConfirmPassword.Password)
            {
                MessageBox.Show("Caballo");
            }
        }

        private void BtnGoLoginPage_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as MainWindow)?.NavigateToLoginPage();
        }
    }
}
