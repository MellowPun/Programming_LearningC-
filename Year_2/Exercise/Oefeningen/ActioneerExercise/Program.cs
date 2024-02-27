using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActioneerExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Bidders person1 = new Bidders("Jack", 22);
            Bidders person2 = new Bidders("Martin", 12);


            Actioneer product1 = new Actioneer("Kinepolis", 5);
            Actioneer product2 = new Actioneer("Sauna", 14);

            person1.addBidder(product1);
            person2.addBidder(product1);
            product1.Bidding(2);

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
