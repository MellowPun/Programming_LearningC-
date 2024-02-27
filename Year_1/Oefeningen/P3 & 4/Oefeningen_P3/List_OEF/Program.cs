using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace List_OEF
{
    internal class Program
    {

        internal enum CardinalDirection
        {
            North,
            East,
            South,
            West,
            Wrong,
        }
        //internal betekent enkel in dit project mogelijk te maken
        //als public maken betekent dat het in andere project gebruikt worden
        internal enum Language
        {
            Dutch,
            French,
            English,
        }

        internal enum RainbowColors
        {
            Red= 1,
            Orange=2,
            Yellow=3,
            Green=4,
            Blue=5,
            Indigo=6,
            Violet=7,
        }
        static void Main(string[] args)
        {
            ////OEF 14
            //Random rnd = new Random();
            //CardinalDirection cardinal = CardinalDirection.Wrong;
            //string input;

            //do
            //{

            //    Console.WriteLine("Want to play a game?");
            //    input = Console.ReadLine().ToLower();

            //    int random = rnd.Next(0, 361);
            //        if (random > 315 || random <= 45)
            //        {
            //            cardinal = CardinalDirection.North;
            //        }
            //        if (random > 45 && random <= 135)
            //        {
            //            cardinal = CardinalDirection.East;
            //        }
            //        if (random > 135 && random <= 225)
            //        {
            //            cardinal = CardinalDirection.South;
            //        }
            //        if (random > 225 && random <= 315)
            //        {
            //            cardinal = CardinalDirection.West;
            //        }




            //    Console.WriteLine("The number is {0} en The cardinal direction is {1}",random, cardinal.ToString());


            //} while (input != "stop");


            ////OEF 18

            //Random rnd = new Random();

            //int randomLanguage = rnd.Next(0, 3);

            //switch(randomLanguage)
            //{
            //    case 0:

            //        Console.WriteLine(randomLanguage + "Goededag");
            //        break;
            //        case 1:

            //        Console.WriteLine(randomLanguage + "Bonjour");
            //        break; 
            //    case 2:
            //        Console.WriteLine(randomLanguage + "Hello");
            //        break;

            //}
            //Console.ReadKey();


            //Console.WriteLine((Language)0);
            //Console.WriteLine((int)Language.Dutch);
            //Enum.TryParse("Dutch", out Language result);


            //OEF 19
            
            Console.WriteLine("Give me a colour!");
            string colourInput = Console.ReadLine();
            bool parseSucceeded = Enum.TryParse(colourInput, out RainbowColors colour);
            if (parseSucceeded)
            {
                Console.WriteLine("This colour is the " +(int)colour +" on the rainbow.");
            }
            else
            {
                Console.WriteLine("This is not a colour on the rainbow");
            }    
            Console.ReadKey();


           

        }
    }
}
