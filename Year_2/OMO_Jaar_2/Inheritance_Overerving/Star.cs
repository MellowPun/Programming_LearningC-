using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Overerving
{
    internal class Star : SkyElement
    {

        public override void Print()
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue; 
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("*");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;


        }

    }
}
