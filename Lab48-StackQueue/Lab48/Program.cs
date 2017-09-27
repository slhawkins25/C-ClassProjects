using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab48
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> stackNumbers = new Stack<int>();
            Queue<int> queueNumbers = new Queue<int>();

            for (int i = 0; i < 10; i++)
            {
                stackNumbers.Push(i); // Adds on (Last In, First Out)
                queueNumbers.Enqueue(i); // Adds on (First In, First Out)
            }

            while (stackNumbers.Count > 0)
            {
                int number = stackNumbers.Pop(); //Takes off (Last In, First Out)
                Console.WriteLine($"Stack: {number}"); //Takes off (First In, First Out)
            }

            while (queueNumbers.Count > 0)
            {
                int number = queueNumbers.Dequeue();
                Console.WriteLine($"Queue {number}");
            }

        }
    }
}
