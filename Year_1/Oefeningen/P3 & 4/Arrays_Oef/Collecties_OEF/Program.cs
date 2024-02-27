using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collecties_OEF
{
    internal class Program
    {
        static void Main(string[] args)
        {


            ////OEF 1.A
            //Queue<char> name = new Queue<char>();
            //Console.WriteLine("Give your name");
            //string input = Console.ReadLine();
            //for (int i = 0; i < input.Length; i++)
            //{
            //    name.Enqueue(input[i]);
            //}
            //foreach(char c in name)
            //{
            //    Console.WriteLine(c);
            //}

            


            ////OEF1.B

            //Stack<char> stack = new Stack<char>();
            //string input = "word";
            //for(int i  = 0; i < input.Length; i++) 
            //{
            //    stack.Push(input[i]);


            //}
            //foreach(char c in stack)
            //{
            //    Console.WriteLine(c);
            //}

            ////OEF 1.C

            //Queue<char> queue = new Queue<char>();
            //Stack<char> stack = new Stack<char>();
            //string input = "word";
            //string output = "level";

            //for(int i  = 0; i < input.Length; i++)
            //{
            //    queue.Enqueue(input[i]);
            //    stack.Push(input[i]);
            //}

            //Console.WriteLine(CheckPalindrome(queue, stack));

            ////OEF 4

            //Console.WriteLine("Give me a word");
            //string input = Console.ReadLine();

            //HashSet<char> output = new HashSet<char>();

            //for(int i = 0; i < input.Length; i++)
            //{
            //    Console.WriteLine(output.Add(input[i])); 
            //}

            //Console.WriteLine( output.Remove('w'));
            //Console.WriteLine( output.Contains('w'));

            //foreach(char c in output)
            //{
            //    Console.WriteLine(c);
            //}
            

            //OEF 5












            Console.ReadKey();
        }
        static bool CheckPalindrome(Queue<char> queue, Stack<char> stack)
        {
            bool palindrome=false;
            int lengthString = queue.Count/2;
            for(int i =0; i < lengthString; i++)
            {
                if (queue.Peek() == stack.Peek())
                {
                    palindrome = true;
                }
                
            }
            return palindrome;

        }
    }
}
