using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace _15sterrenhemel
{
    enum CometDirection // ++ Maak een enum CometDirection aan, die vier waardes kan hebben: Horizontal, Vertical, LeftDown of RightDown.
    {
        Horizontal = 0,
        Vertical,
        LeftDown,
        RightDown
    }
    class Program
    {
        /*We gaan een sterrenhemel implementeren die we kunnen printen in de console.
         *------A-----SkyElement 
         *------B-----NightSky
         *------C-----Star  
         *------D-----Planet
         *------E-----Comet 
         *------F----BlackHole (++)
         *------G------BONUS
         *BONUS: Schrijf een Move-methode in NightSky die heel de lucht 1 vakje naar rechts opschuift. 
         *Zorg dat de elementen die rechts uit de 2D-array vallen, links terug verschijnen. 
         *In de Main-methode schrijf je een loop, en in die loop roep je telkens de Move-methode op, 
         *waarna je Console.Clear() oproept (dit wist alle inhoud van je Console), en vervolgens de Print-methode op NightSky.
         *Gebruik de code System.Threading.Thread.Sleep(1000) om na elke Move-call 1 seconde (1000ms) te wachten. 
         *Hierdoor zul je een looping animatie krijgen van de sterrenhemel die verschuift in de Console. 
         *Dit zou er dan zo uit moeten zien:
         *https://i.imgur.com/mzTr6Kh.gifv
         */

        static void Main(string[] args)
        {
            Nightsky firstNight = new Nightsky(10,30);
            firstNight.PrintNightSky();
        }
    }
}
