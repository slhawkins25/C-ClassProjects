using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab42C
{
    class ClassB : IMyInterface // Implements the interface "IMyInterface"
    {
        public void printString(string message)
        {
            Console.WriteLine(message);
        }
    }
}
