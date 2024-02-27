using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace SingletonConsole
{
    class NumPrinter
    {
        protected int currentNum = 0;
        protected int maxNum;
        protected bool isPaused = true;
        protected Thread printThread;
        protected bool hasEnded = false;

        public NumPrinter(int max)
        {
            printThread = new Thread(new ThreadStart(LoopPrint));
            maxNum = max;
            isPaused = false;
            hasEnded = false;
            currentNum = 0;
        }

        public void Start()
        {
            isPaused = false;
            printThread.Start();
        }
        public void FlipPause()
        {
            isPaused = !isPaused;
        }
        public void Stop()
        {
            hasEnded = true;
            if(printThread.IsAlive)
            {   
                printThread.Abort();
            }
        }

        public void LoopPrint()
        {   
            while(!hasEnded)
            {
                if (!isPaused)
                {
                    ConsoleManager.Instance.WriteLine(currentNum.ToString());
                    currentNum = (currentNum + 1) % maxNum;
                    Thread.Sleep(500);
                }
                else //when paused sleep 5 ms before checking again
                {
                    Thread.Sleep(20);
                }
            }
            
        }
    }
}
