using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Overerving
{
    internal class SkyElement
    {
        public virtual void Print()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(" ");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
