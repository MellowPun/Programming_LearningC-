using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Cat: IAnimalTalk, ILeggedAnimal
    {
        public string Text
        {
            get
            {
                return "miauw";
            }        
        }
        public int NumLegs
        {
            get
            {
                return 4;
            }
        }
        public void WriteLegs()
        {
            Console.WriteLine("Cat has " + NumLegs + " paws");
        }

        public void Speak()
        {
            Console.WriteLine("Cat says: " + Text);
        }
    }
}
