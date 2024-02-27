using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Threads
{
    internal class Program
    {

        static readonly object locker = new object();
        static bool isRunning;
        static void Main(string[] args)
        {
            ////basics

            //Thread thread = new Thread(new ThreadStart(WriteShit));
            //thread.Start();
            //for(int i = 0; i < 1000; i++)
            //{
            //    Console.Write("Cock");
            //}


            ////Opdracht Dia 13
            //Thread threadA = new Thread(new ThreadStart(MethodA));
            //Thread threadB = new Thread(new ThreadStart(MethodB));
            //bool threadStarted;


            //threadA.Start();
            //threadB.Start();
            //threadB.Join(10);
            //threadB.Join();

            ////Opdracht Dia20

            //Thread threadA = new Thread(new ThreadStart(MethodLockA));
            //Thread threadB = new Thread(new ThreadStart(MethodLockB));

            //threadA.Start();
            //threadB.Start();

            //threadA.Join();
            //threadB.Join();

            ////Opdracht DIa22

            //Thread WriteA = new Thread(() => Print("Cock \' n ball torture"));
            //WriteA.Start();

            //Thread WriteB = new Thread(() => Print("Cock \' n ball Fantasy"));
            //WriteB.Start();

            //Thread WriteC = new Thread(() => Print("Cock \' n ball tickling"));
            //WriteC.Start();

            //WriteA.Join();
            //WriteB.Join();
            //WriteC.Join();

            //Opdracht Dia 23

            Thread ThreadA = new Thread(new ThreadStart(MethodLockA));
            Thread ThreadB = new Thread(new ThreadStart(MethodLockB));

            ThreadA.Start();
            ThreadB.Start();
            
            bool isThreading;

            isThreading = ThreadA.Join(50);


          
            
            ThreadB.Join();
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("Press any key to continue");

            Console.ReadKey();

        }
        static void WriteShit()
        {
            for(int i = 0;i < 10;i++)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Write("\'n balz");
            }
        }
        static void MethodA()
        {
            lock (locker)
            {


                for (int i = 1; i < 101; i++)
                {

                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.Write("a" + i + " ");
                        Thread.Sleep(100);
                    

                }
                Console.WriteLine();

            }
        }
        static void MethodB()
        {
            lock (locker)
            {
                for (int i = 1; i < 101; i++)
                {

                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.Write("b" + i + " ");
                    Thread.Sleep(100);

                }
                Console.WriteLine();
            }
        }
        static void MethodLockB()
        {
            
                for (int i = 1; i < 101&& isRunning ==true; i++)
                {
                lock (locker)
                {


                    Console.BackgroundColor = ConsoleColor.DarkCyan;
                    Console.Write("b" + i + " ");
                    Thread.Sleep(100);
                }


                }
                Console.WriteLine();
            
        }
        static void MethodLockA()
        {
            
                for (int i = 1; i < 101 && isRunning == true; i++)
                {
                lock (locker)
                {


                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.Write("a" + i + " ");
                    Thread.Sleep(100);
                }
                }
                Console.WriteLine();
            
        }

        static void Print(string message)
        {
            Console.WriteLine(message);
            Thread.Sleep (500);
        }


    }
}
