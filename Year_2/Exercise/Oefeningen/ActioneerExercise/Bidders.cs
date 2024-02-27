using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActioneerExercise
{
    public class Bidders : IBidders
    {
        protected string _NameBidder;
        protected int _MaxPrice;
        
        public string NameBidder
        {
            get { return _NameBidder; }
            set { _NameBidder = value; }
        }

        public int MaxPrice
        {
            get { return _MaxPrice; }
            set { _MaxPrice = value; }
        }
        public Bidders(string nameBidder, int maxPrice)
        {
            _NameBidder=nameBidder;
            _MaxPrice=maxPrice;
        }

        public void addBidder(IActioneer products)
        {
            products.AttachProduct(this);
        }
        public void removeBidder(IActioneer products) 
        {
            products.DetachProduct(this);
        }
        public void Update(IActioneer products, int price) 
        {
            Console.WriteLine("Hello " + NameBidder+ ". The price right now is "+ price + " of the product " + ((Actioneer)products).ProductName);
        }

    }
}
