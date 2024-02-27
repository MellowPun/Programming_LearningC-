using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Methods_Oef
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            ////OEF LES
            //HelloWorld();
            //int myMethodResult = AskUserForNumber("Please enter your age!");

            ////OEF 1

            //Console.WriteLine(SendTextBack("Give me text and I'll write it back"));

            ////OEF2
            //double NumberEntered = RoundingDouble("Give me a double");
            //Console.WriteLine(NumberEntered);


            ////OEF 3
            //CharacterShiftingLeft("Give me couple characters to shift to the left?");
            //CharacterShiftingRight("Give me couple character to shift to the right?");

            ////OEF 4
            //int num;
            //bool parseSucceeded = AskNumber(out num);

            //if (parseSucceeded)
            //{
            //    Console.WriteLine("Congrats" + num);
            //}
            //else
            //{
            //    Console.WriteLine("invalid num");
            //}

            ////OEF 5
            //int num = KeepAskingNumber();
            //Console.WriteLine("The number is " + num);

            ////OEF 7

            //int[] myArray = new int[10];

            //for (int i = 0; i < myArray.Length; i++)
            //{
            //    myArray[i] = (int)KeepAskingNumber("GIMME NUMBA");
            //}
            //foreach (int i in myArray)
            //{
            //    Console.WriteLine(i);
            //}

            ////OEF 8 EN 9
            //int result = 0;
            //int numberForArray = (int)KeepAskingNumber("How many numbers do you want in the array.");

            //int[] ArraySum = new int[numberForArray];
            //for (int i = 0; i < ArraySum.Length; i++)
            //{
            //    ArraySum[i] = (int)KeepAskingNumber("Give me a number!");
            //}

            //foreach (int i in ArraySum)
            //{
            //    result += i;

            //}
            //Console.WriteLine(result);

            ////OEF 10
            //int result;
            //bool isItEven = IsEven(out result);
            //if (isItEven)
            //{
            //    Console.WriteLine("YAY YOUR NUMBER " + result + " IS EVEN!");
            //}
            //else
            //{
            //    Console.WriteLine("Sadly your number " + result + " is not even :((");
            //}

            ////OEF 11
            //int num = 0;

            //Console.WriteLine(AddOne(num));

            ////OEF 12
            //double result = KeepAskingNumber("Give me a measurment in Centimetres that you want converted into inches.");

            //Console.WriteLine(CmToInch(result) + " inch");

            ////OEF 13
            //double result = KeepAskingNumber("Give me number so I could give you the volume of a cube.");
            //Console.WriteLine(CalculateCubeVolume(result));

            ////OEF 14

            //double numberFirst = KeepAskingNumber("Give me a first number");
            //double numberSecond = KeepAskingNumber("Give me a second number");
            //Console.WriteLine(Smallest((int)numberFirst, (int)numberSecond));

            ////OEF 15

            //Console.WriteLine( TimeDiffInSec(1, 1, 1, 1, 1, 1));

            ////OEF 16
            //Console.WriteLine("Give me a word");
            //string first = Console.ReadLine();
            //Console.WriteLine("GIve me a second word");
            //string second = Console.ReadLine();
            //Console.WriteLine("GIve me a third word");
            //string third = Console.ReadLine();


            Console.WriteLine( AppendString(first, second, third));

            ////OEF 17
            //int[] myArray = { 1, 2, 3, 4, 5 };

            //Console.WriteLine( SumArray(myArray));

            ////OEF 18
            //int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //for(int i = 0; i < array.Length; i++)
            //{
            //    array[i] = AddOne(array[i]);

            //}
            //foreach(int i in array)
            //{
            //    Console.WriteLine(i);
            //}

            ////OEF 19

            //double[] myArray = { 1, 2, 3 };

            //double[] newArray = CmArrayToInchArray(myArray);
            //foreach (double value in newArray)
            //{
            //    Console.WriteLine(value);
            //}

            ////OEF 20
            //string word = "word";

            //string[] newString = StringToArray(word);
            //foreach(string str in newString)
            //{
            //    Console.WriteLine(str);
            //}

            ////OEF 21
            //int[] myArray = { 1, 2, 3,4,5,6,7 };

            //Console.WriteLine(   HowMayAreEven(myArray));

            //OEF 22 IS HERHALING 

            ////OEF 23

            //double cm = 1;
            //double inch;
            //CmToInchSecond(cm, out inch);

            //Console.WriteLine(inch);

            //OEF 24 & 25 met ref dus niet te kennen

            ////OEF 26
            //int[] myArray = {1,2, 3, 4, 5};

            //int[] newArray;
            //int counter;
            //AddOneAndCountEven(myArray, out newArray,out counter);


            //foreach(int i in newArray)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(counter);

            //OEF 27 & 28 Herhaling van de oefening


            //OEF 29 
            Random rnd = new Random();
            GenerateDeck();



            EndApplication();
        }

        static int AskUserForNumber(string message)
        {
            bool parseSucceeded;
            //moet buiten do while omdat anders enkel bestaat tussen haakjes
            int result;
            do
            {
                Console.WriteLine(message);
                
                parseSucceeded = int.TryParse(Console.ReadLine(), out result);
            }
            while (!parseSucceeded);
            return result;
        }

        static void HelloWorld()
        {
            Console.WriteLine("Hello World!");
        }
        static void EndApplication()
        {
            Console.WriteLine("Press any Key to continue");
            Console.ReadKey();
        }

        static string SendTextBack(string message)
        {
            string input;

            Console.WriteLine(message);
            input = Console.ReadLine();
            return input ;
        } 
        
        static double RoundingDouble(string message)
        {
            bool parseSucceeded;
            double roundedDouble;
            do
            {
                Console.WriteLine(message);
                parseSucceeded = double.TryParse(Console.ReadLine(), out roundedDouble);


            } while (!parseSucceeded);

            Math.Ceiling(roundedDouble);
            int result = (int)roundedDouble;

            return result;
        }

        static void CharacterShiftingLeft(string message )
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            int lettersToLeft = 3;
            for(int i= 0;i<=input.Length-1; i++)
            {
                char character = input.ElementAt(i);
                int characterAsInt  = (int)character;
                int amountToDeduct = 65;
               if (characterAsInt >96)
               {
                    amountToDeduct = 97;
               }

               characterAsInt -= amountToDeduct;
                characterAsInt -= lettersToLeft;
                if (characterAsInt <0)
                {
                    amountToDeduct += 26;
                }
                
                characterAsInt += amountToDeduct;
                character = (char)characterAsInt;
                Console.Write(character);



            }
            Console.WriteLine(); 

        }
        static void CharacterShiftingRight(string message ) 
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            int lettersToRight = 3;
            for(int i  = 0;i<=input.Length-1; i++)
            {
                char character = input.ElementAt(i);
                int characterAsInt = (int)character;
                int amountToDeduct = 65;
                if (characterAsInt > 96)
                {
                    amountToDeduct = 97;
                }
                characterAsInt -= amountToDeduct;
                characterAsInt += lettersToRight;
                characterAsInt %= 26;
                characterAsInt += amountToDeduct;
                character = (char)characterAsInt;
                Console.Write(character);
            }
            Console.WriteLine();

        }

        static bool AskNumber (out int x) 
        {

            Console.WriteLine("Number");

            int result;
            if(int.TryParse(Console.ReadLine(), out result))
            {
                x = result;
                return true;

            }
            else
            {
                x = 0;
                return false;
            }

        }

        static double KeepAskingNumber(string message)
        {
            Console.WriteLine(message);
            bool parseSucceeded;
            double result;
            do
            {
                
                parseSucceeded = double.TryParse(Console.ReadLine(), out result);


            } while (!parseSucceeded);

            return result;
        }

        static bool IsEven(out int value)
        {

            bool parseSucceeded;
            int result;
            Console.WriteLine("give me a number");
            do
            {
                parseSucceeded = int.TryParse(Console.ReadLine(), out  result);
            } while (!parseSucceeded);
            int numberDivisibleBy2 = result % 2;
            if(numberDivisibleBy2 ==0)
            {
                value = result;
                return true;
            }
            else 
            {
                value = result;
                return false;
            }
        }

        static int AddOne(int value)
        {
            value += 1;
            
            return value;
        }

        static double CmToInch(double measurementInCentimetres)
        {
            measurementInCentimetres *= 0.394;
            return measurementInCentimetres;
        }

        static double CalculateCubeVolume(double cubeVolume)
        {
            cubeVolume = Math.Pow(cubeVolume, 3);
            return cubeVolume;
        }

        static int Smallest(int inputNumFirst, int inputNumSecond)
        {
            if (inputNumFirst < inputNumSecond)
            {
                return inputNumFirst;
            }
            else
            {
                return inputNumSecond;
            }
        }

        static int TimeDiffInSec(int firstHours, int firstMinutes, int firstSeconds, int secondHours, int secondMinutes, int secondSeconds)
        {
            firstHours *= 60 * 60;
            firstMinutes *= 60;
            int firstTimeSpanResult = firstHours + firstMinutes+ firstSeconds;

            secondHours *= 60 * 60;
            secondMinutes *= 60;
            int secondTimeSpanResult = secondHours + secondMinutes+ secondSeconds;
            int result;
            if(secondTimeSpanResult < firstTimeSpanResult)
            {
                result = firstTimeSpanResult - secondTimeSpanResult;
                return result;
            }
            else
            {
                result = secondTimeSpanResult - firstTimeSpanResult;
                return result;
            }
            
            
            
        }

        static string AppendString(string first, string second, string third)
        {
            return first + " "+second + " "+third;
        }

        static int SumArray(int[] array)
        {
            int result = 0;
            foreach (int i in array)
            {
                result += i;
            }
            return result;
        }

        static double[] CmArrayToInchArray(double[] array)
        {
            double[] myNewArray = new double[array.Length];
            for(int i  = 0; i < array.Length; i++)
            {
                myNewArray[i] = CmToInch(array[i]);
            }
            return myNewArray;
        }

        static string[] StringToArray(string str)
        {

            string[] charactersSplitUp = new string[str.Length];
            for(int i=0; i<str.Length; i++)
            {
                charactersSplitUp[i] = str.Substring(i,1).Trim();
                
            }

            return charactersSplitUp;
        }

        static int HowMayAreEven(int[] array)
        {
            int counter = 0;
            for (int i=0; i<array.Length; i++)
            {
                
                int j = array[i]%2;
                if (j== 0)
                {
                    counter++;
                }
                
            }

            return counter;
        }

        static void CmToInchSecond(double cm, out double inch)
        {
            inch = cm * 0.394;
        }

        static void AddOneAndCountEven(int[] array,out int[]newArray, out int isEven)
        {
            int counter = 0;
            int[] copyArray = new int[array.Length];
           for(int i = 0; i<array.Length;i++)
            {
                int j = array[i]%2;
                if (j== 0)
                {
                    counter++;
                }
            }
           for(int i = 0; i < array.Length; i++)
            {
                copyArray[i] = array[i] - 1;

            }
            isEven = counter;
            newArray = copyArray;
        }

        static string GenerateDeck()
        {
            string[] myCards = new string[52];
            string cardTypeDefinite= "ERROR";

            for (int i = 0; i < myCards.Length; i++)
            {
                GenerateCardString(out int cardTypeMethod, out int cardNumberMethod);

                switch (cardTypeMethod)
                {
                    case 1:
                        cardTypeDefinite = "H";
                        break;

                        case 2:
                        cardTypeDefinite = "C";
                        break;

                        case 3:
                        cardTypeDefinite = "D";
                        break;

                        case 4:
                        cardTypeDefinite = "S";
                        break;

                }

                myCards[i]= cardTypeDefinite + cardNumberMethod;
                Console.WriteLine(myCards[i]);
            }



            return "nothing found";
        }
        static int GenerateCardString(out int cardType, out int cardNumber)
        {

            Random rnd = new Random();
            cardType = rnd.Next(1, 5);
            cardNumber = rnd.Next(1, 14);
            


            return 0;
        }
        
    }
}
