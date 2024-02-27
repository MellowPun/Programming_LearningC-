using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Learning
{
    internal class Program
    {
        static void Main(string[] args)
        {
            foreach (int i in ProduceEvenNumbers(9))
            {
                Console.Write(i);
                Console.Write(" ");
            }
            // Output: 0 2 4 6 8

            IEnumerable<int> ProduceEvenNumbers(int upto)
            {
                for (int i = 0; i <= upto; i += 2)
                {
                    yield return i;
                }
            }
        }
    }
}
