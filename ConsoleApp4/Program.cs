using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
    

        static void Main(string[] args)
        {

            Console.WriteLine("Welcome in Hangman game!!! Enjoy and good luck.");
            Console.WriteLine("You have six attempts to solve this mystery word");

            WordProcessing wordProcessing = new WordProcessing();

            PlayAgain:

            wordProcessing.BuildHangman();

            Console.WriteLine("Your game has ended if, you want to play again press \"Y\"on your keyboard.Otherwise thank you for playing.");
            
            string playAgain = Console.ReadLine();
            
            if (playAgain == "y")
            {
                goto PlayAgain;
            }
            
        }


    }
}