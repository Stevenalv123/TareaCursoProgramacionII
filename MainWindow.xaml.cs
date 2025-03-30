using ProyectoFinalProgramacionII.Pages;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProyectoFinalProgramacionII
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new LoginPage());
        }

        public void NavigateToSignInPage()
        {
            MainFrame.Navigate(new SigninPage());
        }

        public void NavigateToLoginPage()
        {
            MainFrame.Navigate(new LoginPage());
        }
    }
}
