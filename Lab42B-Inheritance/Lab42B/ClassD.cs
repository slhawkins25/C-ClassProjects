using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab42B
{
    class ClassD : ClassA // Inherits the class
    {
        public override void printString(string message)
        {
            base.printString("Hello from ClassA");
            Console.WriteLine(message);
        }
    }
}
