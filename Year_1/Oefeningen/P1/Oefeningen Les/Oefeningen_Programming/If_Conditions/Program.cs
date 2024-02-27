using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //// Oef 1 

            //int age;
            //int birthYear;

            //// Instruct the user to enter an age

            //Console.Write("Please enter your birth year: ");
            //string userInput = Console.ReadLine();

            //// convert age as text to number
            //bool parseSucceeded = int.TryParse(userInput, out birthYear);

            //if(!parseSucceeded)
            //{
            //    // warn the user that an incorreect age was entered
            //    Console.WriteLine("You did not enter a valid number");
            //}
            //else
            //{
            //    age = DateTime.Now.Year - birthYear;
            //    if (age >= 18)
            //    {
            //        Console.WriteLine("You are {0} years old. You can vote!!", age);
            //    }
            //    else
            //    {
            //        if (birthYear > DateTime.Now.Year)
            //        {
            //            Console.WriteLine("Are you not born yet?");
            //        }
            //        else
            //        {
            //            Console.WriteLine("You are not 18 years old you are not old enough to vote ;/");
            //        }
            //    }
            //}


            //Console.WriteLine("Press any key to quit.");
            //Console.ReadKey();

            ////Oef 3

            //string firstUserName;
            //string secondUserName;
            //bool comparisonResult;

            ////ask user for two names
            //Console.WriteLine("Enter the first user name: ");
            //firstUserName = Console.ReadLine().ToLower();

            //Console.WriteLine("Enter the second user name: ");
            //secondUserName = Console.ReadLine().ToLower();

            //comparisonResult = firstUserName.CompareTo(secondUserName) < 0;
            //Console.WriteLine(comparisonResult);



            //Console.WriteLine("Press a button to quit.");
            //Console.ReadKey();

            ////Oef 4

            //// ask user how many shoe pairs they want to buy
            //// in opgave staat da ge moet waarschuwen da persoon negatief cijfer heeft geschreven ge moet da aanduiden dus docent meer juist

            //Console.WriteLine("How many shoes are you going to purchase");
            //bool parseSucceeded =
            //    uint.TryParse(Console.ReadLine(), out uint amountShoes);

            //if (parseSucceeded)
            //{
            //    if (amountShoes >= 2)
            //    {
            //        double resultEuros = (amountShoes * 100) * 0.75;
            //        Console.WriteLine("You need to pay {0} euros",resultEuros );

            //    }
            //    else
            //    {
            //        Console.WriteLine("For 1 pair of shoes you need to pay 100 euros.");
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("You did not put in a valid amount.");
            //}

            ////andere manier om opdracht te maken (docent)
            //Console.OutputEncoding = Encoding.UTF8;
            //Console.WriteLine("How many shoes are you going to purchase");
            //bool parseSucceeded =
            //    int.TryParse(Console.ReadLine(), out int amountShoes);
            //if (parseSucceeded)
            //{
            //    if (amountShoes<0)
            //    {
            //        Console.WriteLine("You must enter a positive number.");
            //    }
            //    else
            //    {
            //        double result=100*amountShoes;
            //        if (amountShoes>=2)
            //        {
            //            result *= 0.75;
            //        }
            //        Console.WriteLine("The total amount to pay is {0} ", result) ;
            //    }

            //}
            //else
            //{
            //    Console.WriteLine("You did not put in a number.");
            //}

            //// Oef in les
            //string fullName;

            //int lengthCharacters;

            //// ask the user for a full name (first & last name)

            //Console.WriteLine("What is your full name?");
            //fullName = Console.ReadLine();

            //// aske the user for a length of the last name's last word

            //Console.WriteLine("How many characters does your last name have?");
            //// bool gebruiken om resultaat van tryparse te checken als er geen cijfer is duidelijk maken da persoon opfuckt
            //// is eig gwn een bug wegwerken
            //bool parseSucceeded =

            //    int.TryParse(Console.ReadLine(), out lengthCharacters);

            //if (parseSucceeded)
            //{
            //    int startingIndex = fullName.Length - lengthCharacters;
            //    Console.WriteLine(fullName.Substring(startingIndex));
            //}
            //else
            //{
            //    Console.WriteLine("You did not enter a recognizable number.");
            //}


            ///* Substring geeft de hoeveelheid tekens die je indient tussen de haakjes*/
            //// extract the last word from the full name

            //Console.WriteLine("Press any key to quit");
            //Console.ReadKey();

            ////Oef 13 IMPORTANTE EXAM
            ///* int counter = 0;
            //counter++;
            //counter = counter % 10;
            //Console.WriteLine(counter);*/
            ////modulos oef begrijpen

            //Console.WriteLine("Enter a capital letter:");
            //string input = Console.ReadLine();
            //char myChar = input.ElementAt(0);
            //int charAsInt = (int)myChar;


            //int amountToDeduct = 65;
            //if (charAsInt > 96)
            //{
            //    amountToDeduct = 97;
            //}
            //charAsInt += 10;
            //charAsInt -= amountToDeduct;
            //charAsInt = charAsInt % 26;
            //charAsInt += amountToDeduct;
            //Console.WriteLine((char)charAsInt);

            ////Oef 8

            //Console.Write("How old are you?");
            //string inputYear = Console.ReadLine();
            ////checken dat t een cijfer is en niet een letter
            //bool parseSucceeded = int.TryParse(inputYear, out int age);
            ////als uitroepteken zorgt omkering van variabele(dus als t true is wordt t false als t false is wordt t true)


            //if (!parseSucceeded || age < 0)
            //{
            //    Console.WriteLine("This is not a valid number");
            //}
            //else
            //{
            //    int membershipFee = 10;


            //    if (age < 26)
            //    {
            //        membershipFee = 5;

            //    }
            //    Console.WriteLine("Je lidgeld is {0} euro.", membershipFee);
            //}

            ////0ef24

            //Console.WriteLine("Voer uw naam in: ");
            //string input = Console.ReadLine();
            //Console.WriteLine(input.Length);
            //Console.WriteLine(input.ToUpper());
            //Console.WriteLine(input.ToLower());

            //if (input.Length% 2 == 0)
            //{
            //    Console.WriteLine(input.Substring(0,3));
            //}
            //else
            //{
            //    // put length cuz if 5 letters it will be 5-3 so 2 letter 
            //    Console.WriteLine(input.Substring(input.Length -3));
            //}

            //Console.WriteLine("Press any key to end");
            //Console.ReadKey();



        }
    }
}
