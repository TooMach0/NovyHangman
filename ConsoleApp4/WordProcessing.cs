using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp
{
    internal class WordProcessing
    {

        public void BuildHangman()
        {

            WordGenerating wordGenerating = new WordGenerating();
            string wordToGuess = wordGenerating.WordGeneratingM();
            string wordInAsterixes = ReplaceWordWithAsterisks(wordToGuess);
            StringBuilder stringBuilder = new StringBuilder(wordInAsterixes);

            string lettersAlreadyGuessed = string.Empty;
            int countingWrongGuesses = 0;
            int countingRightGuesses = 0;


            do
            {
                usedSameLetter:

                char guessedLetter = GuessedLetter();

                if (lettersAlreadyGuessed.Contains(guessedLetter))
                {
                    Console.WriteLine("\n You already used this letter, try again.");
                    goto usedSameLetter;
                }

                lettersAlreadyGuessed += guessedLetter;

               
                for (int i = 0; i < wordToGuess.Length; i++)
                {
                    if (wordToGuess[i] == guessedLetter)
                    {
                        stringBuilder[i] = guessedLetter;
                        countingRightGuesses++;
                        

                    }
                    else if (!wordToGuess.Contains(guessedLetter))
                    {
                        countingWrongGuesses++;
                        Console.WriteLine("Times wrong:" + countingWrongGuesses);
                        StickFigure.Hangman(countingWrongGuesses);

                        break;
                        
                    }

                }
                Console.WriteLine("\nGuessing in progress: " + stringBuilder.ToString());

                Console.WriteLine($"\nLetters already guessed:" + LettersUsed(lettersAlreadyGuessed));


            }
            while (countingWrongGuesses < 6 && countingRightGuesses < stringBuilder.Length);

            WinLossDetermination(countingWrongGuesses, countingRightGuesses, wordToGuess);
        }

        public void WinLossDetermination(int countingWrongGuesses, int countingRightGuesses, string wordToGuess)
        {
            if (countingWrongGuesses == 6)
            {
                Console.WriteLine("I am sorry you will be hanged");
            }
            else if(countingRightGuesses == wordToGuess.Length )
            {
                Console.WriteLine("Congratulations, you will not be hanged, this time!!!");
            }
        }


        public string ReplaceWordWithAsterisks(string wordToGuess)
        {
            string asterikses = string.Empty;

            foreach (char c in wordToGuess)
            {
                asterikses += "*";
            }

            return asterikses;
        }

        public string LettersUsed(string lettersAlreadyGuessed)
        {

            List<char> letters = new List<char>(lettersAlreadyGuessed);

            string comma = string.Join(",", letters);

            return comma;

        }
        public char GuessedLetter()
        {
            string guessedLetter = string.Empty;
            do
            {
                Console.Write("\nPlease, write letter you think is correct: ");

                guessedLetter = Console.ReadLine();

                if (guessedLetter.Length > 1 || guessedLetter.Length == 0)
                {
                    Console.WriteLine("\nPlease, write only one letter for guessing. Anything bigger or lower than one letter will not be accepted");
                }


            } while (guessedLetter.Length > 1 || guessedLetter.Length == 0) ;

            guessedLetter = new string(guessedLetter.ToLower());

            return char.Parse(guessedLetter);
        }
    }
}
