using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    class Circle : IShape
    {
        public double Circumference
        {
            get
            {
                return 1.1;
            }
        }

        public double Area
        {
            get
            {
                return 1.2;
            }
        }

        public void Info()
        {
            Console.WriteLine($"Cicumference: {Circumference}, Area: {Area}. ");

        }

    }

}
