using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Bewerkingen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Oef 2

            int firstNumber = 3;
            int secondNumber = 8;
            int result;
            result = firstNumber + secondNumber;
            Console.WriteLine("the sum of {0} and {1} is {2}", firstNumber, secondNumber, result);

            //Oef 3

            double firstNumber = 3.3;
            double secondNumber = 8.8;
            double result;
            result = firstNumber + secondNumber;
            Console.WriteLine("the sum of {0} and {1} is {2}.", firstNumber, secondNumber, result);

            //Oef 4

            Console.WriteLine("Give me 5 numbers: ");
            int.TryParse(Console.ReadLine(), out int resultFirst);
            int.TryParse(Console.ReadLine(), out int resultSecond);
            int.TryParse(Console.ReadLine(), out int resultThird);
            int.TryParse(Console.ReadLine(), out int resultFourth);
            int.TryParse(Console.ReadLine(), out int resultFive);
            double resultAverage;
            resultAverage = (resultFirst + resultSecond + resultThird + resultFourth + resultFive) / 5;
            Console.WriteLine("The average of those 5 numbers is {0}.", resultAverage);


            //Oef 5
            //ask the user for a degree in Celsius

            int celciusDegree;
            int fahrenheitDegree;

            Console.WriteLine("Put a degree in celcius so we can convert it to Fahrenheit: ");
            int.TryParse(Console.ReadLine(), out celciusDegree);

            //give the user the degree in Fahrenheit
            fahrenheitDegree = (9 / 5) * celciusDegree + 32;
            Console.WriteLine("A Temperature of {0} degrees Celsius corresponds to {1} degrees Fahrenheit.", celciusDegree, fahrenheitDegree);

            //Oef 6
            //ask the user for the price of the product excl. VAT
            Console.WriteLine("How much is the product excl. VAT: ");
            double.TryParse(Console.ReadLine(), out double priceExVat);
            //give the user the right price of the product
            double priceFull = priceExVat * 1.21;
            priceFull = Math.Round(priceFull, 2);
            Console.WriteLine("The price with the VAT is : {0}", priceFull);

            //Oef 7
            //ask the user how many fries were ordered
            Console.WriteLine("How many Fries were ordered: ");
            int.TryParse(Console.ReadLine(), out int orderFries);


            //ask the user how many queenmeals were ordered
            Console.WriteLine("How many queenmeals were ordered: ");
            int.TryParse(Console.ReadLine(), out int orderQueen);

            //ask the user how many ice creams were ordered
            Console.WriteLine("How many icecreams were ordered: ");
            int.TryParse(Console.ReadLine(), out int orderIce);

            //ask the user how many drinks they want
            Console.WriteLine("how many drinks were order: ");
            int.TryParse(Console.ReadLine(), out int orderDrink);
            //Give the user the right amount
            int result = (20 * orderFries) + (10 * orderQueen) + (3 * orderIce) + (2 * orderDrink);
            Console.WriteLine("The total amount is {0}", result);

            //Oef 8
            int fullGrownPrice = 30;
            int childPrice = 15;

            Console.Write("How many adults are present?");
            bool parseSucceededAdult = int.TryParse(Console.ReadLine(), out int adultPresent);
            Console.WriteLine("How many children are present?");
            bool parseSucceededChild = int.TryParse(Console.ReadLine(), out int childPresent);

            if (!parseSucceededChild || !parseSucceededAdult || adultPresent < 0 || childPresent < 0)
            {
                Console.WriteLine("The number is not valid");
            }
            else
            {
                int fullPrice = (adultPresent * fullGrownPrice) + (childPresent * childPrice);
                Console.WriteLine("The total amount to pay is {0}", fullPrice);
            }

            //Oef 9
            Console.WriteLine("What year are we in?");
            int.TryParse(Console.ReadLine(), out int currentYear);

            Console.WriteLine("WHat year were you born?");
            int.TryParse(Console.ReadLine(), out int bornYear);
            int currentAge = currentYear - bornYear;
            Console.WriteLine("You are {0} years old", currentAge);

            //Oef 10
            Console.WriteLine("What is your name?");
            string fullName = Console.ReadLine();

            Console.WriteLine("What is your last name's length?");
            int.TryParse(Console.ReadLine(), out int nameLength);
            int startingPoint = fullName.Length - nameLength;
            Console.WriteLine("Your last name is {0}", fullName.Substring(startingPoint));

            ////Oef 11

            //Oef 23


            Console.WriteLine("Please enter a timespan(hh:mm:ss): ");
            string input = Console.ReadLine();

            int index = input.IndexOf(":");

            //get hours part of string
            string timePartHours = input.Substring(0, index);
            string timePartFromHours = input.Substring(index+1);

            //get minutes part of string
            index = timePartFromHours.IndexOf(":");
            string timePartMinutes = timePartFromHours.Substring(0, index);

            //get seconds from original input string
            string timePartSeconds = input.Substring(input.Length - 2);
            
            //convert string to ints
            int hours, minutes, seconds;
            int.TryParse(timePartHours, out hours);
            int.TryParse(timePartMinutes, out minutes);
            int.TryParse(timePartSeconds, out seconds);
            //moet in (00:00:00) geschreven worden dus seconden moeten 01 getypt worden
            int result = (hours*3600)+ (minutes*60)+ seconds;
            Console.WriteLine(result);

            Console.WriteLine("Press any button to quit.");
            //Console.ReadKey();


            ////OEF EXTRA
            //Console.SetWindowSize(7, 7);
            //string rainbow = Rainbow;
            //Console.BackgroundColor = ConsoleColor.Red;
            //Console.WriteLine("Rainbow");
            //Console.BackgroundColor = ConsoleColor.DarkYellow;
            //Console.WriteLine("Rainbow");
            //Console.BackgroundColor = ConsoleColor.Yellow;
            //Console.WriteLine("Rainbow");
            //// om tekening te maken gebruikt van spaties 
            //Console.BackgroundColor = ConsoleColor.Red;

            //Console.Write("     ");

            //Console.BackgroundColor = ConsoleColor.DarkGreen;
            //Console.WriteLine("  ");

            //Console.ReadKey();
            //Console.ResetColor();
            //Console.SetWindowSize(100, 30);
            //Console.WriteLine("I am Ready");
            //Console.ReadKey();





        }

}
}
