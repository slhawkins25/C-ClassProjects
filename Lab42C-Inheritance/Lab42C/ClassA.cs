using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab42C
{
    class ClassA: IMyInterface // Implements the interface "IMyInterface"
    {
     public virtual void printString(string message) // virtual- I intend to get more specific info from my children (Polymorphism)
        {
            Console.WriteLine(message);
        }
    }
}
