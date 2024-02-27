using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonConsole
{
    class ConsoleManager
    {
        private static ConsoleManager instance;
        private static object initializeLock = new object();
        private static object writeLock = new object();

        private ConsoleManager()
        {
        }

        public static ConsoleManager GetInstance()
        {
            if (instance == null)//for thread safety
            {
                lock (initializeLock)
                {                        //doublecheck
                    if (instance == null)//for thread safety
                    {
                        instance = new ConsoleManager();
                    }
                }
            }
            return instance;
        }

        public static ConsoleManager Instance
        {
            get
            {
                if (instance == null)//for thread safety
                {
                    lock (initializeLock)
                    {                        //doublecheck
                        if (instance == null)//for thread safety
                        {
                            instance = new ConsoleManager();
                        }
                    }
                }
                return instance;
            }
        }



        public void WriteLine(string text)
        {
            lock(writeLock)
            {
                Console.WriteLine(text);
            }
        }
    }
}
