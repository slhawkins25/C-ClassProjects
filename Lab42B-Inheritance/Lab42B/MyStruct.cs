using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab42B
{
    struct MyStruct : IMyInterface // Implements the interface
    {
        public void printString(string message)
        {
            Console.WriteLine(message);
        }
    }
}
