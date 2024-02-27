using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AAdll
{// This exam is made by Achoukhi Ayoub
    public class AAMediumManager
    {

        private static AAMediumManager instance;
        private static object listLock = new object();
        private static object initializeLock = new object();
        public List<AAMedium> Media;


        public static AAMediumManager GetInstance()
        {
            if (instance == null) //for thread safety
            {
                lock (initializeLock)//double check for thread safety
                {
                    if (instance == null)
                    {
                        instance = new AAMediumManager();
                    }
                }
            }
            return instance;
        }

        public void Empty()
        {
            lock (listLock)
            {
                Media = new List<AAMedium>();
            }
        }

        public void AddMedium(AAMedium medium)
        {
            lock (listLock)
            {
                Media.Add(medium);
            }
        }

        public void RemoveFirstMedium()
        {
            lock (listLock)
            {
                int i = (Media.Count());
                Media.RemoveAt(i);
            }
        }

        public void ShowAll()
        {
            lock (listLock)
            {
                Console.WriteLine("==========");
                foreach (AAMedium medium in Media)
                {
                    medium.Show();
                }

            }
        }


    }
}
