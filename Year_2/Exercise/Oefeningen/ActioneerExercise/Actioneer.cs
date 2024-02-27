using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ActioneerExercise
{
    public class Actioneer : IActioneer
    {
        private List<IBidders> _bidders = new List<IBidders>();
        protected string _ProductName;
        protected int _ProductPrice;
        
        public int ProductPrice
        {
            get { return _ProductPrice; }
            set { _ProductPrice = value; }
        }

        public string ProductName
        {
            get { return _ProductName; }
            set { _ProductName = value; }
        }

        public Actioneer(string productName, int productPrice) 
        {
            _ProductName = productName;
            _ProductPrice = productPrice;
        }
        
        public void AttachProduct(IBidders bidders)
        {
            Console.WriteLine("Bidder added: "+ ((Bidders)bidders).NameBidder);
            _bidders.Add(bidders);
        }

        public void DetachProduct(IBidders bidders)
        {
            Console.WriteLine("Bidder Removed: " + ((Bidders)bidders).NameBidder);
            _bidders.Remove(bidders);
        }

        public void Notify() 
        {
            Console.WriteLine("Product name: "+ ProductName + " Base price: " +ProductPrice);
            Console.WriteLine();
            
            foreach (IBidders bidders in _bidders)
            {
                bidders.Update(this, ProductPrice);
            }
        }

        public void Bidding(int price)
        {
            int upprice = price;
            ProductPrice += upprice;
            Notify();
        }

    }
}
