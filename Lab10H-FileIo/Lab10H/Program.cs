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
            if (Directory.Exists("testdir"))
            {
                Directory.Delete("testdir");
                Console.WriteLine("The directory testdir was deleted.");
            }
        }
    }
}