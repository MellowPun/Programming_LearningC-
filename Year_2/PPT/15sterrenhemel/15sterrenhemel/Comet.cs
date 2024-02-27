using System;
namespace _15sterrenhemel
{
    /*------E
         *Maak een enum CometDirection aan, die vier waardes kan hebben: Horizontal, Vertical, LeftDown of RightDown.
         *-----Comet
         *Maak een nieuwe klasse Comet aan, afgeleid van SkyElement, die in de constructor een CometDirection-waarde meekrijgt. 
         *In de Print-methode druk je dan respectievelijk -, |, / of \ af in het rood, 
         *afhankelijk van welke CometDirection je hebt meegegeven.
     */
    class Comet : SkyElement
    {
        protected CometDirection direction;

        public Comet(CometDirection newDirection)
        {
            direction = newDirection;
        }
        public override void Print()
        {
            ConsoleColor front = Console.ForegroundColor;
            ConsoleColor back = Console.BackgroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            switch ((int)direction)
            {
                case 0:
                    Console.Write("-");
                    break;
                case 1:
                    Console.Write("|");
                    break;
                case 2:
                    Console.Write("/");
                    break;
                case 3:
                    Console.Write("\\");
                    break;
                default:
                    break;
            }
            Console.BackgroundColor = back;
            Console.ForegroundColor = front;
        }
    }
}
