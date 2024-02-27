using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Oef
{
    internal class OEF7
    {

        protected int mApples;
        protected int mPears;

        public int Apples
        {
            get { return mApples; }
            set { mApples = value; }

        }
        public int Pears
        {
            get { return mPears; }
            set { mPears = value; }

        }

        
        public void AmountInVendingMachine()
        {
            if (mApples == 0) 
            { 
                return; 
            }
        }

        public void BuyProduct(int productSold,string typeProduct)
        {
            if(typeProduct == "apples")
            {
                mApples -= productSold;

            }
            else
            {
                mPears -= productSold;
            }

            
            
        }

        public void FillProduct(int productAmount, string typeProduct) 
        {
            int amountToFill = productAmount % 50;
            switch(typeProduct)
            {
                case "apples":
                    if (productAmount < 50)
                    {
                        mApples += amountToFill;

                    }

                    break;

                case "Pears":
                    if (productAmount < 50)
                    {
                        mPears += amountToFill;

                    }
                    break;
            }

        } 



    }
}
