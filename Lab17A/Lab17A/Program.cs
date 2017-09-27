using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17A
{

    enum Orientation : byte { North = 1, South = 2, East = 3, West = 4 }

    struct Route
    {
        private Orientation direction;
        private double distance;

        public Route(Orientation direction, double distance)
        {
            this.direction = direction;
            this.distance = distance;
        }

        //public byte getDirection()
        //{
        //    return (byte)direction;
        //}

        //public void setDirection(Orientation direction)
        //{

        //    this.direction = direction;

        //    if (this.direction == Orientation.North)
        //    {
        //        this.direction = Orientation.North;
        //    }
        //    else if (this.direction == Orientation.South)
        //    {
        //        this.direction = Orientation.South;
        //    }
        //    else if (this.direction == Orientation.East)
        //    {
        //        this.direction = Orientation.East;
        //    }
        //    else if (this.direction == Orientation.West)
        //    {
        //        this.direction = Orientation.West;
        //    }
        //    else
        //    {
        //       // Console.WriteLine("That's not a direction");
        //    }
        //}

    }

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