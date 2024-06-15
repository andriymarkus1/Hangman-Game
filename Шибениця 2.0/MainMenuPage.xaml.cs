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

namespace Шибениця_2._0
{
    partial class MainMenuPage : Page
    {
        public MainMenuPage()
        {
            InitializeComponent();
        }
        private void NewGameButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new DifficultySelectionMenu());
        }
        private void LoadGameButton_Click(object sender, RoutedEventArgs e)
        {
        }
        private void SettingsButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Відкрити налаштування!");
        }
        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void ShopButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Shop());
        }

        private void FormButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new FormPage());
        }
    }
}
