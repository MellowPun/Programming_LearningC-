using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OEF_IF_CONDITIONS
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //string.CompareTo(string); als letters gelijk zijn dan is dat 0
            //                          als str1 < str2 dan dan result <0
            // ||  betekent or in BOOL
            // && betekent en in BOOL
            // ! betekent niet  in BOOL

            ////OEF 1
            //Console.Write("What is your birthyear: ");
            //bool parseSucceeded = int.TryParse(Console.ReadLine(), out int birthYear);
            //int result = DateTime.Now.Year - birthYear;
            //if (birthYear>DateTime.Now.Year)
            //{
            //    Console.WriteLine("Je bent nog niet geboren");
            //}
            //else
            //{
            //    if(result<18)
            //    {
            //        Console.WriteLine("Om deel te nemen aan de verkiezingen moet je minimum 18 jaar oud zijn.");
            //    }
            //    else
            //    {
            //        birthYear= DateTime.Now.Year - birthYear;
            //        Console.WriteLine("Je bent {0} jaar oud",birthYear);


            //    }
            //}

            ////OEF 3

            //Console.WriteLine("Give me 2 names:");
            //string nameFirst = Console.ReadLine();
            //string nameSecond = Console.ReadLine();
            //nameFirst = nameFirst.ToLower();
            //nameSecond = nameSecond.ToLower();
            //int result = nameFirst.CompareTo(nameSecond);
            //if (result<0)
            //{
            //    Console.WriteLine("TRUE");
            //}
            //else
            //{
            //    Console.WriteLine("FALSE");
            //}

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

            ////OEF 4 
            //Console.WriteLine("How many pairs of shoes do you want to buy?");
            //bool parseSucceeded = int.TryParse(Console.ReadLine(), out int pairShoes);
            //int price = 100;
            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            //if (!parseSucceeded|| pairShoes<0)
            //{
            //    Console.WriteLine("You have put in a invalid number!");

            //}
            //else
            //{
            //    if(pairShoes>= 2)
            //    {
            //        double result = (price * pairShoes) * 0.75;

            //        Console.WriteLine("The price for the shoes is {0}€", Math.Round(result,2));

            //    }
            //    else
            //    {
            //        Console.WriteLine("You have bought 1 pair of shoes that is {0}€",price);
            //    }
            //}

            ////OEF 5
            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Console.Write("How many pairs of shoes do you want to buy? ");
            //bool parseSucceeded = int.TryParse(Console.ReadLine(), out int pairsShoes);
            //int priceShoes = 125;
            //double result;
            //if(parseSucceeded)
            //{
            //    if(pairsShoes < 0)
            //    {
            //        Console.WriteLine("Number is negative");
            //    }
            //    else
            //    {
            //        if(pairsShoes <2)
            //        {
            //             result = (priceShoes * pairsShoes) * 0.80;
            //            Console.WriteLine("price is " + result);
            //        }
            //        else
            //        {
            //            if(pairsShoes ==2)
            //            {
            //                 result = (priceShoes * pairsShoes) * 0.60;
            //                Console.WriteLine("price is " + result);
            //            }
            //            else
            //            {
            //                 result = (priceShoes * pairsShoes) *.40 ;
            //                Console.WriteLine("price is " + result);
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Write a number");
            //}

            ////OEF 6 
            //Console.WriteLine("Can you give me 5 of your exam results (out of 100)");
            //bool f =
            //int.TryParse(Console.ReadLine(), out int examFirst);
            //bool f2 =
            //int.TryParse(Console.ReadLine(), out int examSecond);
            //bool f3 =
            //int.TryParse(Console.ReadLine(), out int examThird);
            //bool f4 =
            //int.TryParse(Console.ReadLine(), out int examFourth);
            //bool f5 =
            //int.TryParse(Console.ReadLine(), out int examFive);
            //double average = (examFirst + examSecond + examThird + examFourth + examFive) / 5;
            //if (f && f2 && f3 && f4 && f5)
            //{
            //    if (average >= 50 && examFirst < 50 && examSecond >= 50 && examThird >= 50 && examFourth >= 50 && examFive >= 50)
            //    {
            //        Console.WriteLine("Win1:ExamResult" + average);
            //    }
            //    else
            //    {
            //        if (average >= 50 && examFirst >= 50 && examSecond < 50 && examThird >= 50 && examFourth >= 50 && examFive >= 50)
            //        {
            //            Console.WriteLine("Win2:ExamResult" + average);
            //        }
            //        else
            //        {
            //            if (average >= 50 && examFirst >= 50 && examSecond >= 50 && examThird < 50 && examFourth >= 50 && examFive >= 50)
            //            {
            //                Console.WriteLine("Win3:ExamResult" + average);
            //            }
            //            else
            //            {
            //                if (average >= 50 && examFirst >= 50 && examSecond >= 50 && examThird >= 50 && examFourth < 50 && examFive >= 50)
            //                {
            //                    Console.WriteLine("Win4:ExamResult" + average);
            //                }
            //                else
            //                {
            //                    if (average >= 50 && examFirst >= 50 && examSecond >= 50 && examThird >= 50 && examFourth >= 50 && examFive < 50)
            //                    {
            //                        Console.WriteLine("Win5:ExamResult" + average);
            //                    }
            //                    else
            //                    {
            //                        if (average >= 50 && examFirst >= 50 && examSecond >= 50 && examThird >= 50 && examFourth >= 50 && examFive >= 50)
            //                        {
            //                            Console.WriteLine("TOTALWIn: ExamResult" + average);
            //                        }
            //                        else
            //                        {
            //                            Console.WriteLine("FAILED");
            //                        }
            //                    }
            //                }
            //            }
            //        }





            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Write a number");
            //}

            ////OEF 7
            //Console.WriteLine("Give me a year: ");
            //int.TryParse(Console.ReadLine(), out int yearInput);

            //int inputForFour = yearInput % 4;
            //int result = yearInput % 100;
            //int schrikkelJaar =yearInput%400;

            //if ((inputForFour==0&& result != 0)||(inputForFour==0&&schrikkelJaar==0))
            //{


            //    Console.WriteLine("Dit is een schrikkeljaar");


            //}
            //else
            //{
            //    Console.WriteLine("Dit is geen schrikkeljaar");
            //}

            ////OEF 8
            //Console.WriteLine("How old are you?");
            //bool parseSucceeded = int.TryParse(Console.ReadLine(), out int yearInput);
            //if (!parseSucceeded || yearInput<0)
            //{
            //    Console.WriteLine("Not a valid number");
            //}
            //else
            //{
            //    int membershipFee = 10;
            //    if (yearInput <= 26)
            //    {
            //        membershipFee = 5;
            //    }
            //    Console.WriteLine("Membership"+ membershipFee);
            //}

            ////OEF 9
            //Console.WriteLine("Give me 2 names: ");
            //string nameFirst = Console.ReadLine().ToLower();
            //string nameSecond = Console.ReadLine().ToLower();
            //int compare= nameFirst.CompareTo(nameSecond);
            //if (compare < 0)
            //{
            //    Console.WriteLine(nameFirst +"<"+nameSecond);


            //    Console.WriteLine("WOWIEEE");
            //}
            //if (compare > 0)
            //{
            //    Console.WriteLine(nameSecond + "<" + nameFirst);
            //}

            ////OEF 10
            //Console.WriteLine("How old are you?");
            //double price = 13.7;
            //int.TryParse(Console.ReadLine(), out int age);
            //if (age < 5 || age > 55)
            //{
            //    price = 0;
            //    Console.WriteLine("Price is: "+price);
            //}
            //else
            //{
            //    if (age>=5&&age<=12)
            //    {
            //        price /= 2;
            //        Console.WriteLine("Price is "+price);
            //    }
            //    else
            //    {
            //        if (age>=13&&age<=55)
            //        {
            //            Console.WriteLine("Price is "+price);
            //        }
            //    }
            //}

            //OEF 11 I DONT KNOW SHIT
            Console.WriteLine("Do you want to calculate the circumference or the surface(C or S): ");
            string letter = Console.ReadLine();
            Console.WriteLine("Hoe groot is de straal? ");
            int.TryParse(Console.ReadLine(), out int diameter);
            double x = Math.PI;
            if(letter == "c")
            {

            }
            else if(letter == "d")  
            if (diameter < 0)
            {
                Console.WriteLine("Give a positive number!");
            }
            else
            {

            }

            // //Oef in les
            // string fullName;

            // int lengthCharacters;

            // //ask the user for a full name(first & last name)


            //Console.WriteLine("What is your full name?");
            // fullName = Console.ReadLine();

            // //aske the user for a length of the last name's last word


            //Console.WriteLine("How many characters does your last name have?");
            // //bool gebruiken om resultaat van tryparse te checken als er geen cijfer is duidelijk maken da persoon opfuckt
            // //is eig gwn een bug wegwerken
            // bool parseSucceeded =

            //     int.TryParse(Console.ReadLine(), out lengthCharacters);

            // if (parseSucceeded)
            // {
            //     int startingIndex = fullName.Length - lengthCharacters;
            //     Console.WriteLine(fullName.Substring(startingIndex));
            // }
            // else
            // {
            //     Console.WriteLine("You did not enter a recognizable number.");
            // }


            // /* Substring geeft de hoeveelheid tekens die je indient tussen de haakjes*/
            // //extract the last word from the full name





            Console.WriteLine("Press any button to quit.");
            Console.ReadKey();



            
        }
    }
}
