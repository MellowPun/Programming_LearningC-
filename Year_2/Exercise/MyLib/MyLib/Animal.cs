using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Animal
    {
        protected string mName;
        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }
        public override string ToString() { return "Animal: " + mName; }
    }
}
