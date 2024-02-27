using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabelen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberEuro;
            int exchangeRate = 1173;
            int numberDollar;

            Console.WriteLine("How many Euro\'s do you want to exchange into Dollars?");
            string wordEuro = Console.ReadLine();
            int.TryParse(wordEuro, out numberEuro);

            numberDollar = (numberEuro * exchangeRate) / 1000;

            Console.WriteLine(" {0} Euro is equal to {1} Dollar.", numberEuro, numberDollar);
            Console.ReadKey();

        }
    }
}
