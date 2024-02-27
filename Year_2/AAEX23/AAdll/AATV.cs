using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AAdll
{// This exam is made by Achoukhi Ayoub
    public class AATV : AAMedium
    {
        private int _ScreenSize;
        static int _TVCount = 0;

        public static int Count
        {
            get {  return _TVCount; }
        }



        public AATV(string medium, int screenSize) : base(medium, true)
        {
            _ScreenSize = screenSize;
            _TVCount++;
        }


        public  override void  Show()
        {
            base.Show();
            Console.WriteLine($"- Screen size = {_ScreenSize} inch");
        }




    }
}
