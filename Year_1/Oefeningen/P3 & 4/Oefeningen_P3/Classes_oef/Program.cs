using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Classes_oef
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////oef example
            //Enemy enemyBoss = new Enemy();
            //enemyBoss.HitPoints = 343;
            //enemyBoss.Name = "Da Boss";

            //Enemy enemyMinion = new Enemy();
            //enemyMinion.HitPoints = 20;
            //enemyMinion.Name = "Kevin";
            //enemyBoss.PairWithMinion(enemyMinion);

            //enemyBoss.TakeDamage(23000);
            //Console.WriteLine(enemyBoss);
            ////Console.WriteLine(enemyBoss.Name + " " + enemyBoss.HitPoints);
            ////Console.WriteLine(enemyMinion.mName + " " + enemyMinion.mHitPoints);


            //OEF 3
            int finalScore = 0;
            Mission missionIntro = new Mission("Save Princess");
            //mission1.MissionName ="Save Princess" ;
            missionIntro.IntroText = "Save the princess!";
            missionIntro.OutroText = "Princess is in another castle";

            missionIntro.StartMission();
            Console.WriteLine(missionIntro);
            missionIntro.Complete(out finalScore);
            Console.WriteLine(missionIntro);
            Console.WriteLine("Final score: " + finalScore);



            Mission missionFinalBoss = new Mission("Final boss");
            //missionFinalBoss.MissionName = "Final boss";
            missionFinalBoss.IntroText = "Defeat the boss";
            missionFinalBoss.OutroText = "You saved the day";


            missionFinalBoss.StartMission();
            Console.WriteLine(missionFinalBoss);
            missionFinalBoss.FailMission();

            Console.WriteLine("Mission state: " + missionFinalBoss.State);




            //OEF 5 op discord

            //OEF 8 op discord


            //OEF 9 op discord
            
            
           



















            EndApplication();
        }
        static void EndApplication()
        {
            Console.WriteLine("Press any button to quit");
            Console.ReadKey();
        }
    }
}
