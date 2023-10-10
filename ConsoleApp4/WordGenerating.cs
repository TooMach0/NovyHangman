using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class WordGenerating
    {

        public string WordGeneratingM()
        {
            string[] ArrayOfWords = new string[] { "lietadlo" };

            Random random = new Random();

            string wordToGuess = ArrayOfWords[random.Next(ArrayOfWords.Length)];

            return wordToGuess;
        }

    }
}
