using itogovoe_gibdd.Database;
using Microsoft.Data.Sqlite;
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

namespace itogovoe_gibdd
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            LoginTextBox.Text = string.Empty;
        }

        private void PasswordTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            PasswordTextBox.Text = string.Empty;
        }

        private bool CheckCredentials(string login, string password)
        {
            DbConnect.dB = new ItogovoeGibddContext();
            var profile = DbConnect.dB.Profiles.FirstOrDefault(p => p.Login == login && p.Password == password);
            return profile != null;
        }

        private void Page_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                LoginButton.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
            }
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string login = LoginTextBox.Text;
            string password = PasswordTextBox.Text;

            bool isValidUser = CheckCredentials(login, password);

            if (isValidUser)
            {
                NavigationService?.Navigate(new StartPage());
            }
            else
            {
                MessageBox.Show("Данные введены неверно.");
            }
        }
    }
}
