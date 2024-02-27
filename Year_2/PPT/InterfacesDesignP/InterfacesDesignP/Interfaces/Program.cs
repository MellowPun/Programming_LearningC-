using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IAnimalTalk> animalFarm = new List<IAnimalTalk>();
            for (int i = 0; i < 5; i++)
            {
                animalFarm.Add(new Bird());
            }
            for (int i = 0; i < 5; i++)
            {
                animalFarm.Add(new Cat());
            }
            foreach (IAnimalTalk anim in animalFarm)
            {
                anim.Speak();
                ((ILeggedAnimal)anim).WriteLegs();
            }
           

            Console.WriteLine("Press any key to continue..");
            Console.ReadKey();
        }
    }
}


/*  */
