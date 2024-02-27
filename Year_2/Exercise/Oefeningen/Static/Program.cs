using DLL_Usage;
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
            Inventory.AddString("Pen");
            Inventory.AddString("Parchment");
            Inventory.AddString("Water");
            Inventory.ShowElemantAt(1);
            Inventory.IndexOf("Water");
            Inventory.CheckElement("Parchment");
            Inventory.ShowList();
            Inventory.RevmoveString(1);
            Inventory.ShowList();
            Inventory.AskListLength();
            Inventory.ShowElement(0);
            Inventory.IndexOf("Water");
            Inventory.CheckElement("Parchment");
            Inventory.ShowElemantAt(1);
            Console.ReadKey();

        }
    }
}
