using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Opdracht_Assesmblies;

namespace DLL
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //OEF Circle Dia 25
            Random rnd = new Random();
            List<Circle_dll> list = new List<Circle_dll>();
            Console.WriteLine(Circle_dll.AmountCircles);
            for (int i = 0; i < 1; i++) 
            {
                
                list.Add(new Circle_dll(rnd.Next(0, 21)));
            }
            Console.WriteLine(Circle_dll.AmountCircles);

            foreach (Circle_dll circle in list)
            {
                Console.WriteLine("Straal: {0}, Oppervlakte: {1}, Omtrek:{2}",circle.Radius, circle.Surface,circle.Circumference);
            }
            int x = 20;

            Console.WriteLine("Circle with radius {0}, has circumfrence of {1}", x,Circle_dll.CircumferenceFormula(x)) ;

            //OEF Car Dia 26
            Car_dll c1 = new Car_dll("Mercedes",210,70000   );
            Car_dll c2 = new Car_dll("Lambo",450,10000000);
            Car_dll c3 = new Car_dll("RaceCarX",750,100000);

            Garage_dll g1 = new Garage_dll();

            g1.AddCar(c1);
            g1.AddCar(c2);
            g1.AddCar(c3);
            Console.WriteLine( g1.FastestCar(g1.Cars));
            Console.WriteLine(g1.TotalCost);
            Console.WriteLine();



            Console.ReadKey();
        }
    }
}
