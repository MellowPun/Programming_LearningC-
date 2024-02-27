using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProefExamen
{

    public enum ColorValue
    {
        Red = 1, 
        Green, 
        Blue, 
        Yellow = 4
    }
    internal class PixelArt
    {
        protected string mAutor;
        protected int mWidth;
        protected int mHeight;
        protected List <ColorValue> mPixelColors;

        public PixelArt(string author, int width, int height) 
        {
            Autor = author;
            Width = width;
            Height = height;
            PixelColors = new List <ColorValue>();
            Random randomGenerator = new Random();
            int randomValue;
            for(int i = 0; i < Width*Height; i++) 
            {
                randomValue = randomGenerator.Next(1,5);
                PixelColors.Add((ColorValue)randomValue);
            }
        }


        public int Height
        {
            get { return mHeight; }
            set { mHeight = Math.Abs(value); }

        }

        public int Width
        {
            get { return mWidth; }
            set { mWidth = Math.Abs(value); }
        }
        public string Autor
        {
            get { return mAutor; }
            set { mAutor = value; }
        }
        public List <ColorValue> PixelColors
        {
            get { return mPixelColors; }
            set
            {
                mPixelColors = value;
            }
        }

        private void DrawPixel(ColorValue color)
        {
            switch(color)
            {
                case ColorValue.Red:
                    Console.ForegroundColor = ConsoleColor.Red;

                    break;
                case ColorValue.Green:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case ColorValue.Blue:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case ColorValue.Yellow:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
            }
            Console.Write("* ");
        }

        public void DrawPixelArt()
        {
            int counter= 0 ;

            for(int i = 0; i < Height; i++)
            {


                for(int j = 0; j < Width; j++)
                {
                    DrawPixel(PixelColors[counter]);
                    counter++;
                    
                }
                Console.WriteLine();
            }

            Console.ForegroundColor= ConsoleColor.White;
        }

        public override string ToString()
        { 
              return string.Format("This is {0} X {1} made by {2}",Height, Width,Autor);
        }



    }
}
