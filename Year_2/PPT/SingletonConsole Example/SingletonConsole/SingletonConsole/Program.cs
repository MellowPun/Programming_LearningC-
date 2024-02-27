using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace SingletonConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            Console.WriteLine();
            NumPrinter numPrint = new NumPrinter(100);
            AlphaPrinter alphaPrint = new AlphaPrinter();
            numPrint.Start();
            alphaPrint.Start();
            bool stopLoop = false;

            sw.Start();
            while(!stopLoop)
            {
                if(sw.ElapsedMilliseconds > 50000)
                {
                    stopLoop = true;
                    numPrint.Stop();
                    alphaPrint.Stop();
                }
                else
                {
                    Thread.Sleep(20);
                    switch (Console.ReadKey().KeyChar)
                    {
                        case 'n':
                            {
                                numPrint.FlipPause();
                                break;
                            }
                        case 'a':
                            {
                                alphaPrint.FlipPause();
                                break;
                            }
                        case 'p':
                            {
                                alphaPrint.FlipPause();
                                numPrint.FlipPause();
                                break;
                            }
                        case 's':
                            {
                                numPrint.Stop();
                                alphaPrint.Stop();
                                stopLoop = true;
                                break;
                            }
                    }
                }
                
               
            }
            Console.WriteLine("Press any key to quit..");
            Console.ReadKey();
        }
    }
}
