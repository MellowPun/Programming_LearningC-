using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_oef
{
    internal class Program
    {
        static void Main(string[] args)
        {

            ////example
            ////verkorte versie
            ////string[] studentnames = { "pieter", "david", "joppe" };

            //string[] studentnames = new string[3];
            //studentnames[0] = "david";
            //studentnames[1] = "pieter";
            //studentnames[2] = "joppe";

            //Array.Sort(studentnames);
            //Array.Reverse(studentnames);


            //for (int i = 0; i < studentnames.Length; i++)
            //{
            //    Console.WriteLine(studentnames[i]);
            //    Console.WriteLine("length of previous name is: " + studentnames[i].Length);
            //}

            ////EXAMPLE

            //int[] numberArray = new int[20];
            //Random randomGenerator = new Random();
            ////Random buiten een loop anders wordt het dezelfde cijfers gebruikt die "random" zijn


            //// als aangeroepen word gaat het van 1 naar 100 niet naar 101

            //for (int i = 0; i < numberArray.Length; i++)
            //{
            //    numberArray[i] = randomGenerator.Next(1, 101);
            //    Console.WriteLine(numberArray[i]);
            //}
            ////Console.WriteLine(numberArray[20]);
            ////is niet mogelijk 20 bestaat niet telt vanaf 0 niet 1 

            //string name = "Ayoub";

            //char myChar1 = name.ElementAt(0);
            //char myChar2 = name[0];
            ////is hetzelfde ge gebruikt gwn een array hiervoor

            //EXAMEPLE

            int[,] myTwoDimensialArray = new int[4, 5];
            Random random = new Random();
            Console.WriteLine(myTwoDimensialArray.Length);
            Console.WriteLine("Row: {0}, Columns: {1}",
                myTwoDimensialArray.GetLength(0),
                myTwoDimensialArray.GetLength(1));

            for (int row = 0; row < myTwoDimensialArray.GetLength(0); row++)
            {
                for (int columns = 0; columns < myTwoDimensialArray.GetLength(1); columns++)
                {
                    myTwoDimensialArray[row, columns] = random.Next(1, 10);
                    Console.Write(myTwoDimensialArray[row, columns] + "\t");
                }
                Console.WriteLine();
            }


            ////OEF 1
            //int length = 10; 
            //int[] numberArray = new int [length];

            //for(int i=0 ; i < length; i++)
            //{
            //    Console.WriteLine("Enter a number");
            //    int.TryParse(Console.ReadLine(), out numberArray[i]);

            //}

            //Array.Reverse(numberArray);

            //for(int i=0; i < length; i++)
            //{
            //    Console.WriteLine(numberArray[i]);
            //}

            ////OEF 3 
            //int[] numberArray = new int[20];
            //Random randomGenerator = new Random();
            //int counter = 0;
            //Console.Write("Enter a number between 1 & 5: ");
            //int.TryParse(Console.ReadLine(), out int inputNumber);

            //for (int i = 0; i < numberArray.Length; i++)
            //{
            //    numberArray[i] = randomGenerator.Next(1, 6);
            //    if (numberArray[i] == inputNumber)
            //    {
            //        counter++;
            //    }
            //    Console.WriteLine(numberArray[i]);
            //}
            //Console.WriteLine("the number {0} has come " + counter + "times", inputNumber);

            ////OEF EXAMPLE  FOREACH

            //int[] intArray = { 1, 2, 3, 4, 5,6 };
            //// hanteert de volgorde dat het getypt word.

            //foreach(int i in intArray)
            //{
            //    Console.WriteLine(i);
            //}

            ////OEF 1 

            //int length = 4;
            //int[] intArray = new int[length];
            //for(int i=0; i < length; i++)
            //{
            //    Console.Write("Enter a number please:");
            //    intArray[i] = int.Parse(Console.ReadLine());

            //}

            //Array.Reverse(intArray);
            //foreach(int item in intArray)
            //{
            //    Console.WriteLine(item);
            //}

            ////OEF 5
            //string input = "lepel";
            //int length = input.Length / 2;
            //bool wordIsPalindrome = true;
            //for(int i = 0; i < length; i++)
            //{
            //    if (input[i] != input[input.Length - (i+1)])
            //    {
            //        wordIsPalindrome = false;
            //    }

            //}

            ////OEF 3 WITH FOREACH

            //int[] myArray = new int[20];
            //Random randomgeneratior = new Random();
            //int counter = 0;
            //Console.Write("Enter a number between 1 and 5: ");
            //int.TryParse(Console.ReadLine(), out int userInput);

            //for(int i=0; i<myArray.Length; i++)
            //{
            //    myArray[i] = randomgeneratior.Next(1, 6);
            //}

            //foreach(int currentInt in myArray)
            //{
            //    Console.WriteLine(currentInt);
            //    if(currentInt == userInput)
            //    {
            //        counter++;
            //    }
            //}

            ////OEF 10
            //int length = 5;
            //int[] array1, array2, array3;
            //array1 = new int[length];
            //array2 = new int[length];
            //array3 = new int[length];

            //Random random = new Random();

            //for(int i = 0; i < length; i++)
            //{
            //    array1[i] = random.Next(0, 11);
            //    array2[i] = random.Next(0, 11);
            //    array3[i] = array1[i] + array2[i];
            //}


            Console.WriteLine("Press any key to quit.");
            Console.ReadKey();

        }
    }
}
