using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Overerving
{
    internal class CapsColorPrinter :ColorPrinter
    {

        public CapsColorPrinter(ConsoleColor foreGround, ConsoleColor backGround): base(foreGround,backGround)
        {
        }

        public override void Print(string text)
        {
            text.ToUpper(); 
            base.Print(text);
        }

    }
}
