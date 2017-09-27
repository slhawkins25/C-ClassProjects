using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab21
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray1 = { 5, 10, 15, 20 };
            int[] myArray2 = { 1, 2, 3, 4, 5 };
            //int[] myArray3 = { 10, 20, 30, 40, 50 };
            //int[] myArray4 = { 10, 15, 20, 25, 30 };

            Console.WriteLine( $"Summed Values = {sumVals(myArray1)}");
            Console.WriteLine($"Summed Values = {sumVals(myArray2)}");
            Console.WriteLine($"Summed Values  = {sumVals(10, 20, 30, 40, 50)}"); // Not an array at this point, just a comma deliminated list
            Console.WriteLine($"Summed Values = {sumVals(10, 15, 20, 25, 30)}");
        }

        public static int sumVals(params int[] values) // The signature of the method is only the  datatype, params is only a keyword
                                                                                        // Purpose of params is to avoid overloads
        {
            int sum = 0;
            foreach (int value in values)
            {
                sum += value; // sum = sum + value
            }
            return sum;
        }
    }
}
