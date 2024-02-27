using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //oef
            //int counter = 0, maxValue = 100;


            //while(counter < maxValue)
            //{
            //    Console.WriteLine("The current counter value is: "+ counter);
            //    counter +=5;
            //}

            //oef
            //int number;
            //bool parseSucceeded;

            //do
            //{
            //    Console.WriteLine("Enter a number: ");
            //    parseSucceeded = int.TryParse(Console.ReadLine(), out number);
            //}


            //while (!parseSucceeded);


            //bool keepResumingNumber = true;
            //while (keepResumingNumber)
            //{
            //    Console.WriteLine("Press S to save, L to load, Q to quit.");
            //    string input = Console.ReadLine().ToUpper();

            //    switch (input)
            //    {
            //        case "S":
            //            break;
            //        case "L":
            //            break;
            //        case "Q":
            //            break;


            //    }
            //}

            ////Oef 1
            //int number =0 ;


            //while (number < 101)
            //{
            //    Console.WriteLine("the number is {0}",number);
            //    number += 2;
            //}

            //oef3 EXAMEN

            //int i = 0, j;

            //int counter = 1;
            //while (i < 7)
            //{

            //    j = 0;
            //    while (j < 70)
            //    {
            //        Console.WriteLine("ik vergeef de ander zijn schuld.{0}", counter);
            //        j++;
            //        counter++;
            //    }

            //    i++;
            //}

            //oef LES 
            int i = 0;
            int j = 0;
            int enters = 5;
            int lettersNextToEachOther = 10;
            //char sign = 'O'; DIT IS VOOR CHARACTERS MOGEN DE AANHALIGNSTEKENS MAAR 1 ZIJN NIET DUBBEL
            string letter = "O";
            while (j < enters)
            {


                while (i < lettersNextToEachOther)
                {
                    Console.Write(letter);
                    i++;
                }
                j++;
                i = 0;
                //Console.WriteLine();
                Console.Write("\n");
            }


            ////Oef 4
            //bool parseSucceeded;
            //int input;
            //int i = 1;
            //do
            //{
            //    Console.Write("Write a positive number: ");
            //    parseSucceeded = int.TryParse(Console.ReadLine(), out input);


            //} while (!parseSucceeded);

            //while (i <= input)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            Console.WriteLine("Press any button to quit.");
            Console.ReadKey();
        }
    }
}
