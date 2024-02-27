using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OEF_SWITCH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////OEF 1 
            //Console.WriteLine("Give me one of these symbols(+,-,*,/,%):");
            //string symbol = Console.ReadLine().Trim();
            //Console.WriteLine("Give me 2 numbers:");
            //int.TryParse(Console.ReadLine(), out int firstNumber);
            //int.TryParse(Console.ReadLine(), out int SecondNumber);

            //bool correctSign;
            //double result;
            //switch (symbol)
            //{
            //    case "+":
            //        result =firstNumber+SecondNumber;
            //        correctSign = true;
            //        break;
            //    case "-":
            //        result =firstNumber-SecondNumber;
            //        correctSign = true;
            //        break;
            //    case "*":
            //        result =firstNumber*SecondNumber;
            //        correctSign = true;
            //        break;
            //    case "/":
            //        result =firstNumber/SecondNumber;
            //        correctSign = true;
            //        break;
            //    case "%":
            //        result = firstNumber % SecondNumber;
            //        correctSign = true;
            //        break;
            //        default:
            //        result = double.MinValue;
            //        correctSign = false;
            //        Console.WriteLine("Not a valid math sign");
            //        break;
            //}
            //if (correctSign)
            //{
            //    Console.WriteLine("the rusult is "+ result);
            //}


            ////OEF 2
            //Console.WriteLine("Give me one of the weekdays: ");
            //string inputWeekday = Console.ReadLine().Trim().ToUpper();
            //int dayInput;
            //switch (inputWeekday)
            //{
            //    case "MONDAY":
            //        dayInput = 1;
            //        break;
            //    case "TUESDAY":
            //        dayInput=2;
            //        break;
            //    case "WEDNESDAY":
            //        dayInput = 3;
            //        break;
            //    case "THURSDAY":
            //        dayInput = 4;
            //        break;
            //    case "FRIDAY":
            //        dayInput = 5;
            //        break;
            //    case "SATURDAY":
            //        dayInput=6;
            //        break;
            //    case "SUNDAY":
            //        dayInput=7;
            //        break;
            //        default:
            //        dayInput = 0;
            //        break;

            //}
            //if (dayInput == 0)
            //{
            //    Console.WriteLine("You gave in {0}. That is not a weekday",inputWeekday);
            //}
            //else
            //{
            //    Console.WriteLine("You have in {0} the corresponding number is {1}",inputWeekday,dayInput);
            //}

            ////OEF 3
            //Console.WriteLine("Give a number from 1-12: ");
            //bool parseSucceeded = int.TryParse(Console.ReadLine(), out int inputNumber);
            //if (!parseSucceeded || inputNumber <1||inputNumber>12)
            //{
            //    Console.WriteLine("You have put in a invalid number");
            //}
            //else
            //{
            //    switch (inputNumber)
            //    {
            //        case 1:
            //            Console.WriteLine("january");
            //            break;
            //        case 2:
            //            Console.WriteLine("february");
            //            break;
            //        case 3:
            //            Console.WriteLine("march");
            //            break;
            //        case 4:
            //            Console.WriteLine("april");
            //            break;
            //        case 5:
            //            Console.WriteLine("march");
            //            break;
            //        case 6:
            //            Console.WriteLine("june");
            //            break;
            //        case 7:
            //            Console.WriteLine("july");
            //            break;
            //        case 8:
            //            Console.WriteLine("august");
            //            break;
            //        case 9:
            //            Console.WriteLine("september");
            //            break;
            //        case 10:
            //            Console.WriteLine("october");
            //            break;
            //        case 11:
            //            Console.WriteLine("novermbre");
            //            break;
            //        case 12:
            //            Console.WriteLine("december");
            //            break;


            //    }

            //}


            ////OEF 4
            //Console.WriteLine("Which language do you choose?(Dutch, German, English & French)");
            //string inputLanguage = Console.ReadLine().Trim().ToLower();
            //Console.WriteLine("Do you want to type something extra?");
            //string inputFareWell = Console.ReadLine().Trim().ToLower();
            //if (inputFareWell==string.Empty)
            //{
            //    switch (inputLanguage)
            //    {
            //        case "dutch":
            //            Console.WriteLine("Goeiedag");

            //            break;
            //        case "german":
            //            Console.WriteLine("Guten Tag");
            //            break;
            //        case "english":
            //            Console.WriteLine("Hello");
            //            break;
            //        case "French":
            //            Console.WriteLine("Bonjoer");
            //            break;
            //        default:
            //            inputLanguage = string.Empty;
            //            Console.WriteLine("You haven't put anything valuable in.");
            //            break;
            //    }

            //}
            //else
            //{
            //    switch (inputLanguage)
            //    {
            //        case "dutch":
            //            Console.WriteLine("Goeiedag");
            //            Console.WriteLine("Dag");

            //            break;
            //        case "german":
            //            Console.WriteLine("Guten Tag");
            //            Console.WriteLine("Tchüs");
            //            break;
            //        case "english":
            //            Console.WriteLine("Hello");
            //            Console.WriteLine("Bye");
            //            break;
            //        case "french":
            //            Console.WriteLine("Bonjoer");

            //            Console.WriteLine("au revoir");
            //            break;
            //        default:
            //            inputLanguage = string.Empty;
            //            Console.WriteLine("You haven't put anything valuable in.");
            //            break;
            //    }
            //}

            //OEF 5

            Console.WriteLine("How old are you? ");
            bool parseSucceeded = int.TryParse(Console.ReadLine(), out int ageInput);
            string ageGroup= ""; // type lege string
            if (parseSucceeded && ageInput >= 0)
            {
                if (ageInput < 5 || ageInput > 55)
                {
                    ageGroup = "free";

                }
                else
                {
                    if (ageInput >= 5 && ageInput <= 12)
                    {
                        ageGroup = "halfprice";
                    }
                    else
                    {
                        if (ageInput >= 13 && ageInput <= 55)
                        {
                            ageGroup = "fullprice";
                        }
                        
                    }
                }
            }
            else
            {
                ageGroup = "not number";
            }
            // ageGroup not defined so better defined 
            switch (ageGroup)
            {
                case "free":
                    Console.WriteLine("You are {0} year old, you can go in for free!", ageInput);
                    break;
                case "halfprice":
                    Console.WriteLine("You are {0} year old,you have to pay half price", ageInput);
                    break;
                case "fullprice":
                    Console.WriteLine("You are {0} year old,You have to pay full price", ageInput);
                    break;
                case "invalid":
                    Console.WriteLine("You have put in an invalid number");

                    break;
                case "not number":
                    Console.WriteLine("parse not succeeded");
                    break;
                default:
                    Console.WriteLine("You put in a invalid number my guy");
                    break;
            }


            ////OEF 6
            //Console.WriteLine("How many shoes will you buy.");
            //string inputShoesWord = Console.ReadLine();
            //int.TryParse(inputShoesWord, out int inputShoes);
            //int price = 125;
            //double result;
            //switch (inputShoesWord)
            //{

            //    case "0":
            //        result = inputShoes * price;
            //        break;
            //    case "1":
            //         result = (inputShoes * price) * 0.8;
            //        break;
            //    case "2":
            //        result = (inputShoes * price) * 0.6;
            //        break;
            //    case "3": 
            //        result = (inputShoes * price) * 0.4;
            //        break;

            //}




            Console.WriteLine("Press any key to quit");
            Console.ReadKey();

        }
    }
}
