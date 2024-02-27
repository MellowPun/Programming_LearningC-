using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Overerving
{
    internal class Dot : Point
    {
        protected int mRadius;
        public Dot(int radius)
        {
            mRadius = radius;
        }
        public Dot()
        {
            mRadius = 5;
        }

        public int Radius
        {
            get { return mRadius; }
            set { mRadius = value; }
        }

        public int CalculateSurface()
        {
            double doubleSurface = Math.Pow(mRadius, 2) * Math.PI;
            int surface = Convert.ToInt32(doubleSurface);
            return surface;
        }
        public void AskRadius()
        {
            int radius;
            Console.WriteLine("If X is {0}, and Y is {1}", XCoord,YCoord);
            Console.WriteLine("What is the radius?");
            int.TryParse(Console.ReadLine(), out radius);
            Radius = radius;

        }
        public override string ToString()
        {
            return base.ToString()+ string.Format("The radius is {0} which makes the surface {1}",mRadius,CalculateSurface());
        }


    }
}
