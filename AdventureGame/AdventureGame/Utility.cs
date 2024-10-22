using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AdventureGame
{
    public static class Utility
    {
        public static void MoveOn()
        {
            //WriteLine("");
            //WriteLine("Press any key to continue...");
            ReadKey();
            Clear();
        }

        public static void Choice()
        {
            WriteLine("");
            Utility.Spacing("Enter you choice: ");
        }

        public static void Spacing(string text)
        {
            // Logan ACT 
            int padding = (WindowWidth - text.Length) / 2; 

            WriteLine(new string(' ', padding) + text);
        }

        public static void TopSpaces()
        {
            WriteLine("");
            WriteLine("");
            WriteLine("");
        }
    }
}
