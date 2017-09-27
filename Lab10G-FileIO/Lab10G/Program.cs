using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab10G
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                doWork();
            }

            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                Console.WriteLine("Finally block reached");
            }
        }

        static void doWork()
        {
            if (File.Exists("test.txt"))
            {
                File.Delete("test.txt");
                Console.WriteLine("The file test.txt was deleted.");
            }
        }
    }
}
