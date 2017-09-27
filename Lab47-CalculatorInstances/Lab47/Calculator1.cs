using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab47
{
    public sealed partial class Calculator1 
    {
    }
    class Calculator
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Calculator()
        {

        }

        public Calculator(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
