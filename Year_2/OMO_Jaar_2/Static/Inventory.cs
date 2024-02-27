using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Static
{
    public class Inventory
    {
        protected static List<string> _InventoryList= new List<string>();

        public static List<string> InventoryList
        {
            get { return _InventoryList; }
        }

        public static void AddElement(string element)
        {
            _InventoryList.Add(element);
        }

        public static void DeleteElement(string element)
        {
            _InventoryList.Remove(element);
        }
        
        public static string AmountElement()
        {
            //string result = _InventoryList.Count().ToString();
            //_InventoryList.Count().ToString();
            return string.Format("{0}",_InventoryList.Count());
        }

        public static void DeleteElements()
        {
            _InventoryList = new List<string>();
            //_InventoryList.Clear();
        }

        public static void GetElement(int index)
        {
            Console.WriteLine(_InventoryList.ElementAt(index));
            //Console.WriteLine(_InventoryList[index]);
        }

        public static string GetElements()
        {
            return string.Join(", ",_InventoryList) ;
        }

        public static void ElementAvailable(string element)
        {
            if(_InventoryList.Contains(element))
            {
                Console.WriteLine(_InventoryList.IndexOf(element));
            }
            else
            {
                Console.WriteLine(-1);
            }

        }


    }
}
