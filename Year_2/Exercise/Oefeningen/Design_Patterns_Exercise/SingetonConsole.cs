using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Exercise
{
     public class SingetonConsole:IPrintable
    {
        private static SingetonConsole instance;
        private static object safetyLock = new object();
        private SingetonConsole() { }

        public static SingetonConsole GetInstance()
        {
            if (instance == null)
            {
                lock (safetyLock)
                {
                    if(instance == null)
                    {
                        instance = new SingetonConsole();
                    }
                }
            }
            return instance;
        }
        //Ge kunt ook als property maken
        /*
        public static SingetonConsole Instance 
        {
            get 
            {
                if (instance == null)
                {
                    lock (safetyLock)
                    {
                        if (instance == null)
                        {
                            instance = new SingetonConsole();
                        }
                    }
                }
                return instance;
            } 
        }
        */
        
        public void Print(string text)
        {
            lock(safetyLock)
            {
                Console.WriteLine(text);
            }
        }

    }
}
