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
                Directory.Delete("testdir", true); // Adding the bool true allows you to delete a directory that is not empty. True to remove directories, subdirectories, and files in path; otherwise, false.
                Console.WriteLine("The directory testdir was deleted.");
            }
        }
    }
}
