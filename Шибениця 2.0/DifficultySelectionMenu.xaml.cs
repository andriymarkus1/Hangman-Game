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
    /// <summary>
    /// Interaction logic for DifficultySelectionMenu.xaml
    /// </summary>
    partial class DifficultySelectionMenu : Page
    {
        public DifficultySelectionMenu()
        {
            InitializeComponent();
            MidRadio.IsChecked = true;
        }

        private void NewGameButton_Click(object sender, RoutedEventArgs e)
        {

            if (EasyRadio.IsChecked == true)
                DifficultyLevel.difficulty = 0;
            if (HighRadio.IsChecked == true)
                DifficultyLevel.difficulty = 2;
            if (MidRadio.IsChecked == true)
                DifficultyLevel.difficulty = 1;

            this.NavigationService.Navigate(new GamePage());
        }

        private void BackToMenuButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MainMenuPage());
        }

        private void CloseAppButton_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void MidRadio_Checked(object sender, RoutedEventArgs e)
        {
            DName.Text = "СЕРЕДНІЙ:";
            DName.Foreground = new SolidColorBrush(Color.FromRgb(4, 0, 130));
            DText.Text = "- ВІДКРИТА ПЕРША І ОСТАННЯ ЛІТЕРИ - 7-10 ЛІТЕР У СЛОВІ";
        }

        private void EasyRadio_Checked(object sender, RoutedEventArgs e)
        {
            DName.Text = "ЛЕГКИЙ:";
            DName.Foreground = new SolidColorBrush(Color.FromRgb(111, 111, 111));
            DText.Text = "- ВІДКРИТА ПЕРША І ОСТАННЯ ЛІТЕРИ - 5-6 ЛІТЕР У СЛОВІ";
        }

        private void HighRadio_Checked(object sender, RoutedEventArgs e)
        {
            DName.Text = "НАЙВИЩИЙ:";
            DName.Foreground = new SolidColorBrush(Color.FromRgb(155, 20, 9));
            DText.Text = "- ВСІ ЛІТЕРИ ЗАКРИТІ               - 11-13 ЛІТЕР У СЛОВІ";
        }
    }
}
