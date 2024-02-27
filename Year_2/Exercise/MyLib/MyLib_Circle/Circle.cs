using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib_Circle
{
    public class Circle
    {
        protected int mRadius;
        protected int mPosition;

        protected static int mNumCircles = 0;
        public Circle(int radius, int position) 
        {
            mRadius= radius;
            mPosition= position;
            mNumCircles++;
        }
        public Circle(int radius)
        {
            mRadius = radius;
            mNumCircles++;
        }

        public static int NumCircles
        {
            get { return mNumCircles; }
        }
        public int Radius
        {
            get { return mRadius; }
            set { mRadius = value; }
        }
        public int Position
        {
            get { return mPosition; }
            set { mPosition = value; }
        }

        public double Circumference
        {
            get { return CalculateCircumrence(mRadius); }
        }
        public double Surface
        {
            get { return CalculateSurface(mRadius); }
        }

        public static double CalculateCircumrence(int radius)
        {
            
            return radius * 2 * Math.PI;
        }
        public static double CalculateSurface(int radius)
        {
            return Math.Pow(radius, 2) * Math.PI;
        }



    }
}
