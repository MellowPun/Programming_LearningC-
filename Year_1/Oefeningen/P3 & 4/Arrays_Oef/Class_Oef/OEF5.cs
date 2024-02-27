using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Oef
{
    internal class OEF5
    {
        protected int mWidth;
        protected int mHeight;
        protected int mSurface;
        public OEF5(int width, int heigth)
        {
            Width = width;
            Height = heigth;

        }

        public int Width
        {
            get { return mWidth; }
            set { mWidth = value; }
        }
        public int Height
        {
            get { return mHeight; }
            set { mHeight= value; }
        }

        public int Surface
        {
            get { return mSurface; }
            set { mSurface = value; }
        }
        public void SurfaceRectangle()
        {
            Surface = Width * Height;

            
        }

        


        public override string ToString()
        {

            string result = string.Format("The rectangle has heigth {0}, width {1} and has a surface of {2}.",Height,Width,Surface);
            return result;
        }


    }
}
