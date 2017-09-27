using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3B
{
    class Triangle
    {
        private double side1, side2, side3;

        public Triangle()
        {
            side1 = side2 = side3 = 1;
            Console.WriteLine("A triangle with 3 default sides was created");
        }

        public Triangle(double side1)
        {
            this.side1 = side1;
            side2 = 1;
            side3 = 1;
            Console.WriteLine("A triangle with 2 default sides was created");
        }

        public Triangle(double side1, double side2)
        {
            this.side1 = side1;
            this.side2 = side2;
            side3 = 1;
            Console.WriteLine("A triangle with 1 default side was created");
        }

        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
            Console.WriteLine("A triangle with 0 default sides was created");
        }

        public double getSide1( )
        {
            return this.side1;
          
        }

        public double getSide2()
        {
            return this.side2;
        }

        public double getSide3()
        {
            return this.side3;
        }

        public void setSide1(double side1)
        {
            this.side1 = side1;
        }

        public void setSide2(double side2)
        {
            this.side2 = side2;
        }

        public void setSide3(double side3)
        {
            this.side3 = side3;
        }
    }
}
