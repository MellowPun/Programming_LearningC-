using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DataTypes_Observer
{
    class Auctioneer : ISubject
    {
        protected int price;
        protected Bidder currentBidder;
        protected List<IObserver> observers;
        protected object lockPrice = new object(); // protect price
        protected object lockObservers = new object();// protect observers

        public int Price
        {
            get
            {
                return price;
            }

        }

        public string currentBidderName
        {
            get
            {
                if(currentBidder!= null)
                {
                    return currentBidder.Name;
                }
                else
                {
                    return "";
                }
            }
        }

        public void Bid(int newPrice, Bidder bidder)
        {
            lock(lockPrice)
            {
                if(newPrice > Price)
                {
                    price = newPrice;
                    currentBidder = bidder;
                    Console.WriteLine("New bid accepted: for {0}, price = {1}",bidder.Name,Price);
                    Notify();               
                
                }
            }
        }

        public Auctioneer(int openingBid)
        {
            price = openingBid;
            currentBidder = null;
            observers = new List<IObserver>();

        }
        public void Attach(IObserver observer)
        {
            lock(lockObservers)
            {
                observers.Add(observer);
            }
        }

        public void Detach(IObserver observer)
        {
            lock (lockObservers)
            {
                observers.Remove(observer);
            }
        }

        public void Notify()
        {
            lock (lockObservers)
            {
                foreach(IObserver ob in observers)
                {
                    ob.Update(this);
                    Thread.Sleep(5);
                }
            }
        }



    }
}
