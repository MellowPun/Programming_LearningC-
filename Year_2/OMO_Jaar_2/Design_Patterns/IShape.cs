using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    public interface IShape
    {
        double Circumference 
        { get; }
        double Area
        { get; }

        void Info();




    }
}
