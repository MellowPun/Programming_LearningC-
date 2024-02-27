using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DLL_Usage
{
    public class Inventory
    {
        //Als je een randommizer wil gebruiken in een DLL / publieke klasse moet je de hieronder code gebruiken anders herhalen de cijfers:
        //static Random rand = new Random(); 

        //NIET VERGETEN INTIALISEREN == NEW LIST<STRING>
        protected static List<string> mInventoryList = new List<string>();

        public static List<string> InventoryList
        {
            get { return mInventoryList; }
        }
        //a.
        public static void AddString(string item)
        {
            mInventoryList.Add(item);

        }
        //b.
        public static void RevmoveString(int index)
        {
            if (index >= 0 && index < mInventoryList.Count) 
            {
                mInventoryList.RemoveAt(index);
            }

        }
        //c.
        public static void AskListLength()
        {
            Console.WriteLine("The list length is {0}", mInventoryList.Count);

        }
        //d.
        public static void ClearList()
        {
            mInventoryList.Clear();
            //clear werkt soms niet even goed
            //best gwn nieuwe list initialiseren
            // mInventoryList = new List<string>;

        }
        //e.
        public static void ShowElement(int index)
        {
            Console.WriteLine(mInventoryList[index]); ;

        }
        //f.
        public static void ShowList()
        {
            foreach(string item in mInventoryList)
            {
                Console.WriteLine(item);
            }
        }
        //g.
        public static void CheckElement(string item)
        {
            if (mInventoryList.Contains(item) == true)
            {
                Console.WriteLine("The object is on the {0}th place.", mInventoryList.IndexOf(item));
            }
            else
            {
                Console.WriteLine("The element isn't in the list. -1 ");
            }
        }
        //Plaats geven op basis van element
        public static void IndexOf(string item)
        {
            Console.WriteLine( mInventoryList.IndexOf(item));
        }
        //e. met elementat gebruiken
        public static void ShowElemantAt(int index)
        {
            Console.WriteLine( mInventoryList.ElementAt(index));
        }

    }
}
