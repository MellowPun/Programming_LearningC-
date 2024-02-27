using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    public class Square : IShape
    {
        public double Circumference
        {
            get
            {
                return 2.1;
            }

        }

        public double Area
        {
            get
            {
                return 2.2;
            }
        }


        public void Info()
        {
            Console.WriteLine($"Cicumference: {Circumference}, Area: {Area}. ");

        }

    }
}
