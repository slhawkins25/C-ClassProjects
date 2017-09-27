using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab10
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream myStream1 = new FileStream("DestinationFile.txt", FileMode.Create, FileAccess.ReadWrite);

            FileStream myStream2 = new FileStream("BogusInputFile.txt", FileMode.Create, FileAccess.ReadWrite);

            myStream1 = null;
            myStream2 = null;

            try
            {
                File.OpenWrite(@"C:\DestinationFile.txt");
                File.OpenRead(@"C:\BogusInputFile.txt");
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                myStream1.Close();
                myStream2.Close();
            }
   
        }
    }
}
