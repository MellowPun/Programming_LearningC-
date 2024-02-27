using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Exercises
{
    public class CD : Disk
    {
        protected int mAmountSongs;

       public CD(string title, int price, int quantity, int amountSongs) : base(title, price, quantity)
        {
            mAmountSongs = amountSongs;    
        }

        public int AmountSongs
        {
            get { return mAmountSongs; }
            set { mAmountSongs = value; }
        }
        public override string ToString()
        {
            return "CD - " +base.ToString() + " Songs count: "+ AmountSongs;
        }
    }
}
