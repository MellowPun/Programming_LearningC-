using System;
namespace _15sterrenhemel
{
    /*------C
         *Schrijf nu een klasse Star die afgeleid is van SkyElement. Maak de Print-methode van SkyElement virtual, 
         *en override deze methode in Star zodat er in de plaats van een spatie, een gele * wordt afgedrukt. 
         *
         *In de constructor van NightSky maak je 5 Star-objecten aan op random posities in de array. 
         *Roep de Print-methode van NightSky op om te zien of dit gelukt is:
     */
    class Star : SkyElement
    {
        
        public override void Print()
        {
            ConsoleColor front = Console.ForegroundColor;
            ConsoleColor back = Console.BackgroundColor;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Write("*");
            Console.BackgroundColor = back;
            Console.ForegroundColor = front;
        }
    }
    
}
