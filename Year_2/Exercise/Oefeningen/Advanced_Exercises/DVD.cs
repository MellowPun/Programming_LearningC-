using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Exercises
{
    internal class DVD : Disk
    {
        public DVD(string title, int price, int quantity): base (title, price, quantity) 
        {
            
        }
        public override string ToString()
        {
            return "DVD - " +base.ToString();
        }
    }
}
