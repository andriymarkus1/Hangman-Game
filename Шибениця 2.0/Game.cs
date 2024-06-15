using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Шибениця_2._0
{
    class Game
    {
        public string Word { get; set; }
        public string DisplayWord { get; set; }
        public int Attempts { get; set; }
        private ButtonManager ButtonManager { get; set; }
        public List<char> GuessedLetters { get; set; }

        public Game(string word, ButtonManager buttonManager)
        {
            Word = word.ToUpper();
            DisplayWord = new string('_', word.Length);
            Attempts = 0;
            GuessedLetters = new List<char>();
            ButtonManager = buttonManager;
        }

        public void RevealFirstAndLastLetters()
        {
            if (DifficultyLevel.difficulty != 2)
            {

                char[] displayWordArray = DisplayWord.ToCharArray();

                if (Word.Length > 0)
                {
                    char firstLetter = Word[0];
                    displayWordArray[0] = firstLetter;

                    for (int i = 1; i < Word.Length; i++)
                        if (Word[i] == firstLetter)
                            displayWordArray[i] = firstLetter;

                    GuessedLetters.Add(firstLetter);
                    Button firstButton = ButtonManager.FindButtonByLetter(firstLetter);
                    if (firstButton != null)
                    {
                        firstButton.Style = (Style)Application.Current.Resources["KeyboardCorrectButtonStyle"];
                        ButtonManager.DisableButtonWithLetter(firstLetter);
                    }
                }

                if (Word.Length > 1 && Word[Word.Length - 1] != Word[0])
                {
                    char lastLetter = Word[Word.Length - 1];
                    displayWordArray[Word.Length - 1] = lastLetter;

                    for (int i = 1; i < Word.Length - 1; i++)
                        if (Word[i] == lastLetter)
                            displayWordArray[i] = lastLetter;

                    GuessedLetters.Add(lastLetter);
                    Button lastButton = ButtonManager.FindButtonByLetter(lastLetter);
                    if (lastButton != null)
                    {
                        lastButton.Style = (Style)Application.Current.Resources["KeyboardCorrectButtonStyle"];
                        ButtonManager.DisableButtonWithLetter(lastLetter);
                    }
                }

                DisplayWord = new string(displayWordArray);
            }
        }

        public bool Guess(char letter)
        {
            letter = Char.ToUpper(letter);
            if (GuessedLetters.Contains(letter))
                return false;

            Button button = ButtonManager.FindButtonByLetter(letter);
            Style keyboardCorrectButtonStyle = (Style)Application.Current.Resources["KeyboardCorrectButtonStyle"];

            GuessedLetters.Add(letter);
            bool correctGuess = false;
            char[] displayWordArray = DisplayWord.ToCharArray();
            for (int i = 0; i < Word.Length; i++)
            {
                if (Word[i] == letter)
                {
                    displayWordArray[i] = letter;
                    button.Style = keyboardCorrectButtonStyle;
                    correctGuess = true;
                }
            }
            DisplayWord = new string(displayWordArray);

            if (!correctGuess)
            {
                Attempts++;
                correctGuess = true;
            }
            return correctGuess;
        }

        public bool IsWin()
        {
            return DisplayWord.Equals(Word);
        }

        public bool IsLose()
        {
            return Attempts >= 6;
        }
        public char UseHint()
        {
            Random random = new Random();
            char hintLetter;

            List<char> availableLetters = new List<char>();
            foreach (char letter in Word)
            {
                if (!GuessedLetters.Contains(letter))
                {
                    availableLetters.Add(letter);
                }
            }
            int randomIndex = random.Next(0, availableLetters.Count);
            hintLetter = availableLetters[randomIndex];
            return hintLetter;
        }

    }
}
