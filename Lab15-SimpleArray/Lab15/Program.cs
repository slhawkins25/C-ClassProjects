using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab15
{
    class Program
    {
       private static int[] ints = { 0, 1, 3, 5, 7 }; // Field must be static in order to use in Main method without an instance
       private static int i = 1;

        static void Main(string[] args)
        {
            Console.WriteLine("The value is {0}", ints[0]);
            Console.WriteLine("The variable i is equal to: {0}", i);
            Console.WriteLine("I'm ready to call your method.");

            processInts(ints, i);
        }
        static void processInts(int[] ints, int theInteger)
        {
           ints[0] = 100;
           int i = 10;

            Console.WriteLine("The value is {0}", ints[0]);
            Console.WriteLine("The variable i is equal to: {0}", i);

        }
    }
}


