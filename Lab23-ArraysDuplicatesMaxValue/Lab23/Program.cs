using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab23
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] testArray = { 4, 7, 4, 2, 7, 3, 7, 8, 3, 9, 1, 9 };
            int[] maxValIndicies;

            Maxima(testArray, out maxValIndicies); // The out allows you to pass in a variable that has not been intialized 
        }

        public static int Maxima(int[] intArray, out int[] indicies)
        {
            indicies = new int[1]; // This initializes the the out int indicies as well as maxValIndicies
            int maxValue = intArray[0];
            int count = 1;

            Console.WriteLine("Maximum value search started");
            Console.WriteLine($"Maximum value initialized to {maxValue}, at element index{indicies}.");

            for (int i = 0; i < intArray.Length; i++)
            {
                Console.WriteLine($"Now looking at element {intArray[i]} at {indicies}");

                if (intArray[i] > maxValue)
                {
                    maxValue =  intArray[i];
                    count = 1;
                    indicies = new int[1];
                    indicies[0] = i;
                    Console.WriteLine($"New maximum found. New value is {maxValue}, at element index {indicies}");
                }
                else
                {
                    if (intArray[i] == maxValue)
                        {
                        count++;

                        int[] oldIndicies = indicies; // Two references to the same array

                        indicies = new int[count];

                        oldIndicies.CopyTo(indicies, 0);

                        indicies[count - 1] = i;
                        }
                    Console.Write($"Duplicate maximum found at element index {indicies}");
                }
                Console.WriteLine($"Maximum value {maxValue} with {indicies} occurences.");
            }
            Console.WriteLine("Maximum value search completed.");
            return maxValue;

        }
        }
    } // Copy reinitializes the array each time