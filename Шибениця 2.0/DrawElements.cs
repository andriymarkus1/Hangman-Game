using System;
using System.Drawing;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Шибениця_2._0
{
    class DrawElements
    {
        private DataBaseHangman DataBase { get; set; }
        private string pathFormat { get; set; }
        public DrawElements(DataBaseHangman dataBase)
        {
            DataBase = dataBase;
        }
        public BitmapImage DrawHangman(int attempts)
        {
            int n = DataBase.ShopManager.GetSetSkinNumb();
            switch (n)
            {
                case 0: pathFormat = "\\Visual\\Game_Page\\Hangmans\\Default_Hangman\\{0}.png"; break;
                case 1: pathFormat = "\\Visual\\Game_Page\\Hangmans\\Peasant\\{0}.png"; break;
                case 2: pathFormat = "\\Visual\\Game_Page\\Hangmans\\Orc\\{0}.png"; break;
                default: pathFormat = "\\Visual\\Game_Page\\Hangmans\\Default_Hangman\\{0}.png"; break;
            }
            BitmapImage bitmapImage = new BitmapImage();

            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(string.Format(pathFormat, attempts), UriKind.RelativeOrAbsolute);
            bitmapImage.EndInit();

            return bitmapImage;
        }
        public BitmapImage Gallow()
        {
            int n = DataBase.ShopManager.GetSetGallowNumb();
            switch (n)
            {
                case 0: pathFormat = "\\Visual\\Game_Page\\Gallows\\Default_Gallow.png"; break;
                case 1: pathFormat = "\\Visual\\Game_Page\\Gallows\\Tree.png"; break;
                case 2: pathFormat = "\\Visual\\Game_Page\\Gallows\\Road_Sign.png"; break;
                default: pathFormat = "\\Visual\\Game_Page\\Gallows\\Default_Gallow.png"; break;
            }
            BitmapImage bitmapImage = new BitmapImage();

            bitmapImage.BeginInit();
            bitmapImage.UriSource = new Uri(string.Format(pathFormat), UriKind.RelativeOrAbsolute);
            bitmapImage.EndInit();

            return bitmapImage;
        }
    }
}