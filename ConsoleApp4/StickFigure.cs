using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class StickFigure
    {

        public static int Hangman(int WrongLetter)
        {
            if (WrongLetter == 1)
            {
                Console.WriteLine("========");

            }
            else if (WrongLetter == 2)
            {
                Console.WriteLine("      || ");
                Console.WriteLine("      || ");
                Console.WriteLine("      || ");
                Console.WriteLine("      || ");
                Console.WriteLine("      || ");
                Console.WriteLine("      || ");
                Console.WriteLine("========");
            }
            else if (WrongLetter == 3)
            {
                Console.WriteLine("+=====+");
                Console.WriteLine("      || ");
                Console.WriteLine("      || ");
                Console.WriteLine("      || ");
                Console.WriteLine("      || ");
                Console.WriteLine("      || ");
                Console.WriteLine("      || ");
                Console.WriteLine("========");
            }
            return WrongLetter;
        }

    }
}
