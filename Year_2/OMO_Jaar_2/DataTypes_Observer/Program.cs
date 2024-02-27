using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataTypes_Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bidder b1 = new Bidder("Viktor",13,2);
            Bidder b2 = new Bidder("Jolien", 22, 3);
            Bidder b3 = new Bidder("Elijah", 30, 4);

            Auctioneer auct = new Auctioneer(2);
            auct.Attach(b1);
            auct.Attach(b2);
            auct.Attach(b3);

            Thread t = new Thread(() => StartBidding(auct));
            t.Start();
            t.Join(5000);

            Console.WriteLine("The winner of the bid is "+ auct.currentBidderName);
            Console.WriteLine("Press any key");
            Console.ReadKey();


        }

        static void StartBidding(Auctioneer a)
        {
            a.Notify();
            while(true)
            {
                Thread.Sleep(500);
            }
        }

    }
}
