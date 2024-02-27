using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Opdracht DIA 19
            //int baseNumber;
            //int powerNumber;
            //Console.WriteLine("Give me the base number");
            //int.TryParse(Console.ReadLine(),out baseNumber);
            //Console.WriteLine("Give me the power");
            //int.TryParse(Console.ReadLine(), out powerNumber);

            //Console.WriteLine(Power(powerNumber, baseNumber));

            ////Opdracht Dia 20

            //Console.WriteLine("Give ma a word");
            //string input = Console.ReadLine();

            //Console.WriteLine(ReverseString(input));

            //Opdracht Dia 21
            string input;
            Console.WriteLine("Give me a word");
            input = Console.ReadLine();

            Console.WriteLine(Palindrome(input));

            ////Opdracht Dia 25

            //Console.WriteLine("Month of rabbits fucking");
            //int.TryParse(Console.ReadLine(), out int result);
            //Console.WriteLine( Fib(result)  );

            ////Opdracht Dia 27
            ////FUCK THAT IK GA DA NI BEREKENE
            //NTred(5);





            EndApplication();
        }
        static int Power(int powerNumber, int baseNumber) 
        {
            if(powerNumber == 0) 
            {
                return 1;
            }
            else
            {
                return baseNumber * Power((powerNumber - 1), baseNumber);
            }
        }
        static string ReverseString(string input) 
        {
            if (input.Length<=0)
            {
                return input;
            }
            else
            {
                return input.Substring(input.Length - 1) + ReverseString(input.Substring(0,input.Length-1));
            }
        }

        static bool Palindrome(string input)
        {
            if(input.Length <= 1)
            {
                return true;
            }
            else
            {
                if (input[0] == input[input.Length-1]) 
                {
                    return Palindrome(input.Substring(1,input.Length-2));
                }
                else
                {
                    return false;
                }
            }
        }

        static int Fib(int amountElements)
        {
            if(amountElements <= 2)
            {
                return 1;
            }
            else
            {
                return Fib(amountElements - 1)+Fib(amountElements-2);
            }
        }
        static int NTreden(int treden)
        {
            if (treden <= 1)
            {
                return 1;

            }
            else
            {
                return NTreden(treden - 1) + NTreden(treden - 2);
            }
        }
        static int NTred(int treden)
        {
            if (treden <= 1)
            {
                return 1;
            }
            else
            {
                return NTred(treden - 1) + NTred(treden - 3);
            }
        }


        static void EndApplication() 
        {
            Console.WriteLine("Press a button to continue...");
            Console.ReadKey();
        }


    }
}
