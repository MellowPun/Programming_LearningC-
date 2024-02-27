using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Array_Oef
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            random.NextDouble();

            //zorgt voor random doubles


            ////oef 1
            //int[] inputArray = new int[10];
            //Console.WriteLine("Give me 10 numbers.");
            //for (int i = 0; i < inputArray.Length; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out inputArray[i]);

            //}
            //Array.Reverse(inputArray);
            ////for(int i = 0;i < inputArray.Length; i++)
            ////{
            ////    Console.WriteLine(inputArray[i]);
            ////}
            ////OR YOU CAN USE FOR EACH
            //foreach (int i in inputArray)
            //{
            //    Console.WriteLine(i);
            //}

            ////OEF 2

            //double[] inputArray = new double[5];
            //Console.WriteLine(" give me 5 decimal numbers");
            //for (int i = 0; i < inputArray.Length; i++)
            //{
            //    double.TryParse(Console.ReadLine(), out inputArray[i]);

            //}

            //Console.WriteLine("Which number do you want to see?");
            //int.TryParse(Console.ReadLine(), out int numberSeen);
            //numberSeen--;
            ////moet -- want telt vanaf 0 dus als persoon 4 tipt gaat t eig 5de zijn en niet 4de cijfers ingegeven

            //Console.WriteLine(inputArray[numberSeen]);

            ////OEF 3

            //int[] randomArray = new int[20];

            //Random rnd = new Random();
            //Console.WriteLine("Give me a number from 1 to 5");
            //int.TryParse(Console.ReadLine(), out int givenNumber);
            //int counter = 0;
            //for (int i = 0; i < randomArray.Length; i++)
            //{
            //    randomArray[i] = rnd.Next(1, 6);
            //    Console.WriteLine(randomArray[i]);
            //    if (randomArray[i] == givenNumber)
            //    {
            //        counter++;
            //    }
            //    // if statement direct in for loop is kortere versie
            //}


            //foreach (int i in randomArray)
            //{
            //    if (i == givenNumber)
            //    {
            //        counter++;
            //    }
            //}
            ////Lange versie
            //Console.WriteLine("number is " + counter);

            ////OEF 4

            //Console.WriteLine("Give 10 numbers");

            //int[] arrayNumber = new int[10];


            //for (int i = 0; i < arrayNumber.Length; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out arrayNumber[i]);

            //    if (arrayNumber[i] % 2 == 0)
            //    {
            //        Console.WriteLine(arrayNumber[i]);
            //    }
            //}

            ////OEF 5

            //string word = "negen";
            //int length = word.Length / 2;
            //bool ispalindroom = true;
            //for (int i = 0; i < length; i++)
            //{
            //    if (word[i] != word[word.Length - (i + 1)])
            //    {
            //        ispalindroom = false;
            //    }
            //}
            //Console.WriteLine(ispalindroom);

            ////OEF 6

            //Console.WriteLine("How many number do you want to save?");
            //int.TryParse(Console.ReadLine(), out int i);

            //int[] arrayAmount = new int[i];

            //Console.WriteLine("Which number do you wanna save?");
            //for (int j = 0; j < arrayAmount.Length; j++)
            //{
            //    int.TryParse(Console.ReadLine(), out arrayAmount[j]);
            //}
            //int averageSumary = 0;
            //foreach (int average in arrayAmount)
            //{
            //    averageSumary += average;
            //}
            //averageSumary /= arrayAmount.Length;
            //Array.Sort(arrayAmount);
            //int max = arrayAmount.Max();
            //int min = arrayAmount.Min();

            //Console.WriteLine("The average of these numbers are: {0}. ", averageSumary);
            //Console.Write("The max is {0}, the min is {1}", arrayAmount[i - 1], arrayAmount[0]);
            //Console.WriteLine(max + "\t" + min);

            ////OEF 7
            //Console.WriteLine("Give me 4 names?");
            //string[] arrayNames = new string[4];
            //for (int i = 0; i < arrayNames.Length; i++)
            //{
            //    arrayNames[i] = Console.ReadLine();
            //}
            //Array.Sort(arrayNames);
            //for (int i = 0; i < arrayNames.Length; i++)
            //{
            //    Console.WriteLine(arrayNames[i]);
            //}

            ////OEF 10

            //int[] arrayFirst = new int[5];
            //int[] arraySecond = new int[5];
            //int[] arraySum = new int[5];
            //Random rnd = new Random();

            ////int length = 5;
            ////int[] array1, array2, array3;
            ////array1 = new int[length];
            ////array2 = new int[length];
            ////array3 = new int[length];

            ////ook mogelijk om vershcillende arrays te maken


            //for (int i = 0; i < arrayFirst.Length; i++)
            //{
            //    arrayFirst[i] = rnd.Next(0, 11);
            //    arraySecond[i] = rnd.Next(0, 11);
            //    arraySum[i] = arrayFirst[i] + arraySecond[i];
            //    Console.WriteLine(arrayFirst[i] + "\t+\t" + arraySecond[i] + "\t=\t" + arraySum[i]);
            //}

            //OEF 11    VRAAGSTELLING NIET BEGRIJP
            //OEF 13    VRAAGSTELLING NIET BEGRIJP

            ////OEF 14 SHIFT TO LEFT

            //int[] arrayNumbers = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //foreach (int i in arrayNumbers)
            //{
            //    Console.Write(i+ " ");
            //}
            //int x = arrayNumbers[0];
            //for(int i = 0; i< arrayNumbers.Length-1;i++ ) 
            //{
            //    arrayNumbers[i] = arrayNumbers[i + 1];

            //}

            //arrayNumbers[arrayNumbers.Length - 1] = x;
            //Console.WriteLine();
            //foreach (int i in arrayNumbers)
            //{
            //    Console.Write(i + " ");
            //}


            ////OEF 15 NEIT OPGELOST
            //Random rnd = new Random();
            //int[,] bombs = new int[8, 10];



            //OEF LES

            int[,] myTwoDim = new int[4, 5];
            Console.WriteLine("Row: {0} & colums: {1}", myTwoDim.GetLength(0), myTwoDim.GetLength(1));

            for (int i = 0; i < myTwoDim.GetLength(0); i++)
            {

                for (int j = 0; j < myTwoDim.GetLength(1); j++)
                {
                    myTwoDim[i, j] = random.Next(1, 101);
                    Console.Write(myTwoDim[i, j] + "\t");

                }
                Console.WriteLine();

            }




            Console.ReadKey();

        }
    }
}
