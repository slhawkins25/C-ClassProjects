using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab42B
{
    class Program
    {
        static object myObject;

        static void Main(string[] args)
        {
           
            doWork();
        }
        static void doWork()
        {
            try
            {

                Checker theChecker = new Checker(myObject); // Created a new instance of the checker class that takes an object as an argument
                ClassA a = new ClassA(); // New instances (objects) of each class/ structure
                ClassB b = new ClassB();
                ClassC c = new ClassC();
                ClassD d = new ClassD();
                MyStruct theStructure = new MyStruct();
                object o = theStructure; // Boxing - Initialize a variable type object with the value (the value is now stored in heap)

                Console.WriteLine("Analyzing ClassA type variable:");
                Console.WriteLine($"{theChecker.check(a)}"); //The object "theChecker" is able to use the check method that takes an object as an argument
               a.printString("Hello from ClassA  \n");

                Console.WriteLine("Analyzing ClassB type variable:");
                Console.WriteLine($"{theChecker.check(b)}");
                b.printString("Hello from ClassB \n");

                Console.WriteLine("Analyzing ClassC type variable:");
                Console.WriteLine($"{theChecker.check(c)}");
             
                Console.WriteLine("Analyzing ClassD type variable:");
                Console.WriteLine($"{theChecker.check(d)}");
                d.printString("Hello from ClassD \n");

                Console.WriteLine("Analyzing MyStruct type variable:");
                Console.WriteLine($"{theChecker.check(theStructure)}");
                theStructure.printString("Hello from theStructure \n");

                Console.WriteLine("Analyzing boxed MyStruct type variable:");
                Console.WriteLine($"{theChecker.check(o)}");

                MyStruct struct2 = (MyStruct)o; // unboxing

                Console.WriteLine("Analyzing unboxed MyStruct type variable:");
                Console.WriteLine($"{ theChecker.check(struct2)}");
               

                throw new Exception("Boom!!");
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally // can be useful to free resources, i.e. database connection and file handling
            {
                Console.WriteLine("The finally block has been reached!");
            }
        }
    }
}
