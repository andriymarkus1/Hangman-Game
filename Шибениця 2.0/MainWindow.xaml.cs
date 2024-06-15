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
    partial class MainWindow : Window
    {
        public string Login { get; set; }
        private DataBaseHangman DataBaseHangman { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            DataBaseHangman = new DataBaseHangman("");
            Login = DataBaseHangman.UserManager.GetLastLogin();
            DataBaseHangman.login = DataBaseHangman.UserManager.GetLastLogin();
            MainFrame.Navigate(new MainMenuPage());
        }
        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
