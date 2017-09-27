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
                if (!File.Exists("test.txt"))
                {
                    string myFileName = "test.txt";
                    File.Create(myFileName);
                }

                Console.WriteLine("Please enter a new file name.");
                string yourFileName = Console.ReadLine() + ".txt";

                if (File.Exists(yourFileName))  // Ensures that the target (user input file name) does not exist.
                {
                    File.Delete(yourFileName);
                }

                if (File.Exists("test.txt"))
                {
                    File.Move("test.txt", yourFileName);
                    Console.WriteLine($"Your file is now named: {yourFileName}");
                }
        }
    }
}
