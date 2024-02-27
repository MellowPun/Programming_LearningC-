using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAM_3_OPGAVE_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bovengrens;
            int ondergrens;
            int deler;
            bool parseSucceeded;


            // parsen gaat niet !! 
            do
            {
                Console.WriteLine("Geef een ondergrens: ");
                parseSucceeded = int.TryParse(Console.ReadLine(), out ondergrens);

                Console.WriteLine("Geef een bovengrens: ");
                parseSucceeded = int.TryParse(Console.ReadLine(), out bovengrens);

                Console.WriteLine("Geef een deler: ");
                parseSucceeded = int.TryParse(Console.ReadLine(), out deler);

            } while (!parseSucceeded);




            int numbers = 0;
            int sum = 0;
            int i = ondergrens;

            while (i <= bovengrens)
            {
                numbers = i;
                if (numbers % deler == 0)
                {
                    Console.Write(numbers + " ");
                    numbers++;
                    sum += i;
                }
                i++;
            }
            Console.WriteLine();
            Console.WriteLine(sum);



            Console.ReadLine();
        }
    }
}
