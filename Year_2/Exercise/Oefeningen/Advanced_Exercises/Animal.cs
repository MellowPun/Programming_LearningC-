using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Exercises
{
    internal class Animal
    {
        protected int mAmountOfLegs;
        protected bool mHasLungs;

        public Animal(int amountOfLegs, bool hasLungs)
        {
            mAmountOfLegs = amountOfLegs;
            mHasLungs = hasLungs;

        }
        public int AmountOfLegs
        {
            get { return mAmountOfLegs; }
            set { mAmountOfLegs = value;}
        }
        public bool HasLungs
        {
            get { return mHasLungs; }
            set { mHasLungs = value;}

        }

        public override string ToString()
        {
            string result;
            if (HasLungs ==true)
            {
                 result = "Animal with " + mAmountOfLegs + " paws and lungs. ";

            }
            else
            {
                result = "Animal has no lungs. ";
            }


            return result;
        }
        
    }
}
