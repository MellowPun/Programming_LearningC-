using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht_Assesmblies
{
    public class Circle_dll
    {
        protected int _Radius;
        protected int _Position;
        protected static int _AmountCircles=0;

        public Circle_dll(int radius, int position)
        {
            _Radius = radius;
            _Position = position;
            _AmountCircles++;
        }

        public Circle_dll(int radius)
        {
            _Radius=radius;
            _AmountCircles++;
        }

        public int Radius
        {
            get { return _Radius; }
            set { _Radius = value; }
        }

        public int Position
        {
            get { return _Position; }
            set { _Position = value; }
        }

        public static int AmountCircles
        {
            get { return _AmountCircles; }
        }

        public double Circumference
        {
            get { return CircumferenceFormula(_Radius); } 
        }
        
        public double Surface
        {
            get { return SurfaceFormula(_Radius); }
        }

        public static double CircumferenceFormula(int radius)
        {

            return radius * 2 * Math.PI;
        }

        public static double SurfaceFormula(int radius)
        {

            return Math.Pow(radius, 2) * Math.PI;

        }

    }
}
