using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab20
{
    class Program
    {
        private static int[] arrayOfNumbers = { 5, 18, 22, 21, 14, 55, 240, 188, 554, 128 };

        static void Main(string[] args)
        {
            for (int i = 0; i < arrayOfNumbers.Length; i++)   // This code iterates through each value and shows the corresponding index #
                                                                                             // integer = values in array,  i = index # in array
            {
                int integer = arrayOfNumbers[i];
                Console.WriteLine("The value of element at position {0} = {1}", i, integer);
            }

           Console.WriteLine("The maximum value in my array is {0}", findLargestNumber(arrayOfNumbers));
        }

        static int findLargestNumber(int[] intArray) // "I take an array of ints" intArray represents any array you can pass in when you call the method
        {

            int max=0;
            for (int i = 0; i < intArray.Length; i++) // int i- sentinal variable
            {
                if (intArray[i] > max)
                {
                    max = intArray[i];
                }
            }
            return max; // Must return outside of the loop otherwise it will return each time through the loop
        }
    }
}



