using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Struct_Exercise
{
    internal class Program
    {
        public struct Vector
        {
            public int x; 
            public int y;
            public int z;
            public Vector(int x, int y, int z)
            {
                this.x = x;
                this.y = y;
                this.z = z;

            }
            public override string ToString()
            {
                
                string s = "( " + x.ToString() + " , " + y.ToString() + " , "+ z.ToString()+" ) ";
                return s;
            }
            public static Vector operator +(Vector args1, Vector args2)
            {
                args1.x += args2.x;
                args1.y += args2.y;
                args1.z += args2.z;

                return args1;
            }
            public static Vector operator -(Vector args1, Vector args2)
            {
                args1.x -= args2.x;
                args1.y -= args2.y;
                args1.z -= args2.z;

                return args1;
            }
            public static Vector operator ++(Vector args1)
            {
                args1.x++; 
                args1.y++ ;
                args1.z++ ;

                return args1;
            }


        }
        

        static void Main(string[] args)
        {
            int x;
            int y;
            int z;

            Console.WriteLine("Gimmme numbers");
            int.TryParse(Console.ReadLine(), out x);
            int.TryParse(Console.ReadLine(), out y);
            int.TryParse(Console.ReadLine(), out z);
            Vector Numba1 = new Vector(x, y, z);
            Console.WriteLine("Gimme another set of numbers");
            int.TryParse(Console.ReadLine(), out  x);
            int.TryParse(Console.ReadLine(), out  y);
            int.TryParse(Console.ReadLine(), out  z);

            Vector Numba2 = new Vector(x, y, z);
            Console.WriteLine("C1 " + Numba1);
            Console.WriteLine("C2 "+ Numba2);
            Console.WriteLine("C1+C2 = "+ (Numba1+Numba2));
            Console.WriteLine("C1-C2 = "+ ( Numba1-Numba2));
            //Als ++ achteraan staat werkt het pas na CW
            //Als ++ vooraan staat werkt het wel gwn 

            Console.WriteLine("C1++ "+ (Numba1++));
            Console.WriteLine("C1++ " + (++Numba1));
            Console.WriteLine("C2++" + (++Numba2));
            Console.WriteLine(Numba1);

            Console.WriteLine(Numba1);
            Console.WriteLine(Numba2);


            Console.ReadKey();

        }
    }
}
