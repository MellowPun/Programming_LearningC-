using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOText_OEF
{
    [Serializable]
    internal class ConsoleSettings
    {
        protected ConsoleColor mForegroundColor;
        protected ConsoleColor mBackgroundColor;
        protected int mAmountOfStartUpBeeps;

        public ConsoleColor ForegroundColor 
        {
            get { return mForegroundColor; } 
            set { mForegroundColor = value; } 
        }

        public ConsoleColor BackgroundColor
        {
            get { return mBackgroundColor; }
            set { mBackgroundColor = value; }

        }

        public int AmountOfStartUpBeeps
        {
            get { return mAmountOfStartUpBeeps; }
            set
            {
                mAmountOfStartUpBeeps = value;
            }
        }
        

    }
}
