using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOText_OEF
{
    internal class Program
    {
        static string fileName = "animal.txt";
        static void Main(string[] args)
        {
            ////Example Course
            //StreamWriter writer = new StreamWriter("Test.txt");
            ////extention doesn't matter for example txt , word etc in StreamWriter
            ////map word teruggevonden in "bin"

            //writer.WriteLine("Hello ");
            //writer.WriteLine("and ");
            //writer.WriteLine("welcome!");
            //writer.Close();



            //////ConsoleWrite(@"C:\test");
            ////// als je een @voor string schrijft dan werk \t \n etc niet meer 
            //StreamReader reader = new StreamReader("Test.txt");
            //string line = null;
            //do
            //{
            //    //line = reader.ReadToEnd();
            //    //Console.Write(line);
            //    line = reader.ReadLine();



            //    if(line != null)
            //    {
            //        Console.WriteLine(line);
            //    }



            //}while(line != null);

            //reader.Close();

            //Example serialization write

            Person personDavid = new Person();
            personDavid.Name = "David";
            personDavid.Age = 45;
            personDavid.HairColor = "Brown";
            personDavid.City = "Ghent";

            Person personPieter = new Person();
            personPieter.Name = "Pieter";
            personPieter.Age = 44;
            personPieter.HairColor = "Blond";
            personPieter.City = "Sint-Niklaas";

            List<Person> personList = new List<Person>();
            personList.Add(personDavid);
            personList.Add(personPieter);


            string jSonData = JsonConvert.SerializeObject(personDavid);

            File.WriteAllText("data.json", jSonData);

            //Example serialization read

            string jSonData = File.ReadAllText("data.json");
            List<Person> retrieveData = JsonConvert.DeserializeObject<List<Person>>(jSonData);

            foreach (Person person in retrieveData)
            {
                Console.WriteLine(person.Name);
            }

            ////OEF1 

            //ConsoleSettings consoleSettings = new ConsoleSettings();

            //consoleSettings.ForegroundColor = ConsoleColor.Red;
            //consoleSettings.BackgroundColor = ConsoleColor.Green;
            //consoleSettings.AmountOfStartUpBeeps = 13;


            //string jsonData = JsonConvert.SerializeObject(consoleSettings);
            //File.WriteAllText("ConsoleSettings.json", jsonData);



            //string readJsonData = File.ReadAllText("ConsoleSettings.json");
            //ConsoleSettings retrievedData = JsonConvert.DeserializeObject<ConsoleSettings>(readJsonData);
            //Console.ForegroundColor= retrievedData.ForegroundColor;
            //Console.BackgroundColor= retrievedData.BackgroundColor;

            //Console.WriteLine("helloWorld");

            ////OEF 1.B
            //ConsoleSettings consoleSettingsFirst = new ConsoleSettings();

            //consoleSettingsFirst.ForegroundColor = ConsoleColor.White;
            //consoleSettingsFirst.BackgroundColor = ConsoleColor.Red;    
            //consoleSettingsFirst.AmountOfStartUpBeeps = 1;

            //ConsoleSettings consoleSettingsSecond = new ConsoleSettings();

            //consoleSettingsSecond.ForegroundColor = ConsoleColor.Green;
            //consoleSettingsSecond.BackgroundColor = ConsoleColor.Blue;
            //consoleSettingsSecond.AmountOfStartUpBeeps = 2;

            //List<ConsoleSettings> settingsList = new List<ConsoleSettings>();
            //settingsList.Add(consoleSettingsFirst);
            //settingsList.Add(consoleSettingsSecond);

            //string jsonData = JsonConvert.SerializeObject(settingsList);
            //File.WriteAllText("settings.json", jsonData);

            //string readJsonData = File.ReadAllText("settings.json");

            //List<ConsoleSettings> retrievedData = JsonConvert.DeserializeObject<List<ConsoleSettings>>(readJsonData);
            //for(int i = 0; i < retrievedData.Count; i++)
            //{
            //    Console.WriteLine(retrievedData[i].ForegroundColor);
            //    Console.WriteLine(retrievedData[i].BackgroundColor);
            //    Console.WriteLine(retrievedData[i].AmountOfStartUpBeeps);
            //}

            //Console.WriteLine("Which color do you want. Press the corresponding number");
            //int.TryParse(Console.ReadLine(), out int userInput);
            //Console.ForegroundColor = retrievedData[userInput -1].ForegroundColor;
            //Console.BackgroundColor = retrievedData[userInput -1].BackgroundColor;

            //Console.WriteLine("Hello world");


            ////OEF 2
            //Animal[] animals = new Animal[5];

            //animals[0] = new Animal("Tiger", 4);
            //animals[1] = new Animal("Lion", 4); 
            //animals[2] = new Animal("Spider",8);
            //animals[3] = new Animal("Kangorou", 2);
            //animals[4] = new Animal("Nemo",0);


            //WriteAnimalsInFile(animals);
            //ReadAnimals();
            //foreach (var animal  in ReadAnimals())
            //{
            //    Console.WriteLine(animal);
            //}



            Console.ReadKey();

        }

        static void WriteAnimalsInFile(Animal[] animals) 
        {
            string jsonAnimal = JsonConvert.SerializeObject(animals);
            File.WriteAllText(fileName, jsonAnimal);



        }

        static Animal[] ReadAnimals()
        {
            string readJson = File.ReadAllText(fileName);
            Animal[] retrievedAnimals = JsonConvert.DeserializeObject<Animal[]>(readJson);

            return retrievedAnimals;
        }

    }
}
