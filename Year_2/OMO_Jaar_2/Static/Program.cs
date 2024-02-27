using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OEF 4


            Inventory.AddElement("Sword");
            Inventory.AddElement("Magic Book");
            Inventory.AddElement("Cloth");
            Inventory.AddElement("Kick ball");

            Console.WriteLine(Inventory.GetElements());
            Console.WriteLine(Inventory.AmountElement());

            Inventory.DeleteElement("Magic Book");

            Console.WriteLine( Inventory.GetElements());
            Console.WriteLine( Inventory.AmountElement());

            Inventory.DeleteElements();

            Console.WriteLine(Inventory.GetElements());
            Console.WriteLine(Inventory.AmountElement());

            Inventory.AddElement("Sword");
            Inventory.AddElement("Magic Book");


           
            Inventory.GetElement(0);
            Inventory.ElementAvailable("Sword");
            Inventory.ElementAvailable("Swort");

            Console.ReadKey();


        }
    }
}
