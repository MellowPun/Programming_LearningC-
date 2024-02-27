using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Exercises
{
    public enum Pegi
    {
        Plus12 = 12,
        Plus16 = 16,
        Plus18 = 18,
    }
    internal class Games : DVD
    {
        private Pegi mPegiRating;

        public Games(string title, int price, int quantity, Pegi rating    ) : base(title, price, quantity)
        {
            mPegiRating= rating;
        }

        public override string ToString()
        {
            //return "Games - "+ base.ToString()+ " - Rating: " + mPegiRating;
            return base.ToString().Replace("DVD", "Games") + " - Rating: " + mPegiRating;
        }
    }
}
