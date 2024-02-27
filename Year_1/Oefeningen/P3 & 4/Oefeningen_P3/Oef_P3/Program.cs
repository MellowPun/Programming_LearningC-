using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef_P3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////OEF 2 
            //Console.WriteLine("X x Y = Z");

            //int length = 10;
            //int userInputAsNumber;
            //bool parseSucceeded;
            //do
            //{
            //    Console.WriteLine("Give a number greater than 0.");
            //    parseSucceeded = int.TryParse(Console.ReadLine(), out userInputAsNumber);

            //}
            //while (userInputAsNumber <= 0 || !parseSucceeded);

            //for (int i = 1; i <= length; i++)
            //{

            //    Console.WriteLine("{0} \t* \t{1} \t= \t{2}", userInputAsNumber,
            //        i,
            //        userInputAsNumber * i);
            //}

            ////OEF 3
            //int length = 7;
            //int moreLength = 70;
            //int counter = 1;
            //for(int i = 1; i <= length ; i++)
            //{

            //    for(int j=1; j <= moreLength; j++)
            //    {

            //        Console.WriteLine("vergeef me " + counter);
            //        counter++;
            //    }
            //}

            ////OEF 5
            //int i = 1;
            //for (int row = 0; row < 6; row++)
            //{

            //    for(int col=0; col < i; col++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //    i++;
            //}

            //OEF 6.1
            //int row;
            //for(row = 0;row < 5; row++)
            //{
            //    for(int col=0;col < 5; col++)
            //    {
            //        if (row >= col)
            //        {
            //            Console.Write(col);
            //        }
            //        else
            //        {
            //            Console.Write("*");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            ////OEF 6.2

            //int length = 5;
            //for (int row = 1; row <= length; row++)
            //{
            //    for (int col=0;col<length;col++)
            //    {
            //        if (length - row > col)
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(row);
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();


            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}
