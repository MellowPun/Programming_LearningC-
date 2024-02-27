using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
namespace _15sterrenhemel
{
    /**------B
         *Maak een klasse NightSky die als membervariabele een 2D-array van SkyElement-objecten bevat.
         *De constructor van NightSky krijgt een int size mee, die bepaalt hoe groot deze 2D-array zal zijn. 
         *Vul in de constructor deze 2D-array op met nieuwe SkyElement-objecten. 
         *Schrijf een Print methode die door de array loopt en de sterrenhemel afdrukt door 
         *op elk SkyElement-object de Print-methode op te roepen. Maak in je Main methode een object van type NightSky aan, 
         *en roep daar de Print-methode van op. Dit zou er dan zo uit moeten zien:
     */
    class Nightsky
    {
        protected SkyElement[,] night;
        protected int row;
        protected int col;
        protected Random rndGenny = new Random();
        protected SkyElement[,] Night
        {
            get { return night; }
            set { night = value;}
        }

        public Nightsky(int newRow, int newCol)
        {
            row = newRow;
            col = newCol;

            night = new SkyElement[row, col];

            for (int row = 0; row < night.GetLength(0); row++)
            {
                for (int col = 0; col < night.GetLength(1); col++)
                {
                    night[row, col] = new SkyElement();
                }
            }
            for (int i = 0; i < 8; i++)
            {
                row = rndGenny.Next(0, night.GetLength(0)) ;
                col = rndGenny.Next(0, night.GetLength(1));
                night[row, col] = new Star();
               
            }
            for (int i = 0; i < 5; i++)
            {
                row= rndGenny.Next(0, night.GetLength(0));
                col = rndGenny.Next(0, night.GetLength(1));
                int color = rndGenny.Next(0,3) ;
                ConsoleColor myColor= ConsoleColor.Black;
                switch (color)
                {
                    case 0:
                        myColor = ConsoleColor.DarkGreen;
                        break;
                    case 1:
                        myColor = ConsoleColor.Green;
                        break;
                    case 2:
                        myColor = ConsoleColor.Cyan;
                        break;
                    default:
                        break;
                }
                night[row, col] = new Planet(myColor);

            }
            for(int i = 0; i < 3; i++)
            {
                row = rndGenny.Next(0, night.GetLength(0));
                col = rndGenny.Next(0, night.GetLength(1));
                night[row, col] = new Comet((CometDirection)rndGenny.Next(0,4));

            }
            row = rndGenny.Next(0, night.GetLength(0));
            col = rndGenny.Next(0, night.GetLength(1));
            SkyElement[,] blackHoleZone = new SkyElement[7,7];
            for (int i = row -3; i < row +3; i++) // sos pieter
            {
                for (int j = col -3; j < col +3; j++)
                {
                    night[i, j] = new SkyElement();
                }
            }
            night[row, col] = new BlackHole();

            

        }
        public void PrintNightSky()
        {
            for (int row = 0; row < night.GetLength(0); row++)
            {
                for (int col = 0; col < night.GetLength(1); col++)
                {
                    night[row, col].Print();
                }
                Console.WriteLine();
            }
        }

    }
}
