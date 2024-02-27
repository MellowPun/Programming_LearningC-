using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Exercises
{
    internal class Fish : Animal
    {
        protected string mColour;

        public Fish(string colour) : base(0, false)
        {
            this.mColour = colour;
            // this gebruiken zodat het duidelijk is dat het in deze klasse gebruikt moet worden
            // en niet van een parent genomen ma worden

        }
        public string Colour
        {
            get { return mColour; }
            set { mColour = value; }
        }
        public override string ToString() 
        {
            string result;
            result = base.ToString().Replace("Animal", "Fish") + "My color is "+ mColour;
            return result; 
        }

    }
}
