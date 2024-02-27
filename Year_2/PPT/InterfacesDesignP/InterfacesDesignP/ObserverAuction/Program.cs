using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ObserverAuction
{
    class Program
    {
        static void Main(string[] args)
        {
            Bidder b1 = new Bidder("b1", 13, 2);
            Bidder b2 = new Bidder("b2",22, 4);
            Bidder b3 = new Bidder("b3", 30, 3);

            Auctioneer auct = new Auctioneer(5);
            auct.Attach(b1);
            auct.Attach(b2);
            auct.Attach(b3);

            Thread t = new Thread(() => StartBidding(auct));
            t.Start();
            t.Join(5000);

            Console.WriteLine("The winner of the bid is " + auct.currentBidderName);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void StartBidding(Auctioneer a)
        {
            a.Notify();
            while (true)
            { 
                Thread.Sleep(500);
            }
        }
    }
}
