using System;
using System.Windows;
using System.Windows.Controls;

namespace Шибениця_2._0
{
    class ButtonManager
    {
        private Grid KeyGrid;

        public ButtonManager(Grid keyGrid)
        {
            KeyGrid = keyGrid;
        }
        public ButtonManager() { }

        public void EnableButtons()
        {
            Style keyboardWrongtButtonStyle = (Style)Application.Current.Resources["KeyboardWrongButtonStyle"];
            foreach (var child in KeyGrid.Children)
            {
                if (child is Button button)
                {
                    button.Style = keyboardWrongtButtonStyle;
                    button.IsEnabled = true;
                }
            }
        }

        public void DisableButtonWithLetter(char letter)
        {
            Button button = FindButtonByLetter(letter);
            if (button != null)
            {
                button.IsEnabled = false;
            }
        }

        public Button FindButtonByLetter(char letter)
        {
            foreach (var child in KeyGrid.Children)
            {
                if (child is Button button && button.Content.ToString().Equals(letter.ToString(), StringComparison.OrdinalIgnoreCase))
                {
                    return button;
                }
            }
            return null;
        }

        public void SetSetButtonIfBought(Button BuyButton, Button SetButton, bool IsBought)
        {
            if (IsBought)
                BuyButtonToSetButton(BuyButton, SetButton);
        }
        public void BuyButtonToSetButton(Button BuyButton, Button SetButton)
        {
            BuyButton.Visibility = Visibility.Collapsed;
            SetButton.Visibility = Visibility.Visible;
        }

        public void DisableEnableSetButtons(Button SetButton0, Button SetButton1, Button SetButton2)
        {
            SetButton0.IsEnabled = false;
            SetButton1.IsEnabled = true;
            SetButton2.IsEnabled = true;
        }
        public void DisableEnableSetButtonsIfSet(Button SetButton0, Button SetButton1, Button SetButton2, int n)
        {
            switch (n)
            {
                case 0:
                    SetButton0.IsEnabled = false;
                    SetButton1.IsEnabled = true;
                    SetButton2.IsEnabled = true;
                    break;
                case 1:
                    SetButton0.IsEnabled = true;
                    SetButton1.IsEnabled = false;
                    SetButton2.IsEnabled = true;
                    break;
                case 2:
                    SetButton0.IsEnabled = true;
                    SetButton1.IsEnabled = true;
                    SetButton2.IsEnabled = false;
                    break;
                default:; break;
            }
        }
    }
}

