using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Overerving
{
    internal class Dog : Animal
    {

        protected bool mLongHair;

        public bool LongHair
        {
            get { return mLongHair; }
            set { mLongHair = value; }
        }

        public Dog(int legs,bool longHair):base(legs, true)
        {
            this.mLongHair=longHair;
        }
        public Dog()
        {
            mLongHair=true;
        }

        public override string ToString()
        {
            if(mLongHair==true) 
            {
                return base.ToString() + string.Format("Barking dog with long hair.");
            }
            else
            {
                return base.ToString() + string.Format("Barking dog with short hair.");
            }
        }

    }
}
