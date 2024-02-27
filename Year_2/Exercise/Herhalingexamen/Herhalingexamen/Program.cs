using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Herhalingexamen
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {
            CreateNumberLists(10);
            Console.ReadKey();
        }
        static void CreateNumberLists(int number)
        {
            Random randomGenerator = new Random();

            int[] originalNums= new int[number];
            for (int i = 0; i < originalNums.Length; i++)
            {
                originalNums[i] = randomGenerator.Next(100, 201);
            }
            Console.Write("All Numbers: ");

            foreach (int i in originalNums)
            {
                
                Console.Write(i+", ");
            }
            Console.WriteLine();
            List<int> evenNumbers = new List<int>();
            List<int> oddNumbers = new List<int>();


            for (int i = 0;i < originalNums.Length;i++)
            {
                if (originalNums[i] %2==1)
                {
                    oddNumbers.Add(originalNums[i]);
                }
                else
                {
                    evenNumbers.Add(originalNums[i]);
                }
                    
            }
            Console.Write("oddNumbers: ");
            foreach (int i in oddNumbers)
            {
                Console.Write(i + ", ");

            }
            Console.WriteLine();
            Console.Write("evenNumberss: ");
            foreach (int i in evenNumbers)
            {
                Console.Write(i+", ");
            }
            Console.WriteLine();
            int countOdd = 0;
            int countEven = 0;
            while (oddNumbers.Count>0 && evenNumbers.Count>0)
            {
                
                Console.WriteLine(oddNumbers[countOdd]);
                oddNumbers.RemoveAt(countOdd);

                Console.WriteLine(evenNumbers[countEven]);
                evenNumbers.RemoveAt(countEven);
                
            }
            int index = 0;
            while (index < evenNumbers.Count)
            {
                Console.WriteLine(evenNumbers[index]);
                index++;
            }




        }
    }
}
