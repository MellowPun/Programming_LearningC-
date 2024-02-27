using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverAuction
{
    class Bidder: IObserver
    {
        protected int maxBid;
        protected int raiseAmount;
        protected string name;

        public Bidder(string n, int max, int raise)
        {
            name = n;
            maxBid = max;
            raiseAmount = raise;
        }

        public string Name
        {
            get { return name;  }
        }

        public void Update(ISubject subject)
        {
            Auctioneer auctioneer = (Auctioneer)subject;
            if(auctioneer.currentBidderName != name && (auctioneer.Price + raiseAmount <= maxBid))
            {
                auctioneer.Bid(auctioneer.Price + raiseAmount, this);
                Console.WriteLine(Name + " offering new bid " + (auctioneer.Price + raiseAmount));
            }
        }

        
    }
}
