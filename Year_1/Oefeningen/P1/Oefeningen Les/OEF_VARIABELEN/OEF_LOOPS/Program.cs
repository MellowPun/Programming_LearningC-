using System;
using System.Linq;

namespace OEF_LOOPS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////OEF 1 
            //int number = 0;
            //while(number<=100)
            //{
            //    Console.WriteLine(number);
            //    number += 2;
            //}

            ////OEF 2 
            //int number = 0;
            //Console.WriteLine("Give me a number:");
            //int.TryParse(Console.ReadLine(), out int inputNumber);

            //while(number<=10)
            //{
            //    int result = inputNumber* number;
            //    Console.WriteLine("{0} * {1} = {2} ",number,inputNumber,result);
            //    number++;
            //}

            ////OEF 3

            //int firstNumber = 1;
            //string textInput = "Ik vergeef de ander zijn schuld!";
            //int secondNumber = 1;
            //while (firstNumber<=7)
            //{


            //    secondNumber = 1;
            //    while (secondNumber<=70)
            //    {

            //        Console.WriteLine(textInput+secondNumber + "  "+ firstNumber);
            //        secondNumber++;

            //    }
            //    firstNumber++;
            //}

            ////OEF 4
            //int number;
            //bool parseSucceeded;
            //do
            //{
            //    Console.WriteLine("Give me a positive number");
            //    parseSucceeded = int.TryParse(Console.ReadLine(), out number);

            //    int result = 0;
            //    while (result <= number)
            //    {

            //        Console.WriteLine(result);
            //        result++;

            //    }

            //}
            //while (!parseSucceeded);


            ////OEF 5

            //int i = 0;
            //int j = 0;
            //int enter = 6;
            //int nextToEachother = 1;
            //char letter = '*';
            //while (i < enter)
            //{
            //    while (j < nextToEachother)
            //    {
            //        Console.Write(letter);
            //        j++;
            //    }
            //    i++;
            //    Console.WriteLine();
            //    j = 0;
            //    nextToEachother++;
            //}

            ////OEF 6.1

            ////if statement gebruiken  in col zodat cijfers gezien worden als * of omgekeerd
            //int row = 0;
            //int col= 0;

            //while (row<=5)
            //{

            //    while(col<=5)
            //    {
            //        if (col <= row)
            //        {
            //            Console.Write(col);
            //        }
            //        else
            //        {
            //            Console.Write("*");
            //        }
            //        col++;
            //    }
            //    row++;
            //    col=0;
            //    Console.WriteLine();
            //}

            ////OEF 6.2
            //int row = 0;
            //int col = 0;
            //int i = 4;
            //while (row <= 4)
            //{
            //    while (col <= 4)
            //    {
            //        if (col < i)
            //        {
            //            Console.Write("*");
            //            col++;
            //        }
            //        else
            //        {
            //            Console.Write(row+1);
            //            col++;

            //        }

            //    }
            //    col = 0;
            //    i--;
            //    row++;
            //    Console.WriteLine();
            //}

            //OEF 6.3
            int row = 0;
            int col = 0;
            int i = 1;
            int j;
            while (row < 5)
            {
                while (col < 10)
                {

                    if ()
                    {

                    }
                    else
                    {

                    }

                }
                Console.WriteLine();
                i += 2;
                col = 0;
                row++;
            }



            ////OEF 7
            //Console.WriteLine("Write a number to calculate");
            //int.TryParse(Console.ReadLine(), out int number);
            //int i = 1;
            //int result = number;

            //while (i<number)
            //{
            //    result *=i;
            //    i++;
            //}

            //Console.WriteLine(result);

            ////OEF 8 
            //uint yearInput;
            //uint yearInputTwo;
            //bool parseSucceeded;
            //bool parseSucceededTwo;

            //do
            //{
            //    Console.WriteLine("Give me 2 years after christ");
            //    parseSucceeded = uint.TryParse(Console.ReadLine(), out yearInput);
            //    parseSucceededTwo = uint.TryParse(Console.ReadLine(), out yearInputTwo);

            //}
            //while (!parseSucceeded && !parseSucceededTwo);


            //while (yearInput <= yearInputTwo)
            //{
            //    uint inputforfour = yearInput % 4;
            //    uint result = yearInput % 100;
            //    uint schrikkeljaar = yearInput % 400;
            //    if ((inputforfour == 0 && result != 0) || (inputforfour == 0 && schrikkeljaar == 0))
            //    {
            //        Console.WriteLine(yearInput);
            //    }
            //    yearInput++;
            //}


            //////OEF 9

            //int number=0;
            //bool parseSucceeded=true;
            //string answer;
            //int sum=0;
            //do
            //{
            //    Console.WriteLine("Give me a number");
            //    int.TryParse(Console.ReadLine(), out number);
            //    sum+=number;
            //    Console.WriteLine(sum);

            //    Console.WriteLine("a. voer nog een getal in.");
            //    Console.WriteLine("b. begin opnieuw.");
            //    Console.WriteLine("c. eindig het programma");
            //    answer = Console.ReadLine().ToLower();

            //switch (answer)
            //{
            //    case "a":

            //        break;
            //    case "b":
            //            sum = 0;
            //        break;
            //    case "c":
            //            parseSucceeded= false;

            //        break;

            //}
            //}while (parseSucceeded);

            ////OEF 10 
            //bool parseSucceeded;
            //int number;
            //int result = 0;
            //do
            //{
            //    Console.WriteLine("Give me a number or press Enter when not wanting to add anymore:");
            //    parseSucceeded = int.TryParse(Console.ReadLine(), out number);
            //    result += number;


            //}
            //while (parseSucceeded);

            //Console.WriteLine(result);

            ////OEF 11
            //int number;
            //bool parseSucceeded;
            //double i=0;
            //double result;



            //do 
            //{
            //    Console.WriteLine("Buy a meal(1), a drink(2), a desert(3), nothing more(Enter):");
            //    parseSucceeded = int.TryParse(Console.ReadLine(), out number);

            //    switch (number)
            //    {
            //        case 1:
            //            result = 10;
            //            i += result;
            //            break;
            //        case 2:
            //            result = 1.5;
            //            i += result;
            //            break;
            //        case 3:
            //            result = 4;
            //            i+=result;
            //            break;

            //    }

            //}
            //while(parseSucceeded);

            //Console.WriteLine(i);


            ////OEF 12 CANNOT SOLVE
            //int number;
            //int i = 2;
            //int result=0;
            //Console.WriteLine("Give me a number: ");
            //int.TryParse(Console.ReadLine(), out number);
            //if (number == 0)
            //{
            //    Console.WriteLine("Dit is geen priemgetal");
            //}
            //else 
            //{
            //    while (result!=1)
            //    {
            //        result = number/i;
            //        i++;
            //    }
            //}


            ////OEF 13
            //int number = 1;
            //int numberTwo = 1;
            //int result=0;
            //Console.Write(number + "\t"); Console.Write(numberTwo + "\t");
            //while (result<= 514229)
            //{
            //    result = number + numberTwo;
            //    Console.Write(result + "\t");

            //    number= numberTwo;
            //    numberTwo= result;

            //}

            ////OEF 14
            //int number;
            //int i = 0;
            //int result;
            //Console.Write("Which number do you want multiply:");
            //int.TryParse(Console.ReadLine(), out number);
            //do
            //{
            //    result = number * i;
            //    Console.WriteLine(result);
            //    i++;
            //}
            //while (i<=10);



            ////OEF 15
            //Console.WriteLine("Give me a word: ");
            //string word = Console.ReadLine();
            //int i = 0;
            //int lengthString = word.Length;
            //while (i<lengthString)
            //{
            //    Console.WriteLine(word.ElementAt(i) + " " + (int)word.ElementAt(i));
            //    i++;
            //}




            Console.WriteLine("Press any button to quit");
            Console.ReadKey();
        }
    }
}
