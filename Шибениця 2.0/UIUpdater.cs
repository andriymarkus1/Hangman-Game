using System.Windows.Controls;
using System.Windows.Input;

namespace Шибениця_2._0
{
    class UIUpdater
    {
        private TextBlock displayWordTextBlock;
        private TextBlock attemptsTextBlock;
        DrawElements drawElements;
        public UIUpdater(TextBlock displayWordTextBlock, TextBlock attemptsTextBlock, DrawElements drawElements)
        {
            this.displayWordTextBlock = displayWordTextBlock;
            this.attemptsTextBlock = attemptsTextBlock;
            this.drawElements = drawElements;
        }
        public UIUpdater()
        {
        }
        public void UpdateDisplay(string displayWord, int attempts, Image Hangman)
        {
            displayWordTextBlock.Text = displayWord;
            attemptsTextBlock.Text = $"Спроби: {attempts}";
            Hangman.Source = drawElements.DrawHangman(attempts);
        }
        public void AllSpentTime(TextBlock timeTextBlock, string strTime)
        {
            timeTextBlock.Text = strTime;
        }
    }
}
