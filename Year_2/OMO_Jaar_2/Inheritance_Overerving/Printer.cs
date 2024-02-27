using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Overerving
{
    internal class Printer
    {
        public virtual void Print(string text)
        {
            Console.WriteLine(text);
        }



    }
}
