using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Overerving
{
    internal class Point
    {
        protected int mXCoord;
        protected int mYCoord;

        public Point()
        {
            mXCoord = 0; mYCoord = 0;
        }
        
        public Point(int xCoord, int yCoord)
        {
            mXCoord = xCoord;
            mYCoord = yCoord;
        }

        public int XCoord
        {
            get { return mXCoord; }
            set { mXCoord = value; }
        }
        public int YCoord
        {
            get { return mYCoord; }
            set { mYCoord = value; }
        }


        public void AskCoordinates()
        {
            int xCoord;
            int yCoord;
            Console.WriteLine("What is the X coordinate?");
            int.TryParse(Console.ReadLine(), out xCoord );
            Console.WriteLine("What is the Y coordinate?");
            int.TryParse(Console.ReadLine(), out yCoord);

            XCoord = xCoord;
            YCoord = yCoord;

        }

        public virtual string ToString()
        {
            return string.Format("The X-Coordinate is {0} and the Y-Coordinate is {1}", mXCoord, mYCoord);
        }


    }
}
