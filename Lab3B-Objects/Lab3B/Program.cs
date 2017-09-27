using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3B
{
    class Program
    {
        static void Main(string[] args)
        {
            doWork();
        }

        static void doWork()
        {
            try
            {

                int number1 = 0;
                int number2 = 0;

                Triangle triangle1 = new Triangle();
                Triangle triangle2 = new Triangle(2);
                Triangle triangle3 = new Triangle(2, 4);
                Triangle triangle4 = new Triangle(2, 2, 2);

                Console.WriteLine("First triangle side1 =: " + triangle1.getSide1());
                Console.WriteLine("Second triangle side1 =: " + triangle2.getSide1());
                Console.WriteLine("Third triangle side2 =: " + triangle3.getSide2());
                Console.WriteLine("Fourth triangle side4 =: " + triangle4.getSide3());


                triangle1.setSide2(2);
                triangle2.setSide2(3);
                triangle3.setSide3(4);
                triangle4.setSide3(5);

                Console.WriteLine("First triangle side2 =: " + triangle1.getSide2());
                Console.WriteLine("Second triangle side2 =: " + triangle2.getSide2());
                Console.WriteLine("Third triangle side3 =: " + triangle3.getSide3());
                Console.WriteLine("Fourth triangle side4 =: " + triangle4.getSide3());

                Console.WriteLine(number1 / number2);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("We're done!");
            }
        }

    }

}
