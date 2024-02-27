using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Herhalingexamen
{
    enum CoffeeElement
    {
        Sugar = 1,
        Cream =2,
        Beans = 3,
    }
    internal class Coffee
    {
        protected string mName;
        protected List<CoffeeElement> mMyElements;


        public Coffee(string name)
        {
            name = mName;
            mMyElements = new List<CoffeeElement>();
        }
        public Coffee()
        {
            mName = "Unknown";
            mMyElements = new List<CoffeeElement>();
        }

        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }
        public float Price
        { get
            {
                float sum = 0;
                foreach (CoffeeElement item in MyElements)
                {
                    sum += (int)item;
                }
                return sum/2;

            } 
        }
        public List<CoffeeElement> MyElements
        {
            get { return mMyElements; }
            set { mMyElements = value; }
        }
        public void AddElement(CoffeeElement element)
        {
            MyElements.Add(element);
            Console.WriteLine("Adding "+ element.ToString()+ " to "+Name);
        }
        

    }
}
