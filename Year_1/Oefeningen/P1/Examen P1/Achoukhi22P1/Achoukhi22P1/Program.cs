using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achoukhi22P1
{
    internal class Program
    {
        //This is the exam by Ayoub Achoukhi.
        static void Main(string[] args)
        {
            //Deel 1: NameMashup
            //1.
            string fullName;
            Console.Write("Voer je naam in als volgt: Naam*Voornaam: ");
            fullName = Console.ReadLine().ToLower().TrimEnd();

            Console.WriteLine();
            //2&3.

            string firstName = fullName.Substring(fullName.IndexOf("*") + 1);
            string lastName = fullName.Substring(0, fullName.IndexOf("*"));

            Console.WriteLine("First name: " + firstName);
            Console.WriteLine("Name: " + lastName);
            Console.WriteLine();

            //4.
            char firstFirst = firstName.ElementAt(0);
            char lastLast = lastName.ElementAt(lastName.Length - 1);

            Console.WriteLine("firstFirst: " + firstFirst);
            Console.WriteLine("lastLast: " + lastLast);

            //5.
            firstName = firstName.Replace(firstFirst, '*');
            lastName = lastName.Replace(lastLast, '*');
            Console.WriteLine(firstName + "-" + lastName);
            Console.WriteLine();


            //Deel 2: NumberChecker


            double number;
            bool parseSucceeded;
            bool numberRight;
            
            do
            {
                Console.Write("Voer een kommagetal, groter dan 1 en kleiner of gelijk aan 5, in: ");
                parseSucceeded = double.TryParse(Console.ReadLine(), out number);
                if (parseSucceeded && number>1 && number<=5)
                {
                    numberRight = true;
                }
                else
                {
                    numberRight=false;
                }

            }
            while (!numberRight);

            int rounded = Convert.ToInt32(number);
            Console.WriteLine();


            switch (rounded)
            {
                case 1:
                    Console.WriteLine("Het resultaat: 1 is geen");
                    break;
                case 2:
                    
                    Console.WriteLine("Het resultaat van 2 tot de 2e macht is "+ Math.Pow(2, 2));
                    break;
                case 3:
                    while (rounded >= 0)
                    {
                        Console.WriteLine("Hello World "+ rounded);
                        rounded--;
                    }

                    break;
                case 4:
                    if (number>rounded)
                    {
                        Console.WriteLine("GROTER");
                    }
                    else
                    {
                        Console.WriteLine("KLEINER");
                    }

                    break;
                case 5:
                    int row = 0;
                    int col = 0;
                    int i = 0;
                    while (row<5)
                    {
                        while (col<6)
                        {
                            if (i>=col)
                            {
                                Console.Write("*");
                            }
                            else
                            {
                                Console.Write(row);
                            }
                            col++;
                        }
                        col = 0;
                        Console.WriteLine();
                        row++;
                        i++;

                    }
                    break;
                    default:
                    Console.WriteLine("Hier is iets vreemds aan de gang");
                    break;


            }


            Console.WriteLine("Druk op een knop om af te sluiten.");
            Console.ReadKey();
        }
    }
}
