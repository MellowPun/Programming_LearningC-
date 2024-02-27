using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achoukhi23P4
{
    internal class Stay
    {
        protected string mHotel;
        protected int mDays;
        protected double mPrice;

        public Stay(string hotel, int days, double price)
        {
            mHotel = hotel;
            mDays = days;
            mPrice = price;
        }

        public string Hotel
        {
            get { return mHotel; }
            set { mHotel = value; }
        }
        public int Days
        {
            get { return mDays; }
            set { mDays = value; }


        }

        public double Price
        {
            get { return mPrice; }
            set { mPrice = value; }

        }

    }
}
