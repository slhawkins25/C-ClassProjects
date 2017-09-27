using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {

            // Instances of the OutputClass
            OutputClass newStringOutput = new OutputClass("This is printed by the OutputClass"); // Datatype is the class OutputClass, calls the constructor that takes a string argument
            newStringOutput.printString();

            OutputClass theSecondOutput = new OutputClass();
            theSecondOutput.printString(); // printString() is the method defined in the OutPutClass

            //   OutputClass.printString("This is printed by the OutputClass");
        }
    }
}
