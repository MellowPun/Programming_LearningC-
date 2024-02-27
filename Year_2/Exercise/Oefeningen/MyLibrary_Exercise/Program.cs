using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLib;
using MyLib_Circle;
using Opdracht_Assesmblies;

namespace MyLibrary_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////OEF CIRCLE
            //Random rand = new Random();

            //Circle[] circles = new Circle[10];

            //Console.WriteLine("You have  {0} circles", Circle.NumCircles);

            //for (int i = 0; i < circles.Length; i++)
            //{
            //    int randomInteger = rand.Next(0, 21);
            //    circles[i] = new Circle(randomInteger);
            //}
            //Console.WriteLine("You have  {0} circles", Circle.NumCircles);
            //foreach (Circle circle in circles)
            //{
            //    Console.WriteLine("A circle with a radius of {0} has a circumfrence of {1} and a surface of {2}",circle.Radius,circle.Circumference,circle.Surface);
            //}

            //Console.WriteLine("Circle with radius 100 has a circumfrence of {0}.",Circle.CalculateCircumrence(100));
            //Console.WriteLine("Press any key to continue...");
            //Console.ReadKey();


            //OEF Car Dia 26
            Car_dll c1 = new Car_dll("Frozen", 210, 70000);
            Car_dll c2 = new Car_dll("Batman", 450, 10000000);
            Car_dll c3 = new Car_dll("Cocksucker", 750, 100000);

            Garage_dll g1 = new Garage_dll();

            g1.AddCar(c1);
            g1.AddCar(c2);
            g1.AddCar(c3);
            Console.WriteLine(g1.FastestCar(g1.Cars));
            Console.WriteLine(g1.TotalCost);
            Console.WriteLine();

            Console.ReadKey();


        }
    }
}
