using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Les_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////OEFENOPDRACHT MACHT

            //int powerTo = 4;
            //int lowerPower = 2;

            //Console.WriteLine(Power(powerTo, lowerPower));


            ////OEFOPDRACHT 2 Reverse word
            //string word = "HELP";
            //STR(word);
            //Console.WriteLine(word);

            ////OEFOPDRACHT 3 Palindrome

            //string palindrome = "lepel";

            //Console.WriteLine(IsPalindrome(palindrome));

            ////OEFOPDRACHT 4 Multiplying rabbits

            //int month = 5;
            //Console.WriteLine( Fib(month));

            ////OEFOPDRACHT 5 trap met N treden

            //Console.WriteLine(NTreden(5));

            //OEFOPDRACHT 6 trap met N treden met beperking
            Console.WriteLine(NTred(5));


            Console.ReadKey();
        }
        static int Power(int n, int x)
        {
            if(n == 0)
            {
                return 1;
            }
            else
            {
                return x * Power(n-1,x);
                
            }
        }

        static void STR(string word)
        {
            if(word.Length == 1)
            {
                //print last character
                Console.WriteLine(word);
            }
            else
            {
                //print last character
                Console.Write(word[word.Length-1]);
                //repeat for everything but last character
                STR(word.Substring(0, word.Length-1));
                 
            }
        }
        static bool IsPalindrome(string palindrome)
        {
            

            if(palindrome.Length <= 1) 
            {
                return true;
            }
            else
            {
                if (palindrome[0] == palindrome[palindrome.Length - 1])
                {
                    
                    return IsPalindrome(palindrome.Substring(1, palindrome.Length - 2));
                }
                else
                {
                    return false;
                }
            }
        }
        static int Fib(int month)
        {
            if(month <= 2) 
            {
                return 1;
            }
            else
            {
                return Fib(month - 1)+Fib(month-2);
                
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
                return NTreden(treden - 1)+NTreden(treden-2);
            }
        }
        static int NTred(int treden)
        {
            if(treden <= 1)
            {
                return 1;
            }
            else
            {
                return NTred(treden-1)+NTred(treden-3);
            }
        }
    }
}
