using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Singleton DIA 29
            Stopwatch sw = new Stopwatch();

            Console.WriteLine();

            PrinterNum numPrint = new PrinterNum(100);

            PrinterChar charPrint = new PrinterChar();
            numPrint.Start();
            charPrint.Start();

            bool stopLoop = false;

            sw.Start();
            while(!stopLoop)
            {
                if (sw.ElapsedMilliseconds > 500000) 
                {
                    stopLoop = true;
                    numPrint.Stop();
                    charPrint.Stop();
                }
                else
                {
                    Thread.Sleep(20);
                    switch(Console.ReadKey().KeyChar)
                    {
                        case 'n':
                            {
                                numPrint.FlipPause();
                                break;
                            }
                            case 'a':
                            {
                                charPrint.FlipPause();
                                break;
                            }

                        case 'p':
                            {
                                charPrint.FlipPause();
                                numPrint.FlipPause();

                                break;
                            }

                        case 's':
                            {
                                numPrint.Stop();
                                charPrint.Stop();
                                stopLoop = true;
                                break;
                            }


                    }
                }
            }
            Console.WriteLine("Press any key");
            Console.ReadKey();


        }
    }
}
