using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Exercises
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            ////OEF 10 sub
            //Animal snake = new Animal(0, true);
            //Fish goldfish = new Fish("Gold");
            //Fish carp = new Fish("White");
            //Dog pomsky = new Dog(3, true);
            //Dog labrador = new Dog();

            //Animal[] animals = new Animal[5];
            //animals[0] = snake;
            //animals[1] = goldfish;
            //animals[2] = carp;
            //animals[3] = pomsky;
            //animals[4] = labrador;
            //foreach (Animal animal in animals)
            //{
            //    Console.WriteLine(animal);
            //}

            //OEF 12

            List<Disk> list = new List<Disk>();
            CD disk1 = new CD("De 3 biggetjes", 20, 5,18);
            DVD dvd1 = new DVD("Harry Potter",25, 10);
            CD disk2 = new CD("Metallica Black Album", 7, 3, 4);
            DVD dvd2 = new DVD("The Avengars", 4, 37);
            Games games1 = new Games("Valorant", 0, 21, (Pegi)12); //of Pegi.Plus12

            list.Add(disk1);
            list.Add(dvd1);
            list.Add(disk2);
            list.Add(dvd2);
            list.Add(games1);
            Console.WriteLine("The total stock count is {0} and the stock is worth {1}.", TotalStockCount(list), TotalStockPrice(list));
            
            foreach(Disk disk in list)
            {
                Console.WriteLine(disk);
            }
            Console.WriteLine("Press any button to continue!");
            Console.ReadKey();

        }
        static int TotalStockCount(List<Disk> stock)
        {
            int count = 0;
            foreach(Disk disk in stock)
            {
                count+=disk.Quantity;
            }
            return count;

        }
        static int TotalStockPrice(List<Disk> stock)
        {
            int price = 0;
            foreach (Disk disk in stock)
            {
                price += disk.Price*disk.Quantity;
            }
            return price;

        }
    }
}
