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
                char guessedLetter = GuessedLetter();

                lettersAlreadyGuessed += guessedLetter;



                for (int i = 0; i < wordToGuess.Length; i++)
                {
                    if (wordToGuess[i] == guessedLetter)
                    {
                        stringBuilder[i] = guessedLetter;
                        countingRightGuesses++;
                        Console.WriteLine(countingRightGuesses);

                    }
                    else if (!wordToGuess.Contains(guessedLetter))
                    {
                        countingWrongGuesses++;
                        Console.WriteLine("Times wrong:" + countingWrongGuesses);
                        Console.WriteLine(StickFigure.Hangman(countingWrongGuesses));

                        break;
                        //este doplnit hangmana
                    }

                }
                Console.WriteLine("Guessing in progress: " + stringBuilder.ToString());

                Console.WriteLine($"Letters already guessed:" + LettersUsed(lettersAlreadyGuessed));


            }
            while (countingWrongGuesses != 5 || countingRightGuesses == stringBuilder.Length);
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
                guessedLetter = Console.ReadLine();

                if (guessedLetter.Length > 1)
                {
                    Console.WriteLine("Please, write only one letter for guessing. Anything bigger than one letter will not be accepted");
                }


            } while (guessedLetter.Length > 1);

            guessedLetter = new string(guessedLetter.ToLower());

            return char.Parse(guessedLetter);
        }
    }
}
