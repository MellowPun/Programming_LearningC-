using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Overerving
{
    internal class Animal
    {
        protected int mLegs;
        protected bool mHasLungs;

        public Animal(int legs, bool hasLungs) 
        {
            mLegs = legs;
            mHasLungs = hasLungs;
        }

        public Animal()
        {
            mLegs = -1;
            mHasLungs = true;
        }


        public int Legs
        {
            get { return mLegs; }
            set { mLegs = value; }
        }

        public bool HasLungs
        {
            get { return mHasLungs; }
            set { mHasLungs = value; }
        }

        public virtual string ToString()
        {
            string result = 
                string.Empty;
            if (mHasLungs == true)
            {
               result = string.Format("Animal with {0} paws and lungs. ",mLegs) ;
            }
            else
            {
               result =  string.Format("Animal with {0} paws and no lungs. ",mLegs);
            }
            return result ;

        }



    }
}
