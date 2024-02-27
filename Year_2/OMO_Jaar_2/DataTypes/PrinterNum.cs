using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DataTypes
{
    internal class PrinterNum
    {
        protected int _CurrentNum = 0;
        protected int maxNum;
        protected bool isPaused = false;
        protected Thread printThread;
        protected bool hasEnded = false;


        public PrinterNum(int max)
        {
            printThread = new Thread(new ThreadStart(LoopPrint));

            maxNum = max;


        }
        public void Start()
        {
            isPaused = false; 
            printThread.Start();

        }

        public void FlipPause()
        {
            isPaused =! isPaused;
        }

        public void Stop()
        {
            hasEnded = true;
            if (printThread.IsAlive)
            {
                printThread.Abort();
            }
        }

        public void LoopPrint()
        {
            while(!hasEnded)
            {
                if(!isPaused)
                {
                    Manager.GetInstance().WriteLine(_CurrentNum.ToString());
                    _CurrentNum = (_CurrentNum + 1)%maxNum;
                    Thread.Sleep(500);
                }
                else
                {
                    Thread.Sleep(5);
                }
            }
        }






        

    }
    
}
