using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Overerving
{
    internal class ColorPrinter :Printer
    {
        protected ConsoleColor mForeGround;
        protected ConsoleColor mBackGround;


        public ColorPrinter(ConsoleColor foreground, ConsoleColor background)
        {
            mForeGround = foreground;
            mBackGround = background;
        }
        public ConsoleColor ForeGround 
        {
            get { return mForeGround; } 
            set { mForeGround = value; }
        }
        public ConsoleColor BackGround 
        { 
            get { return mBackGround; }
            set { mBackGround = value; }
        }
        

        public override void Print(string text)
        {
            Console.ForegroundColor = mForeGround;
            Console.BackgroundColor = mBackGround;

            Console.WriteLine(text);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

        }


    }
}
