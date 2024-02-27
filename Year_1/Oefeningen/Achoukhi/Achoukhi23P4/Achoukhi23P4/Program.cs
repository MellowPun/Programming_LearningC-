using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Achoukhi23P4
{
    internal class Program
    {
        //This is the exam made by Ayoub Achoukhi.
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Stay hotelStay = new Stay("Coolio", 3,0);
            Flight destinationFlight = new Flight(3.4,150.3,"Griekenland");
            Flight returnFlight= new Flight(2.2,150.6,"Nederland");
            Vacation summerVacation = new Vacation(hotelStay,VacationType.Hiking);
            string fileName = "Achoukhi.json";
            summerVacation.AddFlight(destinationFlight);
            summerVacation.AddFlight(returnFlight);

            string inputUser;



            do
            {
                Console.WriteLine("Press D to show full explanation.\n" +
                    "Press S to save information.\n" +
                    "Press L to load information. \n" +
                    "Press X to stop the application.\n");

                inputUser = Console.ReadLine().ToLower();

                switch(inputUser) 
                {
                    case "d":
                        Console.WriteLine(summerVacation);
                        Console.WriteLine();
                        break;

                    case "s":
                        SaveJSON(fileName,summerVacation);
                        Console.WriteLine();
                        break;

                    case "l":
                        summerVacation = LoadJSON(fileName);
                        Console.WriteLine();
                        break;
                }




            } while (inputUser != "x");



            

        }

        static void SaveJSON(string fileName, Vacation vacationString)
        {
            
            string jsonSaveData = JsonConvert.SerializeObject(vacationString);
            File.WriteAllText(fileName, jsonSaveData);

        }

        static Vacation LoadJSON(string fileName)
        {
            string jsonLoadData = File.ReadAllText(fileName);
            Vacation vacationData = JsonConvert.DeserializeObject<Vacation>(jsonLoadData);

            return vacationData;
        }
    }
}
