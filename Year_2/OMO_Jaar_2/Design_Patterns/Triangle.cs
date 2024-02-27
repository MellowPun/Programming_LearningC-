using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    public class Triangle : IShape
    {
        public double Circumference
        {
            get
            {
                return 18.0;
            }
        }

        public double Area
        {
            get
            {
                return 2.90;
            }
        }

        public void Info()
        {
            Console.WriteLine($"Cicumference: {Circumference}, Area: {Area}. ");
        }
    }
}
