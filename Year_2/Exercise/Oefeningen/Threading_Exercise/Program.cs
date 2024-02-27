using System;
using System.Diagnostics;
using System.Globalization;
using System.Threading;

namespace Threading_Exercise
{
    internal class Program
    {
        static bool isRunning = true;
        static object consoleLockness = new object();

        static void Main(string[] args)
        {
            //opdracht PPT
            Thread A = new Thread(new ThreadStart(MethodA));
            Thread B = new Thread(new ThreadStart(MethodB));

            A.Start();
            B.Start();

            A.Join();
            B.Join();
            //bool threadAIsDone , threadBIsDone;
            // threadAIsDone = A.Join(200);
            // threadBIsDone = B.Join(50);
            //threads moeten uitgespeeld met millis voordat de main word afgespeeld


            // zien welke threads joins er bezig zijn met de booleans.
            //Thread pakken een pauzez
            //if(!threadBIsDone)
            //{
            //    isRunning = false;
            //}

            //Thread worden gecancelled
            //A.Abort();
            Console.ForegroundColor = ConsoleColor.White;

            ////Opdracht Thread parameters
            //char inputFirst;
            //char inputSecond;
            //char inputThird;
            //char inputFourth;
            //char inputFive;


            //Console.WriteLine("Give me a letter");
            //char.TryParse(Console.ReadLine(), out inputFirst);
            //char.TryParse(Console.ReadLine(), out inputSecond);
            //char.TryParse(Console.ReadLine(), out inputThird);
            //char.TryParse(Console.ReadLine(), out inputFourth);
            //char.TryParse(Console.ReadLine(), out inputFive);

            //Thread firstLetter = new Thread(() => MethodPrint(inputFirst));
            //Thread secondLetter = new Thread(() => MethodPrint(inputSecond));
            //Thread thirdLetter = new Thread(() => MethodPrint(inputThird));
            //Thread fourthLetter = new Thread(() => MethodPrint(inputFourth));
            //Thread fifthLetter = new Thread(() => MethodPrint(inputFive));

            //firstLetter.Start();
            //firstLetter.Join();
            //secondLetter.Start();
            //secondLetter.Join();
            //thirdLetter.Start();
            //thirdLetter.Join();
            //fourthLetter.Start();
            //fourthLetter.Join();
            //fifthLetter.Start();
            //fifthLetter.Join();

            ////Opdracht thread in array DIT IS FOUT CHECK AGAIN slide 22


            //char[] input = new char[5];

            //Thread[] letters = new Thread[5];
            //Console.WriteLine("Give me a letter");
            //for (int i = 0; i < input.Length; i++)
            //{
            //    char.TryParse(Console.ReadLine(), out input[i]);
            //}
            ////Computer is zo snel dat het een error melding geeft 
            ////want werkt verder maar gebruikt lambda niet en gebruikt het daarna pas

            //for (int j = 0; j < letters.Length; j++)
            //{
            //    int errorAvoider = j;
            //    letters[j] = new Thread(() => MethodPrint(input[errorAvoider]));
            //    letters[j].Start();

            //}
            //for (int k = 0; k < letters.Length; k++)
            //{
            //    letters[k].Join();
            //}


            ////Opdracht Eerste thread programma Slide 23

            //Thread tA = new Thread(new ThreadStart(MethodLockedA));
            //Thread tB = new Thread(new ThreadStart(MethodLockedB));

            //tA.Start();
            //tB.Start();
            //tA.Join();
            //tB.Join();

            //Challenge








            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        static void MethodA()
        {
            for (int i = 1; i < 101 /*&& isRunning*/; i++)
            {
                lock (consoleLockness)
                {

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("A{0}", i);
                    //Thread.Sleep(20);
                }
            }

            Console.WriteLine();
        }

        static void MethodB()
        {
            for (int i = 1; i < 101/* && isRunning*/; i++)
            {
                lock (consoleLockness)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("B{0}", i);
                    //Thread.Sleep(50);
                }
            }
            Console.WriteLine();

        }
        static void MethodPrint(char output)
        {
            for(int i = 1; i < 101; i++)
            {
                lock (consoleLockness)
                {
                    Console.Write("{0}{1}",output, i);
                }
                
            }
            Console.WriteLine();

        }
        static void MethodLockedA()
        {
            lock (consoleLockness)
            {
                for (int i = 1; i < 101 /*&& isRunning*/; i++)
                {
                    

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("A{0}", i);
                        //Thread.Sleep(20);
                    
                }
                Console.WriteLine();
            }
        }
        static void MethodLockedB()
        {
            lock (consoleLockness)
            {
                for (int i = 1; i < 101/* && isRunning*/; i++)
                {

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("B{0}", i);
                    //Thread.Sleep(50);

                }
                Console.WriteLine();
            }
        }

    }
}
