using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examenproef_Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConsoleKey input;
            do
            {
                Console.WriteLine("Press C to create instances\npress S to save\nPress L to Load\n Press Q to Quit");
                input = Console.ReadKey().Key;
                switch(input)
                {
                    case ConsoleKey.C:
                        Console.WriteLine("C pressed");
                        break;

                    case ConsoleKey.S:
                        Console.WriteLine("S pressed");

                        break;

                    case ConsoleKey.L:
                        Console.WriteLine("L pressed");

                        break;
                    default:
                        Console.WriteLine("Unrecognized input");
                        break;  

                }
            }
            while (input != ConsoleKey.Q);


            
        }
    }
}
