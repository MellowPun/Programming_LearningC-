using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Character_Excercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double result;


            //OEF EXTRA
            char currentChar;
            string userInput;
            int amountToShift;
            int charAsNumber;


            // ask the user for a name
            Console.Write("Please enter a name: ");
            userInput = Console.ReadLine();

            // ask the user how many characters to shift
            Console.Write("How many characters would you like to shift?");
            int.TryParse(Console.ReadLine(), out amountToShift);

            currentChar = userInput.ElementAt(0);
            charAsNumber = (int)currentChar;
            charAsNumber += amountToShift;
            Console.WriteLine((char)charAsNumber);

            currentChar = userInput.ElementAt(1);
            charAsNumber = (int)currentChar;
            charAsNumber += amountToShift;
            Console.WriteLine((char)charAsNumber);

            currentChar = userInput.ElementAt(2);
            charAsNumber = (int)currentChar;
            charAsNumber += amountToShift;
            Console.WriteLine((char)charAsNumber);

            currentChar = userInput.ElementAt(3);
            charAsNumber = (int)currentChar;
            charAsNumber += amountToShift;
            Console.WriteLine((char)charAsNumber);

            currentChar = userInput.ElementAt(4);
            charAsNumber = (int)currentChar;
            charAsNumber += amountToShift;
            Console.WriteLine((char)charAsNumber);

            // Take the first character of the entered name
            /* You can put in the ElementAt space a number from 0 to infinity or
             * For dynamic use put variable.Length -1) */
            currentChar = userInput.ElementAt(userInput.Length - 1);
            // Show the first character as a number
            Console.WriteLine((int)currentChar);

            Console.WriteLine("\n Press any key to quit");
            Console.ReadKey();
        }
    }
}
