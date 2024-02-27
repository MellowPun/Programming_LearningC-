using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace DataTypes
{
    class PrinterChar
    {
        protected char _CurrentChar = (char)0;
        protected bool isPaused = true;
        protected Thread printThread;
        protected bool hasEnded = false;

        public PrinterChar()
        {
            printThread = new Thread(new ThreadStart(LoopPrint));
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
                    Manager.GetInstance().WriteLine(((char)(97 + _CurrentChar)).ToString());
                    _CurrentChar = (char)((_CurrentChar+1)%26);
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
