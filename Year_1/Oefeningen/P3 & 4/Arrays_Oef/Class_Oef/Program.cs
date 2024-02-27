using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Class_Oef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////EXAMPLE COURSE
            //BossEnemy enemyBoss = new BossEnemy();


            //enemyBoss.HitPoints = 10;
            //enemyBoss.Name = "Big Bro";

            //BossEnemy enemyMinion = new BossEnemy();

            //enemyMinion.HitPoints = 3;
            //enemyMinion.Name = "Little Bro";


            ////Console.WriteLine(enemy);
            //////Gives the name space




            //enemyBoss.PairWithMinion(enemyMinion);

            //Console.WriteLine(enemyBoss);
            //Console.WriteLine(enemyMinion);

            ////OEF 3

            //int score;
            //Mission missionEscape = new Mission("Escape the simulation");
            //missionEscape.IntroText = "You have to get out of here or else!";
            //missionEscape.Outrotext = "you opened the door nice!";
            //missionEscape.PointsWhenCompleted = 23;

            //missionEscape.StartMission();
            //Console.WriteLine(missionEscape);
            //missionEscape.Complete(out score);
            //Console.WriteLine(missionEscape);
            //Console.WriteLine();

            //Mission missionImpossible = new Mission("Hide");
            //missionImpossible.IntroText = "Hide in this chamber somewhere anywhere";
            //missionImpossible.Outrotext = "That is a great hidding spot dude";
            //missionImpossible.PointsWhenCompleted = 45;

            //missionImpossible.StartMission();
            //Console.WriteLine(missionImpossible);
            //missionImpossible.Fail();
            //Console.WriteLine(missionImpossible);
            //Console.WriteLine();

            ////OEF 4

            //OEF4_LEERLINGEN studentFirst = new OEF4_LEERLINGEN();
            //studentFirst.FirstName = "Steve";
            //studentFirst.LastName = "Boby";
            //studentFirst.YearOfBirth = 2000;

            //Console.WriteLine(studentFirst);

            //OEF4_LEERLINGEN studentSecond = new OEF4_LEERLINGEN();
            //studentSecond.FirstName = "Coolio";
            //studentSecond.LastName = "Foolio";
            //studentSecond.YearOfBirth = 1994;

            //Console.WriteLine(studentSecond);

            //OEF4_LEERLINGEN studentThird = new OEF4_LEERLINGEN();
            //studentThird.FirstName = "Jolien";
            //studentThird.LastName = "Moris";
            //studentThird.YearOfBirth = 1995;

            //Console.WriteLine(studentThird);

            //////OEF 5
            //int objectsToCreate = 10;
            //Random rand = new Random();
            //////How to create multiple object of a class with array

            ////OEF5[] rectangles = new OEF5[objectsToCreate];


            ////for(int i = 0; i < objectsToCreate; i++)
            ////{
            ////    int width = rand.Next(1,11);
            ////    int height = rand.Next(1,11);
            ////    rectangles[i] = new OEF5(width, height);
            ////    rectangles[i].SurfaceRectangle();
            ////    Console.WriteLine(rectangles[i]);

            ////}

            //List<OEF5> rectangles = new List<OEF5>();

            //for (int i = 0; i < objectsToCreate; i++)
            //{
            //    int width = rand.Next(1, 11);
            //    int height = rand.Next(1, 11);
            //    rectangles.Add(new OEF5(width, height));
            //    rectangles[i].SurfaceRectangle();
            //    Console.WriteLine(rectangles[i]);

            //}
            //Console.WriteLine();
            //int objectInList = 10;
            //for (int i = objectInList - 1; i > 0; i--)
            //{
            //    if (rectangles[i].Surface < 10)
            //    {
            //        rectangles.Remove(rectangles[i]);

            //    }

            //}
            //for (int i = 0; i < rectangles.Count; i++)
            //{
            //    Console.WriteLine(rectangles[i]);
            //}

            ////OEF 6


            //List<OEF6> compactDisks = new List<OEF6>();

            //compactDisks.Add(new OEF6("The Dark Knight", "Batman"));
            //compactDisks.Add(new OEF6("SpiderVerse", "Spiderman"));
            //compactDisks.Add(new OEF6("Lord Of The Rings", "Gandolf"));
            //compactDisks.Add(new OEF6("Parasite", "Asians"));

            //Console.WriteLine("Give me a song name");
            //compactDisks[1].AddSongs(Console.ReadLine());


            //compactDisks[0].Songs.Add("Joker Smile");
            //compactDisks[0].Songs.Add("Batman cry");
            //compactDisks[0].Songs.Add("Forsen Laugh");

            //compactDisks[3].Songs.Add("Asian FolkLore");
            //compactDisks[3].Songs.Add("Surviving for years");
            //compactDisks[3].Songs.Add("Kill the rich");


            //Console.WriteLine(compactDisks[0]);

            //OEF 7

            //OEF 8
            Random rnd = new Random();
            OEF8 studentData = new OEF8();
            studentData.Name = "Jeff";
            studentData.Points = GetRandomDouble(rnd);

            Console.WriteLine(studentData);


            ////OEF 9
            //OEF9[] studentData = new OEF9[3];
            //Random random = new Random();
            //studentData[0] = new OEF9("Cook", GetRandomDouble(random));
            //studentData[1] = new OEF9("John", GetRandomDouble(random));
            //studentData[2] = new OEF9("Fuck", GetRandomDouble(random));

            //foreach(OEF9 student in studentData)
            //{
            //    Console.WriteLine(student);
            //}

            ////OEF 11

            //Console.WriteLine("How many students do you want to write into the database");
            //int.TryParse(Console.ReadLine(), out int inputUser);
            //OEF9[] studentData = new OEF9[inputUser];
            //string nameStudent;
            //double gradeStudent;
            //for(int i = 0; i < studentData.Length; i++)
            //{
            //    Console.WriteLine("Give me the name!");
            //    nameStudent = Console.ReadLine();
            //    Console.WriteLine("Give me the grade!");
            //    double.TryParse(Console.ReadLine(),out gradeStudent);

            //    studentData[i] = new OEF9(nameStudent,gradeStudent);
            //}
            //foreach(OEF9 student in studentData)
            //{
            //    Console.WriteLine(student);
            //}

            ////OEF 12

            //Console.WriteLine("How many students do you want to write into the database");
            //int.TryParse(Console.ReadLine(), out int inputUser);
            //OEF9[] studentData = new OEF9[inputUser];
            //string nameStudent;
            //double gradeStudent;
            //for (int i = 0; i < studentData.Length; i++)
            //{
            //    Console.WriteLine("Give me the name!");
            //    nameStudent = Console.ReadLine();
            //    Console.WriteLine("Give me the grade!");
            //    double.TryParse(Console.ReadLine(), out gradeStudent);

            //    studentData[i] = new OEF9(nameStudent, gradeStudent);
            //}
            //Console.WriteLine("These students have passed");
            //for (int i = 0;i < studentData.Length; i++)
            //{

            //    if (studentData[i].IsFailed()==true) 
            //    {
            //        Console.WriteLine(studentData[i]);
            //    }
            //}

            //Console.WriteLine("These student have failed");
            //for (int i = 0; i < studentData.Length; i++)
            //{

            //    if (studentData[i].IsFailed() == false)
            //    {
            //        Console.WriteLine(studentData[i]);
            //    }
            //}

            EndApplication();


        }
        static void EndApplication()
        {
            Console.WriteLine("Press any Key to continue");
            Console.ReadKey();
        }
        static double GetRandomDouble(Random random)
        {
            return random.NextDouble() * random.Next(200);
        }

    }
}
