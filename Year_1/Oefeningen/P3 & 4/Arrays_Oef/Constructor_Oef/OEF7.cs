using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Oef
{
    internal class OEF7
    {
        protected ConsoleColor mForegroundColor;
        protected ConsoleColor mBackgroundColor;


        public OEF7(ConsoleColor foreGroundColor, ConsoleColor backGroundColor)
        {
            mForegroundColor = foreGroundColor;
            mBackgroundColor = backGroundColor;
        }

        public string PrintColor()
        {
            

            return string.Format("color {0},{1} ",mBackgroundColor.ToString(), mForegroundColor.ToString());
        }

        public void WriteLine(string result)
        {
            Console.ForegroundColor = mForegroundColor;
            Console.BackgroundColor = mBackgroundColor;


            Console.WriteLine(result);

        }
        public void WriteLine(string result , ConsoleColor foreground, ConsoleColor backGround)
        {
            Console.ForegroundColor = foreground; 
            Console.BackgroundColor = backGround;

            Console.WriteLine(result);
            Console.ForegroundColor = mForegroundColor;
            Console.BackgroundColor = mBackgroundColor;
        }
        
        public void ChangeColors(ConsoleColor foreGroundColor, ConsoleColor backGroundColor)
        {
            mForegroundColor = foreGroundColor;
            mBackgroundColor = backGroundColor;

        }



    }
}
