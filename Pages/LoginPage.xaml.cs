using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media.Animation;

namespace ProyectoFinalProgramacionII
{
    public partial class LoginPage : Page
    {
        public LoginPage()
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

        private void BtnLogin_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrEmpty(TxtEmail.Text) && !string.IsNullOrEmpty(TxtPassword.Password))
            {
                MessageBox.Show("Succesfully Signed In");
            }
        }

        private void Image_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void BtnGoSignInPage_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as MainWindow)?.NavigateToSignInPage();
        }
        
    }
}