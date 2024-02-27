using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Exercises
{
    internal class Dog : Animal
    {
        private bool mLongHair;

        public Dog(int amountOfLegs, bool longHair) : base(amountOfLegs, true)
        {
            mLongHair = longHair;
        }
        public Dog() : base(4,false) 
        {

        }


        public bool LongHair
        {
            get { return mLongHair; }
            set { mLongHair = value; }

        }

        public override string ToString()
        {
            string result;
            if(mLongHair== true)
            {
               result=  base.ToString() + "Barking dog with long Hair. ";
            }
            else
            {
                result = base.ToString() + "Barking dog with short Hair. ";
            }
            
            return result;
        }

    }
    
}
