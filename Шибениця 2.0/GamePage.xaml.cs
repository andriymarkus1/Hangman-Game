using System;
using System.Data.Entity;
using System.Diagnostics.Metrics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Threading;

namespace Шибениця_2._0
{
    partial class GamePage : Page
    {

        MainWindow mainWindow;
        DrawElements drawElements;
        private int OpenLetterPrice;
        private int UserBalance;
        private Game game;
        DataBaseHangman database;
        private ButtonManager buttonManager;
        private UIUpdater uiUpdater;
        private DispatcherTimer timer;
        private DateTime startTime;
        private TimeSpan elapsed;

        public GamePage()
        {
            InitializeComponent();

            mainWindow = (MainWindow)Application.Current.MainWindow;
            database = new DataBaseHangman(mainWindow.Login);
            drawElements = new DrawElements(database);
            GallowImage.Source = drawElements.Gallow();
            UserBalance = database.GameManager.GetNumbOfDashes();
            DashesTextBlock.Text = UserBalance.ToString() + " (P)";
            buttonManager = new ButtonManager(KeyGrid);
            uiUpdater = new UIUpdater(DisplayWordTextBlock, AttemptsTextBlock, drawElements);
            StartNewGame();
            this.Focus();
        }
        private void StartNewGame()
        {
            HintTextBlock.Visibility = Visibility.Collapsed;
            EndGrid.Visibility = Visibility.Collapsed;
            buttonManager.EnableButtons();
            OpenLetterPrice = 15;
            OpenLetterHintPriceTextBlock.Text = "> " + OpenLetterPrice.ToString() + "(P)";
            TopicHintCanvas.Visibility = Visibility.Visible;
            var wordInfo = database.GameManager.GetRandomWord();
            string word = wordInfo.word;
            string topic = wordInfo.topic;
            StartTimer();
            HintCanvas.Visibility = Visibility.Collapsed;
            HintTextBlock.Text = topic;
            game = new Game(word, buttonManager);
            game.RevealFirstAndLastLetters();
            HintButton.IsEnabled = true;
            UpdateDisplay();
        }

        private void StartTimer()
        {
            startTime = DateTime.Now;
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            elapsed = DateTime.Now - startTime;
            TimerTextBlock.Text = elapsed.ToString(@"mm\:ss");
        }

        private void UpdateDisplay()
        {
            uiUpdater.UpdateDisplay(game.DisplayWord, game.Attempts, HangmanImage);
        }

        private void Window_TextInput(object sender, TextCompositionEventArgs e)
        {
            char letter = e.Text.ToUpper()[0];

            if ((letter >= 'А' && letter <= 'Я') || letter == 'Є' || letter == 'Ї' || letter == 'І' || letter == 'Э' || letter == 'Ы' || letter == '1')
            {
                switch (letter)
                {
                    case 'Ы': letter = 'І'; break;
                    case 'Э': letter = 'Є'; break;
                    case 'Ъ': letter = 'Ї'; break;
                    case '1': letter = 'Ґ'; break;
                    default: break;
                }

                buttonManager.DisableButtonWithLetter(letter);
                ProcessGuess(letter);
            }
        }

        private void ProcessGuess(char letter)
        {
            if (game.Guess(letter))
            {
                UpdateDisplay();

                if (game.IsWin())
                {
                    timer.Stop();
                    int DashesEarned = (game.Word.Length * 5 / (int)elapsed.TotalSeconds) * 2 + game.Word.Length;
                    UserBalance += DashesEarned;
                    database.GameManager.UpdateUserDashesBalance(database.GameManager.GetNumbOfDashes() + DashesEarned);
                    EndGrid.Visibility = Visibility.Visible;
                    EndGameResultTextBlock.Foreground = new SolidColorBrush(Color.FromRgb(23, 130, 8));
                    EndGameResultTextBlock.Text = "ВИ ВИГРАЛИ!";
                    EndTimerTextBlock.Text = "ВИТРАЧЕНО ЧАСУ: " + elapsed.ToString(@"mm\:ss");
                    EndGameResultDashesTextBlock.Text = $"ЗАРОБЛЕНО РИСОЧОК: {DashesEarned}";
                    HintButton.IsEnabled = false;
                    DashesTextBlock.Text = UserBalance.ToString() + " (P)";
                }
                else if (game.IsLose())
                {
                    timer.Stop();
                    EndGrid.Visibility = Visibility.Visible;
                    EndTimerTextBlock.Text = "ВИТРАЧЕНО ЧАСУ: " + elapsed.ToString(@"mm\:ss");
                    EndGameResultTextBlock.Foreground = new SolidColorBrush(Color.FromRgb(150, 7, 7));
                    EndGameResultTextBlock.Text = "ВИ ПРОГРАЛИ(";
                    EndGameResultDashesTextBlock.Text = $"ЗАРОБЛЕНО РИСОЧОК: 0";
                    HintButton.IsEnabled = false;
                }
            }
        }
        private void LetterButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            char letter = button.Content.ToString()[0];

            button.IsEnabled = false;
            ProcessGuess(letter);

        }

        private void BackToMenuButton_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new MainMenuPage());
        }

        private void RestartButton_Click(object sender, RoutedEventArgs e)
        {
            StartNewGame();
        }

        private void HintButton_Click(object sender, RoutedEventArgs e)
        {
            HintCanvas.Visibility = Visibility.Visible;
        }

        private void OpenTopicButton_Click(object sender, RoutedEventArgs e)
        {
            int OpenTopicPrice = 20;
            if (UserBalance >= OpenTopicPrice)
            {
                UserBalance -= OpenTopicPrice;
                DashesTextBlock.Text = UserBalance.ToString() + " (P)";
                database.GameManager.UpdateUserDashesBalance(UserBalance);
                HintTextBlock.Visibility = Visibility.Visible;
                TopicHintCanvas.Visibility = Visibility.Collapsed;
                HintCanvas.Visibility = Visibility.Collapsed;
            }
            else
            {
                MessageCanvas();
            }
        }

        private void CloseHintButton_Click(object sender, RoutedEventArgs e)
        {
            HintCanvas.Visibility = Visibility.Collapsed;
        }

        private void OpenLetterButton_Click(object sender, RoutedEventArgs e)
        {
            if (UserBalance >= OpenLetterPrice)
            {
                char letter = game.UseHint();
                UserBalance -= OpenLetterPrice;
                OpenLetterPrice += 5;
                OpenLetterHintPriceTextBlock.Text = "> " + OpenLetterPrice.ToString() + "(P)";
                DashesTextBlock.Text = UserBalance.ToString() + " (P)";
                database.GameManager.UpdateUserDashesBalance(UserBalance);
                ProcessGuess(letter);
                buttonManager.DisableButtonWithLetter(letter);
                HintCanvas.Visibility = Visibility.Collapsed;
            }
            else
            {
                MessageCanvas();
            }
        }

        private void OkButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxCanvas.Visibility = Visibility.Collapsed;
        }
        private void MessageCanvas()
        {
            MessageBoxCanvas.Visibility = Visibility.Visible;
            MessageBoxTextBlock.Text = "Недостатньо балансу для покупки!";
        }
    }
}
