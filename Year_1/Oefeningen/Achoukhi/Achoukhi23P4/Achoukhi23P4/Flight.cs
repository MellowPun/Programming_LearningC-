using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achoukhi23P4
{
    internal class Flight
    {
        protected double mHours;
        protected double mPrice;
        protected string mDestination;

        public Flight(double hours, double price, string destination)
        {
            mHours = hours;
            mPrice = price;
            mDestination = destination;

        }

        public double Hours
        {
            get { return mHours; }
            set { mHours = value; }

        }

        public double Price
        {
            get { return mPrice; }
            set { mPrice = value; }

        }

        public string Destination
        {
            get { return mDestination; }
            set { mDestination = value; }

        }





    }
}
