using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_53
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<char> alphabet = new Stack<char>();
            alphabet.Push('A');
            alphabet.Push('B');
            alphabet.Push('C');

            Console.WriteLine("First Iteration");

            foreach (char alpha in alphabet)
            {
                Console.WriteLine(alpha);
                Console.WriteLine($"Peeking: {alphabet.Peek()}"); // Peek looks at the element at the top of the stack without popping it off
            }
            Console.WriteLine();

            Console.WriteLine("Second Iteration");

            while (alphabet.Count > 0)
            {
                char alpha = alphabet.Pop();
                Console.WriteLine($"Stack: {alpha}");
            }



        }
    }
}
