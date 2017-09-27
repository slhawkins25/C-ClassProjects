using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int userNumber = int.Parse(Console.ReadLine());
            // int userNumber = Convert.ToInt32(Console.ReadLine());

            bool isLessThan10 = userNumber <  10; // one predicate
            bool isBetween0And5 = (userNumber >=  0) && (userNumber <=  5);  // two predicates make one logical condition

            Console.WriteLine("Integer less than 10? {0}", isLessThan10);
            Console.WriteLine("Integer between 0 and 5? {0}", isBetween0And5);
            Console.WriteLine("Exactly one of the above is true? {0}", isLessThan10 ^ isBetween0And5); // ^ Exclusive OR

            Console.ReadLine();

        }
    }
}
