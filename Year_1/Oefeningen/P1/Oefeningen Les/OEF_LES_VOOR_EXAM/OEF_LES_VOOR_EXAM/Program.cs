using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OEF_LES_VOOR_EXAM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string input = "07-maart-2022";

            //string dayPart = input.Substring(0, input.IndexOf("-"));
            ////index leest van 01234

            ////Substring(x,y);
            ////x is de start & y is de hoeveelheid tekens je kan oppakken
            ////substring & indexof start counting from 0;
            //input = input.Substring(input.IndexOf("-") + 1);
            //string monthPart = input.Substring(0, input.IndexOf("-"));
            //input = input.Substring(input.IndexOf("-") + 1);
            //string yearPart = input.Substring(input.IndexOf("-") + 1);
            //Console.WriteLine(dayPart);
            //Console.WriteLine(monthPart);
            //Console.WriteLine(yearPart);

            //Console.WriteLine(input);


            ////OEF EXTRA
            //string date = "28-12-2000";
            //int counter = 0;
            ////length gives length and doesnt start with 0 but 1
            //while (counter < date.Length)// of (counter != date.Length)
            //{
            //    Console.WriteLine(date.ElementAt(counter));
            //    counter++;

            //}

            //OEF EXTRA

            // best declaratie buiten haakjes 

            //int numberInput;
            //bool parseSucceeded;

            //do
            //{
            //    Console.Write("ENter a number :");
            //    parseSucceeded = int.TryParse(Console.ReadLine(), out  numberInput);

            //} while (parseSucceeded == false);

            //OEF EXTRA

            //int row = 0;
            //int col = 0;

            //while (row < 10)
            //{
            //    while (col < 10)
            //    {
            //        Console.Write(col);
            //        col++;

            //    }
            //    Console.WriteLine();
            //    row++;
            //    col=0;


            //}

            //OEF EXTRA

            //"casten" is hieronder: casten zorgt ervoor dat je alles afkapt.

            double number = 1.5;

            //double numberEquation = 100 / 3;
            // om een echte double te maken moet je oftewel een van de int een double van maken dus: 
            // double numberEquation = 100/3.0;
            // Of je maakt het een double door letter "d" erachter te zetten
            //double numberEquation = 100/3d;

            int caseNumber = (int)number;

            //conversie is hieronder : conversie zorgt ervoor dat je werkt met wiskunde afrondingen 

            int convertNumber = Convert.ToInt32(number);
            Console.WriteLine(convertNumber);

            ////OEF EXTRA;
            ////0 is altijd false, al de rest is juist.
            //int i=0;
            //bool convertedBoolean = Convert.ToBoolean(i);
            //Console.WriteLine(convertedBoolean);



            Console.WriteLine("Press any button to quit.");
            Console.ReadKey();
        }
    }
}
