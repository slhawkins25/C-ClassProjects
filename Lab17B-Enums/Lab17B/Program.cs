using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17B
{

    class Program
    {

        static void Main(string[] args)
        {
            //Route userRoute = new Route();

            int direction;
            double distance;

            Console.WriteLine("1) " + Orientation.North);
            Console.WriteLine("2) " + Orientation.South);
            Console.WriteLine("3) " + Orientation.East);
            Console.WriteLine("4) " + Orientation.West);

            Console.WriteLine("Select a direction: ");
            direction = Convert.ToByte(Console.ReadLine());
            //  userRoute.setDirection(direction);
            // userRoute.getDirection();
            // Console.WriteLine((Orientation)direction);

            Console.WriteLine("Input a distance: ");
            distance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("My route specifies a direction of " + ((Orientation)direction) + " and a distance of {0}.", distance);

        }

    }
}
