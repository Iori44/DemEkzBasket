using System;
using System.Windows;

namespace WpfApp1
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string login = tbLogin.Text;
            string password = tbPassword.Password;

            // Ваш код проверки логина и пароля
        }

        private void LoginWindow_Closed(object sender, EventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}