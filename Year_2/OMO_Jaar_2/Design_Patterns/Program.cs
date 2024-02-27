using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IShape> shapes = new List<IShape>();
            for (int i = 0; i < 5; i++) 
            {
                shapes.Add(new Circle());
            }
            for (int i = 0; i < 5; i++)
            {
                shapes.Add(new Triangle());
            }
            for (int i = 0; i < 5; i++)
            {
                shapes.Add(new Square());
            }

            foreach (IShape shape in shapes)
            {
                shape.Info();
            }

            Console.ReadKey();



        }
    }
}
