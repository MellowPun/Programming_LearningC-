using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int row = 0;
            int col = 0;
            int i = 0;
            while (row < 5)
            {
                while (col < 6)
                {
                    if (i >= col)
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

                
            }Console.ReadKey();
        }
    }
}
