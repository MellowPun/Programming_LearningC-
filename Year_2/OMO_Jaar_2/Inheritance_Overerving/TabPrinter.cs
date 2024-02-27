using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Overerving
{
    internal class TabPrinter :Printer
    {
        protected int mSpaces;

        public TabPrinter(int spaces) 
        {
            mSpaces = spaces;
        }

        public int Spaces
        {
            get { return mSpaces; }
            set { mSpaces = value; }
        }

        
        public override void Print(string text)
        {
            for (int i = 0; i < mSpaces; i++) 
            {
                Console.Write(" ");
            }
            Console.WriteLine(text);
        }

    }
}
