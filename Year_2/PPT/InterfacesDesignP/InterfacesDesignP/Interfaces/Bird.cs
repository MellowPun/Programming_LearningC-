using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Bird: IAnimalTalk, ILeggedAnimal
    {
        public string Text
        {
            get
            {
                return "tsjirp tsjirp";
            }
        }
        public int NumLegs
        {
            get
            {
                return 2;
            }
        }
        public void WriteLegs()
        {
            Console.WriteLine("Bird has " + NumLegs + " paws");
        }

        public void Speak()
        {
            Console.WriteLine("Bird says: " + Text);
        }

        
    }
}
