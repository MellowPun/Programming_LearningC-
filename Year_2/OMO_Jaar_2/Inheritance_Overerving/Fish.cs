using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Overerving
{
    internal class Fish:Animal
    {
        protected string mColour;

        public string Colour
        {
            get { return mColour; }
            set { mColour = value; }
        }

        public Fish(string colour) : base(0,false)
        {
            this.mColour = colour.ToLower();
        }

        public override string ToString()
        {
            string result = base.ToString().Replace("Animal", "Fish") + string.Format("My color is {0}", mColour);
            
            return result;
        }


    }
}
