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

            WordProcessing wordProcessing = new WordProcessing();

            wordProcessing.BuildHangman();
        }


    }
}