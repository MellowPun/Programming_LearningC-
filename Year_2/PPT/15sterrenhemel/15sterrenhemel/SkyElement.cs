using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace _15sterrenhemel
{
    /*------A 
         *Maak een klasse SkyElement die een deel van de sterrenhemel moet voorstellen. 
         *Een SkyElement-object staat voor een leeg stuk in de lucht, en drukt dus gewoon een spatie af. 
         *Schrijf een Print methode in SkyElement die deze spatie afdrukt met achtergrondkleur DarkBlue.
     */
    class SkyElement
    {
        protected string emptySky;

        public string EmptySky
        {
            get { return emptySky; }
            set { emptySky = value; }
        }
        
        public SkyElement()
        {
            emptySky = " ";
        }
        
        public virtual void Print()
        {
            ConsoleColor back = Console.BackgroundColor;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write(emptySky);
            Console.BackgroundColor = back;
        }
    }
}
