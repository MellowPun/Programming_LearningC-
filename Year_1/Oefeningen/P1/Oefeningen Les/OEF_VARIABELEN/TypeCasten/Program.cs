using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasten
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////OEF 1
            //Console.Write("Give me 3 numbers:");
            //int.TryParse(Console.ReadLine(), out int numberFirst);
            //int.TryParse(Console.ReadLine(), out int numberSecond);
            //int.TryParse(Console.ReadLine(), out int numberThird);

            //int sum = numberFirst + numberSecond + numberThird;
            //double result = (double)sum / 3;
            //Console.WriteLine(result);
            //Console.WriteLine((int)result);


            ////OEF 2 
            //Console.WriteLine("Give me a lower case character: ");
            //char.TryParse(Console.ReadLine(), out char lowerCaseChar);
            //int charInNumber = (int)lowerCaseChar;
            //charInNumber -= 97;
            //charInNumber += 65;
            //Console.WriteLine((char)charInNumber);


            //OEF 3
            Console.Write("Give me a decimal number:");
            double.TryParse(Console.ReadLine(), out double number);
            Console.WriteLine((int)number);
            Console.WriteLine(Math.Round(number,1));
            Console.WriteLine(Math.Ceiling(number));
            Console.WriteLine(Math.Floor(number));

            ////OEF 4
            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Console.WriteLine("Give me a round number:");
            //int.TryParse(Console.ReadLine(), out int number);
            ////char numberInChar = (char)number; KAN ERBIJ MAAR IS NIET NODIG
            //Console.WriteLine((char)number);

            ////OEF 5
            //Console.OutputEncoding = System.Text.Encoding.UTF8;
            //Console.WriteLine("Give me a character: ");
            //char.TryParse(Console.ReadLine(), out char charInput);
            //Console.WriteLine((int)charInput);

            ////OEF 6
            //// IMPORTANTE EXAM
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




            Console.WriteLine("Press any button to quit!");
            Console.ReadKey();


        }
    }
}
