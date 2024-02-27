using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Exercises
{
    public class Disk
    {
        //hieronder variabels
        protected string mTitle;
        protected int mPrice;
        protected int mQuantity;

        //hieronder Constructor
        public Disk(string title, int price,int quantity) 
        {
            mTitle = title;
            mPrice = price;
            mQuantity = quantity;
        }

        //hierover alle properties
        public string Title
        {
            get { return mTitle; }
            set { mTitle = value; }
        }
        public int Price
        {
            get { return mPrice; }
            set { mPrice = value; }

        }

        public int Quantity
        {
            get { return mQuantity; }

        }
        public override string ToString()
        {
            return "Title: "+ mTitle+ " - Price: " + mPrice + " - Quantity: " + mQuantity+ ".";
        }

    }
}
