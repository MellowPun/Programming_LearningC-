using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace _15sterrenhemel
{
    /*------D
         *Maak nu een nieuwe klasse Planet, ook afgeleid van SkyElement. 
         *Een Planet krijgt in zijn constructor een kleur mee. 
         *In de Print-methode druk je een O af in de meegegeven kleur. 
         *Voeg aan NightSky een aantal Planet-objecten toe op random posities in de lucht, en geef ze ook een random kleur, 
         *te kiezen uit Cyan, DarkGreen en Green.
     */
    class Planet : SkyElement
    {
        protected ConsoleColor planetColor;

        public ConsoleColor PlanetColor
        {
            get { return planetColor; }
            set { planetColor = value; }
        }

        public Planet()
        {
            planetColor = ConsoleColor.DarkGreen;
        }
        public Planet(ConsoleColor newPlanetColor)
        {
            planetColor = newPlanetColor;
        }

        public override void Print()
        {
            ConsoleColor front = Console.ForegroundColor;
            ConsoleColor back = Console.BackgroundColor;

            Console.ForegroundColor = planetColor;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write("O");
            Console.BackgroundColor = back;
            Console.ForegroundColor = front;
        }
    }
}
