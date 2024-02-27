using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_oef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HelloWorld();

            int myMethodResult = AskUserForNumber("Please enter your age.");

            EndApplication();



        }
        static void EndApplication()
        {
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
        }
        

        
        static int AskUserForNumber(string message)
        {
            bool parseSucceeded;
            int result;
            do
            {
                Console.Write(message + ":");
                parseSucceeded = int.TryParse(Console.ReadLine(), out result);
            }
            while(!parseSucceeded);


            return result;
        }
        static void HelloWorld()
        {
            Console.WriteLine("Hello world");

        }
    }
}
