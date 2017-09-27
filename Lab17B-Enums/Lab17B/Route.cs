using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab17B
{
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
}
