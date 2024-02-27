using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOText_OEF
{
    internal class Animal
    {

        protected string mType;
        protected int mAmountOfFeet;

        public Animal(string type, int feet) 
        {
            mAmountOfFeet = feet;
            mType = type;


        }
        public string Type
        {
            get { return mType; }
            set { mType = value; }
        }
        public int AmountOfFeet
        {
            get { return mAmountOfFeet;}
            set { mAmountOfFeet = value;}
        }

        public override string ToString()
        {
            string result = string.Format(Type + AmountOfFeet);
            return result;
        }

    }
}
