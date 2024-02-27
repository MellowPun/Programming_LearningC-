using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_3_OPGAVE_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Hannah-Marie";
            string lastName = "Hermans";

            int firstnameLength = firstName.Length;
            string first = firstName.Substring(firstnameLength);
            Console.WriteLine("Hallo {0} {1}, je voornaam bestaat uit {2} letters, je achternaam uit {3}.", firstName, lastName, firstName.Length, lastName.Length);
            Console.WriteLine();

            Random randomGenerator = new Random();
            int rand = randomGenerator.Next(0, 10);


            // diamant = decrease + increase + descreas   = 1 kant 
            int row = 1;
            int col;
            int colStar1;
            int colStar2;
            while (row < rand)
            {
                col = row;
                while (col <= rand)
                {
                    Console.Write(" ");
                    col++;
                }
                colStar1 = 1;
                while (colStar1 <= row)
                {
                    Console.Write("*");
                    colStar1++;
                }
                colStar2 = 1;
                while (colStar2 < row)
                {
                    Console.Write("*");
                    colStar2++;
                }
                Console.WriteLine();
                row++;
            }

            // andere kant = increase + decrease + increase
            int rows = 1;
            int cols;
            int colStar3;
            int colStar4;

            while (rows <= rand)
            {
                cols = 1;
                while (cols <= rows)
                {
                    Console.Write(" ");
                    cols++;
                }
                colStar3 = rows;
                while (colStar3 <= rand)
                {
                    Console.Write("*");
                    colStar3++;
                }
                colStar4 = rows;
                while (colStar4 < rand)
                {
                    Console.Write("*");
                    colStar4++;
                }

                Console.WriteLine();
                rows++;
            }


            Console.ReadKey();
        }
    }
}
