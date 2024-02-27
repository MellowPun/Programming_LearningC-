using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_3_OPGAVE_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a random word: ");
            string inputString = Console.ReadLine();

            int inputLength = inputString.Length;
            // inputLength % 5 == 0  => deelbaar door vijf


            if (inputLength % 4 == 0 && !(inputLength % 5 == 0))
            {
                Console.WriteLine("Number of characters in name is divisible by 4 but not by 5.");
            }
            else
            {
                if (inputString == "Hello")
                {
                    Console.WriteLine("World");
                    inputString.Replace(inputString, "World");
                    inputLength = inputString.Length;
                }
                else
                {
                    Console.WriteLine("What a nice word {0}", inputString);
                }
            }

            // snap niet wat ze met 6 bedoelen dus inputlength dan maar
            Console.WriteLine("Number of characters {0}", inputLength);


            // 7
            int row = 1;
            int col;
            int cols;

            while (row <= inputLength)
            {
                col = inputLength;
                while (col <= inputLength)
                {
                    Console.Write("=");
                    col++;
                }
                cols = 1;
                while (cols <= row)
                {
                    Console.Write(" ");
                    cols++;
                }
                row++;
            }


            Console.ReadKey();
        }
    }
}
