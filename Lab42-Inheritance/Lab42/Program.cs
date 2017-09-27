using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab42
{
    class Program
    {
       //ISA stands for inherits i.e. A ISA B

        static void Main(string[] args)
        {
            // Call the defalut constructor
            // theChecker is the name of the instance
            // The check() method is not static, it must be referenced by instance name

            Checker theChecker = new Checker(); // Created a new instance of the checker class that takes an object as an argument
            ClassA a = new ClassA(); // New instances (objects) of each class/ structure
            ClassB b = new ClassB();
            ClassC c = new ClassC();
            ClassD d = new ClassD();
            MyStruct theStructure = new MyStruct(); //Structs cannot inherit from other structs or classes, it can implement an interface
            object o = theStructure; // Boxing - Initialize a variable type object with the value (the value is now stored in heap)

            // Static methods do not have to be instatiated3

            Console.WriteLine("Analyzing ClassA type variable:");
            Console.WriteLine($"{theChecker.check(a)} \n"); //The object "theChecker" is able to use the check method that takes an object as an argument

            Console.WriteLine("Analyzing ClassB type variable:");
            Console.WriteLine($"{theChecker.check(b)} \n");

            Console.WriteLine("Analyzing ClassC type variable:");
            Console.WriteLine($"{theChecker.check(c)} \n");

            Console.WriteLine("Analyzing ClassD type variable:");
           Console.WriteLine($"{theChecker.check(d)} \n");

            Console.WriteLine("Analyzing MyStruct type variable:");
           Console.WriteLine($"{theChecker.check(theStructure)} \n");

            Console.WriteLine("Analyzing boxed MyStruct type variable:");
            Console.WriteLine($"{theChecker.check(o)} \n");
           
        }
    }
}
