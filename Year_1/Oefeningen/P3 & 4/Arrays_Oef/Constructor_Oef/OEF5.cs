using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Oef
{
    internal class OEF5
    {
        protected int mColourIntegerFirst;
        protected int mColourIntegerSecond;
        protected int mColourIntegerThird;

        public OEF5(int colourFirst, int colourSecond, int colourThird)
        {
            mColourIntegerFirst = colourFirst;
            mColourIntegerSecond = colourSecond;
            mColourIntegerThird = colourThird;

        }

        public OEF5(float colourFirst, float colourSecond, float colourThird)
        {
            colourFirst *= 255 ;
            colourSecond *= 255 ;
            colourThird *= 255 ;

            mColourIntegerFirst = (int) colourFirst ;
            mColourIntegerSecond =(int) colourSecond ;
            mColourIntegerThird =(int) colourThird ;

        }

        public int ColourIntegerFirst
        {
            get { return mColourIntegerFirst; }
            set { mColourIntegerFirst = value; }
        }

        public int ColourIntegerSecond
        {
            get { return mColourIntegerSecond; }
            set { mColourIntegerSecond = value; }

        }
        public int ColourIntegerThird
        {
            get { return mColourIntegerThird; }
            set { mColourIntegerThird = value; }

        }
        

    }
}
