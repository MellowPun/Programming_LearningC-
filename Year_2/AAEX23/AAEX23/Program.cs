using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using AAdll;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Net.Http.Headers;
using System.Diagnostics;

namespace AAEX23
{// This exam is made by Achoukhi Ayoub
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            Thread threadPaper = new Thread(new ThreadStart(MakeNewsPaper));
            Thread threadTV = new Thread(new ThreadStart(MakeTVs));
            Thread threadStopwatch = new Thread(() => ShowAndRemove(3000));
            AAMediumManager.GetInstance().Empty();
            threadPaper.Start();
            threadTV.Start();
            threadStopwatch.Start();
            sw.Start();

            threadPaper.Join();
            //threadStopwatch.Join();
            threadTV.Join();


            //while (sw.ElapsedMilliseconds <5000)
            //{
            //    threadPaper.Join();
            //    threadStopwatch.Join();
            //    threadTV.Join();
            //}
            //threadPaper.Abort();
            //threadTV.Abort();
            //while(sw.ElapsedMilliseconds < 10000)
            //{
            //    threadStopwatch.Abort();
            //}
            

           


            AAMediumManager.GetInstance().ShowAll();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
        public static void MakeNewsPaper()
        { 
            int counter = 0;
            

            do
            {
                AAMediumManager.GetInstance().AddMedium(new AAMedium("paper" + (counter + 1), false));
                int i = AAMediumManager.GetInstance().Media.Count();
                Console.Write("Adding Medium:");
                AAMediumManager.GetInstance().Media[i-1].Show();

                counter++;
                Thread.Sleep(500);

            } while (Thread.CurrentThread.IsAlive);
        }
        public static void MakeTVs()
        {

            do
            {

                AAMediumManager.GetInstance().AddMedium(new AATV("TV", 50 + AATV.Count));
                int i = AAMediumManager.GetInstance().Media.Count();
                Console.Write("Adding TV:");
                AAMediumManager.GetInstance().Media[i - 1].Show();

                Thread.Sleep(1000);



            } while (Thread.CurrentThread.IsAlive);


        }
        public static void ShowAndRemove(int millis)
        {

            Thread.Sleep((int)millis);
            AAMediumManager.GetInstance().ShowAll();

            AAMediumManager.GetInstance().RemoveFirstMedium();
            AAMediumManager.GetInstance().RemoveFirstMedium();

         


        }


    }
}
