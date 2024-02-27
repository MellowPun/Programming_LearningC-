using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes_Observer
{
    internal class Bidder : IObserver
    {
        protected int _MaxBid;
        protected int _RaiseAmount;
        protected string _Name;

        public Bidder(string name, int max,int raise) 
        {
            _Name = name;
            _MaxBid = max;
            _RaiseAmount = raise;

        }

        public string Name
        {
            get { return _Name; }
        }

        public void Update(ISubject subject)
        {
            Auctioneer auctioneer = (Auctioneer)subject;
            if(auctioneer.currentBidderName != _Name && (auctioneer.Price + _RaiseAmount <= _MaxBid))
            {
                Console.WriteLine(_Name + " offering new bid " + (auctioneer.Price + _RaiseAmount));
                auctioneer.Bid(auctioneer.Price + _RaiseAmount, this);
               
            }
        }



    }
}
