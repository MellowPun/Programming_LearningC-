using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Oef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////OEF 1
            //PrintData(2.65);
            //Console.WriteLine();


            ////OEF 2 
            //Console.WriteLine(Formula(2.5, 2));
            //Console.WriteLine(Formula(2.5, 2.5));
            //Console.WriteLine(Formula(2, 2));

            ////OEF 3 & OEF 4
            //string inputUser;
            //string inputPassword;
            //OEF3 exercise = new OEF3();
            //int result;
            //int resultSecond;

            //do
            //{
            //    Console.WriteLine("Give me a 2 numbers to but no 0 and if you wanna stop type stop");
            //    inputUser = Console.ReadLine();
            //    inputPassword = Console.ReadLine();
            //    if (int.TryParse(inputUser, out result) && int.TryParse(inputPassword, out resultSecond))
            //    {
            //        if (result == 0 || resultSecond == 0)
            //        {
            //            Console.WriteLine("you typed in 0 you fucking idiot");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Wanna add more numbers?");
            //            int.TryParse(Console.ReadLine(),out int addedEnumerator);
            //            int.TryParse(Console.ReadLine(),out int addedDenominator);
            //            if (int.TryParse(Console.ReadLine(), out addedEnumerator) &&
            //            int.TryParse(Console.ReadLine(), out addedDenominator))
            //            {
            //                exercise.Add(addedEnumerator, addedDenominator);
            //            }
            //            else
            //            {
            //                exercise = new OEF3(result, resultSecond);
            //                Console.WriteLine(exercise);
            //            }
            //        }

            //    }
            //    else
            //    {
            //        exercise = new OEF3();
            //        Console.WriteLine(exercise);
            //    }


            //} while (inputUser != "stop");

            ////OEF 7  & OEF 8 & 9 & 10 & 11

            //OEF7 colours = new OEF7(ConsoleColor.White,ConsoleColor.Black);
            

            //Console.WriteLine( colours.PrintColor());
            

            
            //colours.WriteLine("Cookies");

            //colours.WriteLine("Cookies", ConsoleColor.Red, ConsoleColor.DarkGray);
            //Console.WriteLine("Cookies");


            Console.ReadKey();
        }
        //OEF 1
        static void PrintData(string data)
        {
            Console.WriteLine("Text: " + data);
        }
        static void PrintData(int data)
        {
            Console.WriteLine("Int: " + data);
        }
        static void PrintData(double data)
        {
            Console.WriteLine("Double: " + data);
        }

        //OEF 2
        static double Formula(int i, int j)
        {
            return (double)i * (double)j;
        }

        static double Formula(double i, int j)
        {
            return i * (double)j;
        }

        static double Formula(double i, double j)
        {
            return i * j;
        }
    }
}
