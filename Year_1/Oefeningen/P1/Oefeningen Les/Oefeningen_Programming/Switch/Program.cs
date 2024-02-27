using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.XPath;

namespace Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////Oef 1 


            ////ask the user for a math sign 
            /////trim zorgt ervoor da spaties erna of ervoor weggaan
            //Console.Write("Please enter a math sign (+, -, *, / or %): ");
            //string userInputSign = Console.ReadLine().Trim();

            ////ask the user for 2 numbers, parse the user input
            //int intOne, intTwo;
            //Console.Write("Enter the first number: ");
            //int.TryParse(Console.ReadLine(), out intOne);

            //Console.Write("Enter the second number: ");
            //int.TryParse(Console.ReadLine(), out intTwo);

            ////perform calculation
            //bool correctSign;
            //double result;

            //switch (userInputSign)
            //{
            //    case "+":
            //        result = intOne + intTwo;
            //        break;
            //    case "-":
            //        result = intOne - intTwo;
            //        break;
            //    case "*":
            //        result = intOne * intTwo;
            //        break;
            //    case "/":
            //        result = intOne * intTwo;
            //        break;
            //    case "%":
            //        result = intOne % intTwo;
            //        break;
            //    default:
            //        result = double.MinValue;
            //        correctSign = false;
            //        Console.WriteLine("You did not enter a valid math sign");
            //        break;

            //}
            //if (correctSign)
            //{
            //    Console.WriteLine("The result is {0}", result);
            //}

            //oef 3 ER IS IETS VERKEERD

            //ask the user a number that represent a month 
            string monthName;
            Console.WriteLine("Please enter a month number: ");
            string userInput = Console.ReadLine();
            if (!int.TryParse(userInput, out int monthNumber))
            {
                Console.WriteLine("You did not enter a number");
            }
            else
            {
                switch (monthNumber)
                {
                    case 1:
                        monthName = "January";
                        break;

                    case 2:
                        monthName = "February";
                        break;
                    case 3:
                        monthName = "March";
                        break;
                    case 4:
                        monthName = "April";
                        break;
                    case 5:
                        monthName = "May";
                        break;
                    case 6:
                        monthName = "June";
                        break;
                    case 7:
                        monthName = "July";
                        break;
                    case 8:
                        monthName = "August";
                        break;
                    case 9:
                        monthName = "September";
                        break;
                    case 10:
                        monthName = "October";
                        break;
                    case 11:
                        monthName = "November";
                        break;
                    case 12:
                        monthName = "December";
                        break;
                    default:
                        monthName = string.Empty;
                        Console.WriteLine("You did not enter a number that corresponds to a month");
                        break;
                }


            ); Console.WriteLine("The month name is: {0}", monthName);
            }


            ////Oef 2

            ////step 1 what data do we need to keep/calculate
            //string dayInput;
            //int dayNumber;

            //// step 2 aske the user what I need from input
            //Console.WriteLine("voer de naam in van de dag van de week: ");
            //dayInput = Console.ReadLine();
            ////conver dayintput to lowercase


            ////check dayInput && set daynumber to corresponding value
            //switch (dayInput = dayInput.ToLower())
            //{
            //    case "monday":
            //        dayNumber = 1;
            //        break;
            //    case "tuesday":
            //        dayNumber = 2;
            //        break;
            //    case "wednesday":
            //        dayNumber = 3;
            //        break;
            //    case "thursday":
            //        dayNumber = 4;
            //        break;
            //    case "friday":
            //        dayNumber = 5;
            //        break;
            //    case "saturday":
            //        dayNumber = 6;
            //        break;
            //    case "sunday":
            //        dayNumber = 7;
            //        break;
            //    default:
            //        dayNumber = -1;
            //        break;


            //}
            //if (dayNumber != -1)
            //{
            //    Console.WriteLine("{0} komt overeen met waarde {1}", dayInput, dayNumber);
            //}
            //else
            //{
            //    Console.WriteLine("{0} is not a valid day.", dayInput);

            //}

            //Oef 5 NIET VOLLEDIG JUIST VERBETER WNR JE TIJD HEBT
            string inputAge;
            int age;
            string ageGroup;


            Console.WriteLine("Geef uw leeftijd in aub: ");
            inputAge = Console.ReadLine();
            bool parseSucceeded = int.TryParse(inputAge, out age);

            if (age >= 0 && age < 5)
            {
                ageGroup = "min5";
            }
            else
            {
                if (age >= 5 && age <= 12)
                {
                    ageGroup = "5to12";
                }
                else
                {
                    if (age >= 13 && age <= 55)
                        ageGroup = "13to55";
                    else
                    {
                        if (age > 55)
                        {
                            ageGroup = "55+";
                        }
                        else
                        {


                            ageGroup = "invalid";


                        }

                    }

                }

            }

            switch (ageGroup)
            {
                case "min5":
                    Console.WriteLine("Je mag gratis naar binnen");
                    break;
                case "5to12":
                    Console.WriteLine("Je mag binnen aan hakve prijs");
                    break;
                case "13to55":
                    Console.WriteLine("Je moet volle prijs betalen");
                    break;
                case "55+":
                    Console.WriteLine("Je mag gratis naar binnen");
                    break;
                case "invalid":
                    Console.WriteLine("Ongeldige leeftijd");
                    break;
                default:
                    Console.WriteLine("Je hebt iets verkeerds ingetypt");
                    break;
            }

            ////OEF 6

            //Random randomGenerator = new Random();
            //Console.OutputEncoding = Encoding.UTF8;
            //int amountOfShoes = randomGenerator.Next(1, 7);
            ////F2 gebruiken 
            //double discountFactor = 0;
            //switch (amountOfShoes)
            //{
            //    case 1:
            //        discountFactor = 0.8;
            //        break;
            //    case 2:
            //        discountFactor = 0.6;
            //        break;
            //    default:
            //        discountFactor = 0.4;
            //        break;

            //}

            //double totalPrice = (125*amountOfShoes)* discountFactor ;
            //Console.WriteLine("The total price is:{0}€", totalPrice);
            

            Console.WriteLine("Press any button to quit.");
            Console.ReadKey();
        }
    }
}
