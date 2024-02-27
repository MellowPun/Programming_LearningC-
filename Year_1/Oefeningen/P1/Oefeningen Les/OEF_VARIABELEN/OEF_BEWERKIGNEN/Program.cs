using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace OEF_BEWERKIGNEN
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////OEF 1

            //int euroAmount;

            //int exchangeRate = 1173;
            ////ask the user for an amount to exchange
            //Console.WriteLine("How much euros do you want to change into dollar?: ");
            //int.TryParse(Console.ReadLine(), out euroAmount);
            //int dollarAmount = (euroAmount * exchangeRate) / 1000;
            //Console.WriteLine("The dollar amount is {0}", dollarAmount);

            ////OEF 2

            //int firstNumber = 3;
            //int secondNumber = 8;
            //int result = firstNumber + secondNumber;
            //result += 10;

            //Console.WriteLine("Result is {0}", result);

            ////OEF 3
            //double firstNumber = 3.3;
            //double secondNumber = 8.8;
            //double result = firstNumber + secondNumber;
            //Console.WriteLine(result);


            ////OEF 4

            //Console.WriteLine("Give me 5 numbers:");
            //int.TryParse(Console.ReadLine(), out int firstNumber);
            //int.TryParse(Console.ReadLine(), out int secondNumber);
            //int.TryParse(Console.ReadLine(), out int thirdNumber);
            //int.TryParse(Console.ReadLine(), out int fourthNumber);
            //int.TryParse(Console.ReadLine(), out int fifthNumber);
            //double numberAverage;
            //numberAverage = (firstNumber + secondNumber + thirdNumber + fourthNumber + fifthNumber) / 5;
            //Console.WriteLine(numberAverage);

            ////OEF 5
            //int celsius;
            //Console.WriteLine("How many Celsius do you want to convert to Fahrenheit?: ");
            //int.TryParse(Console.ReadLine(), out celsius);
            //double fahrenheit = (9 / 5) * celsius + 32;
            //Console.WriteLine("A Tempertaure of {0} degrees Celsius corresponds to {1} degrees Fahrenheit", celsius, fahrenheit);

            ////OEF 6
            //double prices;
            //Console.WriteLine("How much does the product costs excl.TAV: ");
            //bool parseSucceded = double.TryParse(Console.ReadLine(), out prices);
            //if (!parseSucceded)
            //{
            //    Console.WriteLine("You've put in a invalid number");
            //}
            //else
            //{
            //    double pricesTAV = prices * 1.21;
            //    pricesTAV = Math.Round(pricesTAV, 2);
            //    Console.WriteLine("The amount TAV incl is: {0}", pricesTAV);
            //}

            ////OEF 7

            ////Ask the user for all amounts of food.
            //Console.WriteLine("How many mussels, Queenmeal, ice cream & drinks were ordered: ");
            //int.TryParse(Console.ReadLine(), out int adult);
            //int.TryParse(Console.ReadLine(), out int child);
            //int.TryParse(Console.ReadLine(), out int iceCream);
            //int.TryParse(Console.ReadLine(), out int drinks);
            //int total = (adult * 20) + (10 * child) + (3 * iceCream) + (2 * drinks);
            //Console.WriteLine("The total amount is {0}", total);

            ////OEF8

            ////ask the users for the amount of adults & childre
            //Console.WriteLine("How many adults & children are there(first amount of adults then children):");
            //int.TryParse(Console.ReadLine(), out int adult);
            //int.TryParse(Console.ReadLine(), out int child);
            //int total = (adult * 30) + (child * 15);
            //Console.WriteLine("For {0} adult & {1} children you will have to pay {2} euros", adult, child, total);

            ////OEF9
            //Console.WriteLine("Wat is het huidige jaartal");
            //int.TryParse(Console.ReadLine(), out int currentYear);
            //Console.WriteLine("Wat is uw geboortedatum");
            //int.TryParse(Console.ReadLine(), out int birthYear);
            //int yearsOld = currentYear - birthYear;
            //Console.WriteLine("Je bent {0} jaar oud.", yearsOld);

            ////OEF10

            //Console.WriteLine("What is your full name:");
            //string fullName = Console.ReadLine();
            //Console.WriteLine("How long is your last name:");
            //int.TryParse(Console.ReadLine(), out int lengthName);
            ////How to know the legnth of a string = string.Length

            //int startingPoint = fullName.Length - lengthName;
            ////substring is where the computer will start to read the string
            ////You can have 1 number--> to know where to start or 2 --> so that you can read a couple of letters (see other exercise)

            //Console.WriteLine(fullName.Substring(startingPoint - 1));


            ////OEF11
            //int weekHours = 168;

            //Console.Write("How many hours of schoolcourses do you have a week? ");
            //int.TryParse(Console.ReadLine(), out int amountCourses);
            //Console.WriteLine("How many hours do you work a week?");
            //int.TryParse(Console.ReadLine(), out int amountWork);
            //Console.Write("How many hours do you sleep on average a day? ");
            //int.TryParse(Console.ReadLine(), out int amountSleep);

            //int freeTimeWeek = weekHours - (amountSleep * 7) - amountCourses - (amountCourses / 2) - amountWork;
            //int freeTimeDay = freeTimeWeek / 7;
            //Console.WriteLine("You have {0} hours of freetime a week or {1} hours of freetime a day!!", freeTimeWeek, freeTimeDay);

            ////OEF 12 
            //Console.WriteLine("Give me a number");
            //int.TryParse(Console.ReadLine(), out int secondsInput);
            ////amount of hours 
            //int hours = secondsInput / 3600;
            //int secondsRemainingInHour = secondsInput % 3600;
            //int minutes = secondsRemainingInHour / 60;
            //int seconds = secondsInput % 60;


            //Console.WriteLine("{0}:{1}:{2}", hours, minutes, seconds);

            ////OEF14

            //double answer = Math.Pow(2, 125);
            //Console.WriteLine(answer);

            ////OEF15
            ////Math.Round(x,Y)=> Y is getallen na de komma

            //Console.WriteLine("Give me a number");
            //int.TryParse(Console.ReadLine(), out int input);
            //double inputMath = Math.Round(Math.Sqrt(input), 3);
            //Console.WriteLine(inputMath);

            ////OEF16 

            //Console.WriteLine("Gimme a number");
            //int.TryParse(Console.ReadLine(), out int value);
            //// double y= (double)1/3; heb je nodig voor komma getallen berekenen.
            //double valueEx = Math.Pow(value, (double)1 / 3);
            //Console.WriteLine(valueEx);

            //OEF17
            Console.WriteLine("gimme number");
            double.TryParse(Console.ReadLine(), out double value);
            double answer = Math.Round(Math.Sqrt(value), 2);
            Console.WriteLine(answer);


            Console.ReadKey();
            ////OEF18
            //Console.WriteLine("Geef de papegaai wat text:");
            //// lees text
            //string input = Console.ReadLine();
            ////text naar hoofdletters
            //input = input.ToUpper();
            ////text laten zien in hoofdletters
            //Console.WriteLine(input);
            //// klinkers verwisselen naar iets anders
            //string noVowels = input.Replace("A", "");
            //noVowels = input.Replace("E", "");
            //noVowels = noVowels.Replace("I", "");
            //noVowels = noVowels.Replace("O", "");
            //noVowels = noVowels.Replace("U", "");
            //noVowels = noVowels.ToLower();
            //Console.WriteLine(noVowels);
            //string moreString = input.Replace(" ", " I Want A Cracker ");
            //Console.WriteLine(moreString);

            ////OEF19
            //Console.WriteLine("What is your name? (second name, first name)");
            //string name = Console.ReadLine();
            //Console.WriteLine("What is the length of your second name?");
            //int.TryParse(Console.ReadLine(), out int lengthName);
            //string nameFirst = name.Substring(0, lengthName + 1);
            //string nameSwitch = name.Substring(lengthName + 1);
            //Console.WriteLine(nameFirst + nameSwitch);
            //Console.WriteLine(nameSwitch + " " + nameFirst);

            ////OEF21
            ////Important for using special characters
            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Console.WriteLine("Give me some text:");
            //string input = Console.ReadLine();
            //string specialInput = input.Replace(" ", "❤ ☀ ☆ ☂ ☻ ♞ ☯ ☭ ☢ €");
            //Console.WriteLine(specialInput);

            ////OEF 22
            //Console.Write("Give me 2 numbers: ");


            //int.TryParse(Console.ReadLine(), out int numberFirst);
            //int.TryParse(Console.ReadLine(), out int numberSecond);
            //bool parseSucceeded = numberFirst < numberSecond;
            //Console.WriteLine(parseSucceeded);
            ////Console.WriteLine(numberFirst<numberSecond); then there is no need for booleains

            ////OEF23
            //Console.WriteLine("Give me a time (hh:mm:ss)");
            //string time = Console.ReadLine();
            //int index = time.IndexOf(":");

            //string timeinHours = time.Substring(0, index);
            //string timeFromHours = time.Substring(index + 1);

            //string timeinMinutes = timeFromHours.Substring(0, index);
            //string timeFromMinutes = timeFromHours.Substring(index + 1);

            //string timeinSeconds = timeFromMinutes.Substring(0, index);

            //int hours, minutes, seconds;
            //int.TryParse(timeinHours, out hours);
            //int.TryParse(timeinMinutes, out minutes);
            //int.TryParse(timeinSeconds, out seconds);
            //int result = (hours * 3600) + (minutes * 60) + seconds;
            //Console.WriteLine(result);


            ////OEF EXTRA
            //Console.Write("name:");
            //string name = Console.ReadLine();
            ////bij substring 
            //Console.WriteLine(name.Substring(0, 2));

            ////OEF EXTRA EXAMEN 
            ////Character kunnen verplaatsen van iemands naam

            //Console.Write("Give me a your name: ");
            //string inputCharacter = Console.ReadLine();
            //Console.Write("How many places do the characters shift? ");
            //int.TryParse(Console.ReadLine(), out int shiftInput);
            ////ElementAt zorgt ervoor dat charachter neemt dat op bepaalde plaats staat
            ////(int) zorgt ervoor dat een bepaalde variabele veranderd in een integer 
            ////(char) zorgt ervoor dat een variabele veranderd naar een char.
            //char currentChar;
            //currentChar = inputCharacter.ElementAt(0);
            //int charAsNumber = (int)currentChar;
            //charAsNumber += shiftInput;
            //Console.WriteLine((char)charAsNumber);

            //currentChar = inputCharacter.ElementAt(1);
            //charAsNumber = (int)currentChar;
            //charAsNumber += shiftInput;
            //Console.WriteLine((char)charAsNumber);

            //currentChar = inputCharacter.ElementAt(2);
            //charAsNumber = (int)currentChar;
            //charAsNumber += shiftInput;
            //Console.WriteLine((char)charAsNumber);

            //currentChar = inputCharacter.ElementAt(3);
            //charAsNumber = (int)currentChar;
            //charAsNumber += shiftInput;
            //Console.WriteLine((char)charAsNumber);

            //currentChar = inputCharacter.ElementAt(4);
            //charAsNumber = (int)currentChar;
            //charAsNumber += shiftInput;
            //Console.WriteLine((char)charAsNumber);

            //currentChar = inputCharacter.ElementAt(inputCharacter.Length - 1);
            //Console.WriteLine((int)currentChar);





            //Console.WriteLine("Press any button to quit");
            //Console.ReadKey();


        }
    }
}
