using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Oef
{
    internal class OEF3
    {
        protected int mEnumerator;
        protected int mDenominator;
        public OEF3()
        {
            mEnumerator = 1;
            mDenominator = 1;
        }
        public OEF3(int enumerator, int denominator) 
        {
            mEnumerator=enumerator;
            mDenominator = denominator;

        }

        public int Enumerator
        {
            get { return mEnumerator; }
            set { mEnumerator = value; }
        }
        public int Denomimnator
        {
            get { return mDenominator; } 
        }

        public double FinishResult()
        {
            
            return mEnumerator/mDenominator;
        }

        public override string ToString()
        {
            string result = string.Format("{0}/{1}= {2}",Enumerator,Denomimnator,FinishResult());
            return result;
        }

        public void Add(int enumerator)
        {
            mEnumerator +=enumerator;
        
            
        
        }

        public void Add(int enumerator, int denominator)
        {
            mEnumerator+= enumerator;
            mDenominator+=denominator;

        }

    }
}
