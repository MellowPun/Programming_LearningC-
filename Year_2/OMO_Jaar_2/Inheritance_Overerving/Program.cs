using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_Overerving
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // protected elementen kunnen in child worden aangesproken
            // private elementen kunnen niet bij child worden aangesproken

            ////OEF 10


            //Random rnd = new Random();
            //Animal[,] animals = new Animal[5,4];

            //for (int i = 0; i < animals.GetLength(0); i++)
            //{

            //    for (int j = 0; j < animals.GetLength(1); j++)
            //    {

            //        int random = rnd.Next(0, 9);
            //        switch (random)
            //        {

            //            case 0:
            //                animals[i,j] = new Animal();
            //                break;

            //            case 1:
            //                animals[i, j] = new Fish("yellow");
            //                break;
            //            case 2:
            //                animals[i, j] = new Dog();
            //                break;
            //            case 3:
            //                animals[i, j] = new Animal(2000, false);
            //                break;

            //            case 4:
            //                animals[i, j] = new Fish("green");
            //                break;
            //            case 5:
            //                animals[i, j] = new Dog(7,false);
            //                break;
            //            case 6:
            //                animals[i, j] = new Animal(1, true);
            //                break;

            //            case 7:
            //                animals[i, j] = new Fish("golden");
            //                break;
            //            case 8:
            //                animals[i, j] = new Dog(10, true);
            //                break;
            //            default:
            //                Console.WriteLine("Nothing");
            //                break;

            //        }
            //    }

            //}


            //foreach (Animal animal in animals)
            //{
            //    Console.WriteLine(animal.ToString());
            //}

            ////OEF 11

            //List<Point> points = new List<Point>();

            //Point p1 = new Point();
            //Point p2 = new Point();
            //p2.AskCoordinates();

            //Dot d1 = new Dot();
            //Dot d2 = new Dot();
            //Dot d3 = new Dot();
            //d2.AskCoordinates();


            //d3.AskCoordinates();
            //d3.AskRadius();



            //points.Add(p1);
            //points.Add(p2);
            //points.Add(d1);
            //points.Add(d2);
            //points.Add(d3);

            //foreach (Point p in points)
            //{
            //    Console.WriteLine(p.ToString());
            //}

            //OEF 12 
            // Zie andere file voor oplossing

            ////OEF 13

            //Printer Memo = new Printer();
            //TabPrinter Receipt = new TabPrinter(5);

            //Memo.Print("This is a memo");
            //Receipt.Print("This is a receipt");

            ////e.
            //ColorPrinter BirthdayCards = new ColorPrinter((ConsoleColor)2, ConsoleColor.Blue);

            //BirthdayCards.Print("HappyBirthday");

            ////f.
            //CapsColorPrinter ExtremeBirthday = new CapsColorPrinter(ConsoleColor.Blue, ConsoleColor.Red);
            //ExtremeBirthday.Print("EXREME HAPPY BIRTHDAY");

            ////OEF 14
            //Mailbox o1 = new Mailbox("Ayoub");
            //Mailbox o2 = new Mailbox("Jolien");
            //Address a1 = new Address("TonyStraat", 19, 2650, "Edegem");
            //Address a2 = new Address("GijselStraat", 13, 2000, "Antwerpen");

            //Package p1 = new Package(a1, 5, "Google Pixel");
            //Package p2 = new Package(a2, 1, "Earrings");

            //Letter l1 = new Letter(a1, "Vanavond online?");
            //Letter l2 = new Letter(a2, "Theetje dinken morgen?");

            //o1.Post(p1);
            //o1.Post(l1);
            //o2.Post(l2);
            //o2.Post(p2);

            //o1.ToString();
            //o1.ToString();
            //o2.ToString();

            ////OEF 15
            //NightSky night = new NightSky(10, 10);
            //night.Print();






            Console.WriteLine("Press button to end");
            Console.ReadKey();

        }
    }
}
