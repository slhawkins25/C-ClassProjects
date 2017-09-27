using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab42
{
    class Checker
    {
        private object anObject;

        // Default constructor is available, you do not have to define if you do not make another type of constructor

        public object check(object obj) // Check method takes an object as a parameter
                                                                // Tests if the input object ISA another type of object
        {

            if (obj is ClassA) // is tests before the cast, as checks after the cast when used for casting // test = if, else in instructions
            {
                Console.WriteLine("Variable can be converted to ClassA");
                // p.197 in the book shows is, as , and casting
            }
            else
            {
                Console.WriteLine("Variable can't be converted to ClassA");
            }

            if (obj is IMyInterface)
            {
                Console.WriteLine("Variable can be converted to IMyInterface");
            }

            else
            {
                Console.WriteLine("Variable can't be converted to IMyInterface");
            }

            if (obj is MyStruct)
            {
                Console.WriteLine("Variable can be converted to MyStruct");
            }

            else
            {
                Console.WriteLine("Variable can't be converted to MyStruct");
            }
            if (obj is ClassB)
            {
                Console.WriteLine("Variable can be converted to ClassB");
            }

            else
            {
                Console.WriteLine("Variable can't be converted to ClassB");
            }
            if (obj is ClassC)
            {
                Console.WriteLine("Variable can be converted to ClassC");
            }

            else
            {
                Console.WriteLine("Variable can't be converted to ClassC");
            }
            if (obj is ClassD)
            {
                Console.WriteLine("Variable can be converted to ClassD");
            }

            else
            {
                Console.WriteLine("Variable can't be converted to ClassD");
            }
            if (obj is Object)
            {
                Console.WriteLine("Variable can be converted to Object");
            }

            else
            {
                Console.WriteLine("Variable can't be converted to Object");
            }

            return obj;
            
        }
    }
}
