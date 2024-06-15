using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace Шибениця_2._0
{
    partial class FormPage : Page
    {
        private DataBaseHangman dbHangman;
        public MainWindow mainWindow;

        public FormPage()
        {
            InitializeComponent();
            mainWindow = (MainWindow)Application.Current.MainWindow;
            dbHangman = new DataBaseHangman(mainWindow.Login);
            UsernameTextBlock.Text = "ІМ'Я КОРИСТУВАЧА: " + mainWindow.Login;
            UserBalanceTextBlock.Text = "БАЛАНС РИСОЧОК: " + dbHangman.UserManager.GetNumbOfDashes();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = LoginUsernameTextBox.Text;
            string password = LoginPasswordBox.Password;

            if (dbHangman.UserManager.ValidateLogin(username, password))
            {
                dbHangman.UserManager.UpdateLastLogInInfo(mainWindow.Login, false);
                mainWindow.Login = username;
                dbHangman.UserManager.UpdateLastLogInInfo(username, true);

                dbHangman = new DataBaseHangman(username);
                mainWindow.Login = dbHangman.UserManager.GetLastLogin();
                dbHangman.login = dbHangman.UserManager.GetLastLogin();
                UsernameTextBlock.Text = "ІМ'Я КОРИСТУВАЧА: " + mainWindow.Login;
                UserBalanceTextBlock.Text = "БАЛАНС РИСОЧОК: " + dbHangman.UserManager.GetNumbOfDashes();
            }
            else
            {
                MessageBoxCanvas.Visibility = Visibility.Visible;
                MessageBoxTextBlock.Text = "Неправильне ім'я користувача або пароль.";
            }
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string username = RegisterUsernameTextBox.Text;
            string password = RegisterPasswordBox.Password;
            string confirmPassword = RegisterConfirmPasswordBox.Password;

            if (password != confirmPassword)
            {
                MessageBoxCanvas.Visibility = Visibility.Visible;
                MessageBoxTextBlock.Text = "Паролі не збігаються";
                return;
            }

            if (dbHangman.UserManager.RegisterUser(username, password))
            {
                MessageBoxCanvas.Visibility = Visibility.Visible;
                MessageBoxTextBlock.Text = "Реєстрація пройшла успішно";
            }
            else
            {
                MessageBoxCanvas.Visibility = Visibility.Visible;
                MessageBoxTextBlock.Text = "Реєстрація не пройшла. Можливо таке ім'я користувача вже зайняте.";
            }
        }

        private void BackToMenuButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MainMenuPage());
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxCanvas.Visibility = Visibility.Collapsed;
        }
    }
}
