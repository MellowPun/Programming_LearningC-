using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_Assesmblies
{
    public class Car_dll
    {
        protected string _Brand;
        protected int _MaxSpeed;
        protected int _Price;

        public Car_dll(string brand, int maxSpeed, int price)
        {
            _Brand = brand;
            _MaxSpeed = maxSpeed;
            _Price = price;

        }


        public string Brand 
        {
            get { return _Brand; }
            set { _Brand = value; }
        }

        public int MaxSpeed
        {
            get { return _MaxSpeed; }
            set { _MaxSpeed = value; }
        }

        public int Price
        {
            get { return _Price; }
            set { _Price = value; }
        }


        public override string ToString()
        {
            return "Coock";
        }

    }
}
