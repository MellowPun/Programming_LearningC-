using System;
namespace _15sterrenhemel
{
    /*------F
         *Maak een klasse BlackHole aan, afgeleid van SkyElement. 
         *Een BlackHole drukt in de Print-methode gewoon een spatie af maar dan met een zwarte achtergrond. 
         *
         *Voeg 1 BlackHole-object toe aan je sterrenhemel. 
         *Belangrijk: vlak rond een BlackHole kan zich geen ander hemelobject bevinden, want dat zouden opgezogen zijn door 
         *het zwarte gat! Zorg er dus voor dat er geen Star, Planet of Comet dichter dan 3 vakjes bij je zwarte gat is. 
         *De finale sterrenhemel ziet er dan bv zo uit:
     */
     class BlackHole : SkyElement
    { 
        public override void Print()
        {
            ConsoleColor front = Console.ForegroundColor;
            ConsoleColor back = Console.BackgroundColor;

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(" ");
            Console.BackgroundColor = back;
            Console.ForegroundColor = front;
        }
    }
}
