using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Overerving
{
    public enum Color
    {
        Cyan,
        DarkGreen,
        Purple
    }

    internal class Planet: SkyElement
    {
        Random random = new Random();
        protected ConsoleColor _ForeGroundColor;

        public ConsoleColor ForeGroundColor
        {
            get { return _ForeGroundColor; }
            set { _ForeGroundColor = value; }
        }
        public Planet(ConsoleColor foregroundColor)
        {
            _ForeGroundColor = foregroundColor;
        }
        public Planet() 
        {
            int i =random.Next(0, 3);
            _ForeGroundColor = (ConsoleColor)(Color)i;
        }

        public override void Print()
        {
            Console.ForegroundColor = _ForeGroundColor;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write("O");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Black;
        }

    }
}
