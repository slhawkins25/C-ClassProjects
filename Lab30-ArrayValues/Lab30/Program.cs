using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab30
{
    class Program
    {
        static void Main(string[] args)
        {
            Layout layout1 = new Layout();
            Console.WriteLine("Start Layout population");
            layout1[1] = "Frank Gehry";
            layout1[3] = "I.M Pei";
            layout1[10] = "Frank Lloyd Wright";
            layout1[11] = "Appollodorus of Damascus";
            layout1[-1] = "Error";
            layout1[1000] = "Error";
            Console.WriteLine("End Layout population");

            Console.WriteLine("Start Layout read");
            Console.WriteLine($"\n {layout1[1]} \n {layout1[3]} \n {layout1[10]} \n {layout1[11]} \n" );
            Console.WriteLine("End Layout read");
            Console.WriteLine($" \n {layout1[-1]} \n {layout1[1000]}");
        
        }

        
    }
}
