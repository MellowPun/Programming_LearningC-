using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Inheritance_Overerving
{
    internal class NightSky : SkyElement
    {
        Random random = new Random();
        protected SkyElement[,] _SkyElement;

        public NightSky(int x, int y)
        {

            _SkyElement = new SkyElement[x,y];
            for(int i = 0;  i < _SkyElement.GetLength(0); i++)
            {
                for(int j = 0;  j < _SkyElement.GetLength(1); j++) 
                {
                    _SkyElement[i, j] = new SkyElement();
                }
            }

            for(int i = 0; i<5; i++)
            {
                _SkyElement[random.Next(0,_SkyElement.GetLength(0)), random.Next(0, _SkyElement.GetLength(1))] = new Star();
            }

            for (int i = 0; i < 3; i++)
            {
                _SkyElement[random.Next(0, _SkyElement.GetLength(0)), random.Next(0, _SkyElement.GetLength(1))] = new Planet(ConsoleColor.DarkRed);
            }


        }

        public override void Print()
        {
            for(int i=0; i< _SkyElement.GetLength(0); i++)
            {
                for(int j = 0; j< _SkyElement.GetLength(1); j++)
                {
                    _SkyElement[i,j].Print();
                }
                Console.WriteLine();
            }
        }


    }
}
