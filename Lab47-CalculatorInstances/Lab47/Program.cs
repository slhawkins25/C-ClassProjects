using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab47A;

namespace Lab47
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calc1 = new Calculator();
            Calculator calc2 = new Calculator();
            Calculator calc3 = new Calculator(0, 0);
            Calculator calc4 = new Calculator(10, 120);
            Lab47A.Calculator calc5 = new Lab47A.Calculator();

            Console.WriteLine($"X: {calc3.X} Y: {calc3.Y}");
            Console.WriteLine($"X: {calc4.X} Y: {calc4.Y}");

            int sum1 = calc5.calculateSum(calc3.X, calc3.Y);
            int product1 = calc5.calculateProduct(calc3.X, calc3.Y);
            int sum2 = calc5.calculateSum(calc4.X, calc4.Y);
            int product2 = calc5.calculateProduct(calc4.X, calc4.Y);

            Console.WriteLine($"Sum Result: {sum1}");
            Console.WriteLine($"Product Result: {product1}");

            Console.WriteLine($"Sum Result: {sum2}");
            Console.WriteLine($"Product Result: {product2}");


        }
    }
}
