using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
     class Manager
    {
        private static Manager instance;
        private static object initialiezLock= new object();
        private static object writeLock = new object();

        private Manager() { }

        public static Manager GetInstance()
        {
            if (instance == null) //for thread safety
            {
                lock (initialiezLock)//double check for thread safety
                {
                    if(instance == null)
                    {
                        instance = new Manager();
                    }
                }
            }
            return instance;
        }

        /*public static Manager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (initialiezLock)
                    {
                        if(instance == null)
                        {
                            instance = new Manager();
                        }
                    }
                }
                return instance;
            }
        }*/

        public void WriteLine(string text)
        {
            lock(writeLock)
            {
                Console.WriteLine(text);
            }
        }


    }
}
