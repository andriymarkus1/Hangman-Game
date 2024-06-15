using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace Шибениця_2._0
{
    partial class Shop : Page
    {
        private int UserBalance;
        DataBaseHangman database;
        ButtonManager buttonManager;
        MainWindow mainWindow;
        private int TreePrice;
        private int RoadSignPrice;
        private int PeasantPrice;
        private int OrcPrice;
        public Shop()
        {
            InitializeComponent();

            TreePrice = 150; TreePriceTextBlock.Text = "Ціна: " + TreePrice.ToString() + "(Р)";
            RoadSignPrice = 150; RoadSignPriceTextBlock.Text = "Ціна: " + RoadSignPrice.ToString() + "(Р)";
            PeasantPrice = 100; PeasantPriceTextBlock.Text = "Ціна: " + PeasantPrice.ToString() + "(Р)";
            OrcPrice = 200; OrcPriceTextBlock.Text = "Ціна: " + OrcPrice.ToString() + "(Р)";
            mainWindow = (MainWindow)Application.Current.MainWindow;
            database = new DataBaseHangman(mainWindow.Login);
            buttonManager = new ButtonManager();
            UserBalance = database.GameManager.GetNumbOfDashes();
            buttonManager.SetSetButtonIfBought(BuyGallows1Button, SetGallows1Button, database.ShopManager.IsGallow1Bought());
            buttonManager.SetSetButtonIfBought(BuyGallows2Button, SetGallows2Button, database.ShopManager.IsGallow2Bought());
            buttonManager.SetSetButtonIfBought(BuySkin1Button, SetSkin1Button, database.ShopManager.IsSkin1Bought());
            buttonManager.SetSetButtonIfBought(BuySkin2Button, SetSkin2Button, database.ShopManager.IsSkin2Bought());

            buttonManager.DisableEnableSetButtonsIfSet(SetGallows0Button, SetGallows1Button, SetGallows2Button, database.ShopManager.GetSetGallowNumb());
            buttonManager.DisableEnableSetButtonsIfSet(SetSkin0Button, SetSkin1Button, SetSkin2Button, database.ShopManager.GetSetSkinNumb());

            UpdateBalanceDisplay();
        }

        private void UpdateBalanceDisplay()
        {
            BalanceTextBlock.Text = UserBalance.ToString() + "(Р)";
        }

        private bool CanAfford(int price)
        {
            return UserBalance >= price;
        }

        private void BuyGallows1_Click(object sender, RoutedEventArgs e)
        {
            if (CanAfford(TreePrice))
            {
                UserBalance -= TreePrice;
                database.ShopManager.SetGallow1Bought();
                database.GameManager.UpdateUserDashesBalance(UserBalance);
                UpdateBalanceDisplay();
                buttonManager.BuyButtonToSetButton(BuyGallows1Button, SetGallows1Button);
            }
            else
            {
                MessageCanvas();
            }
        }
        private void BuyGallows2_Click(object sender, RoutedEventArgs e)
        {
            if (CanAfford(RoadSignPrice))
            {
                UserBalance -= RoadSignPrice;
                UpdateBalanceDisplay();
                database.ShopManager.SetGallow2Bought();
                database.GameManager.UpdateUserDashesBalance(UserBalance);
                buttonManager.BuyButtonToSetButton(BuyGallows2Button, SetGallows2Button);
            }
            else
            {
                MessageCanvas();
            }
        }
        private void BuySkin1_Click(object sender, RoutedEventArgs e)
        {
            if (CanAfford(PeasantPrice))
            {
                buttonManager.BuyButtonToSetButton(BuySkin1Button, SetSkin1Button);
                UserBalance -= PeasantPrice;
                UpdateBalanceDisplay();
                database.ShopManager.SetSkin1Bought();
                database.GameManager.UpdateUserDashesBalance(UserBalance);
            }
            else
            {
                MessageCanvas();
            }
        }
        private void BuySkin2_Click(object sender, RoutedEventArgs e)
        {
            if (CanAfford(OrcPrice))
            {
                UserBalance -= OrcPrice;
                UpdateBalanceDisplay();
                database.ShopManager.SetSkin2Bought();
                database.ShopManager.UpdateUserDashesBalance(UserBalance);
                buttonManager.BuyButtonToSetButton(BuySkin2Button, SetSkin2Button);
            }
            else
            {
                MessageCanvas();
            }
        }
        private void MessageCanvas()
        {
            MessageBoxCanvas.Visibility = Visibility.Visible;
            MessageBoxTextBlock.Text = "Недостатньо балансу для покупки!";
        }
        private void SetGallow0_Click(object sender, RoutedEventArgs e)
        {
            database.ShopManager.SetSetGallowNumb(0);
            buttonManager.DisableEnableSetButtons(SetGallows0Button, SetGallows1Button, SetGallows2Button);
        }
        private void SetGallow1_Click(object sender, RoutedEventArgs e)
        {
            database.ShopManager.SetSetGallowNumb(1);
            buttonManager.DisableEnableSetButtons(SetGallows1Button, SetGallows0Button, SetGallows2Button);
        }
        private void SetGallow2_Click(object sender, RoutedEventArgs e)
        {
            database.ShopManager.SetSetGallowNumb(2);
            buttonManager.DisableEnableSetButtons(SetGallows2Button, SetGallows1Button, SetGallows0Button);
        }
        private void SetSkin0_Click(object sender, RoutedEventArgs e)
        {
            database.ShopManager.SetSetSkinNumb(0);
            buttonManager.DisableEnableSetButtons(SetSkin0Button, SetSkin1Button, SetSkin2Button);
        }
        private void SetSkin1_Click(object sender, RoutedEventArgs e)
        {
            database.ShopManager.SetSetSkinNumb(1);
            buttonManager.DisableEnableSetButtons(SetSkin1Button, SetSkin0Button, SetSkin2Button);
        }
        private void SetSkin2_Click(object sender, RoutedEventArgs e)
        {
            database.ShopManager.SetSetSkinNumb(2);
            buttonManager.DisableEnableSetButtons(SetSkin2Button, SetSkin0Button, SetSkin1Button);
        }
        private void BackToMenuButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MainMenuPage());
        }
        private void CustomScrollViewer_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (CustomScrollViewer.ScrollableWidth > 0)
            {
                double newOffset = CustomScrollViewer.HorizontalOffset - e.Delta;
                if (newOffset < 0)
                {
                    CustomScrollViewer.ScrollToHorizontalOffset(0);
                }
                else if (newOffset > CustomScrollViewer.ScrollableWidth)
                {
                    CustomScrollViewer.ScrollToHorizontalOffset(CustomScrollViewer.ScrollableWidth);
                }
                else
                {
                    CustomScrollViewer.ScrollToHorizontalOffset(newOffset);
                }
                e.Handled = true;
            }
        }
        private void CustomScrollViewer1_PreviewMouseWheel(object sender, MouseWheelEventArgs e)
        {
            if (CustomScrollViewer1.ScrollableWidth > 0)
            {
                double newOffset = CustomScrollViewer1.HorizontalOffset - e.Delta;

                if (newOffset < 0)
                {
                    CustomScrollViewer1.ScrollToHorizontalOffset(0);
                }
                else if (newOffset > CustomScrollViewer1.ScrollableWidth)
                {
                    CustomScrollViewer1.ScrollToHorizontalOffset(CustomScrollViewer1.ScrollableWidth);
                }
                else
                {
                    CustomScrollViewer1.ScrollToHorizontalOffset(newOffset);
                }
                e.Handled = true;
            }
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxCanvas.Visibility = Visibility.Collapsed;
        }
    }
}

