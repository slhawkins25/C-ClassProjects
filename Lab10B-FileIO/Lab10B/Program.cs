using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab10B
{
    class Program
    {
        static void Main(string[] args)
        {
            doWork();
        }


        static void doWork()
        {
            FileStream myFileStream = new FileStream("test.dat", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            try
            {
                for (int i = 1; i <= 20; i++)
                {
                    Console.WriteLine("Writing value: {0}", i);
                    myFileStream.WriteByte((byte)i);
                }

                myFileStream.Position = 0;

                for (int value; (value = myFileStream.ReadByte()) > -1;)
                {
                    Console.WriteLine("Read Value: {0}", value);
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            finally
            {
                myFileStream.Close();
                Console.ReadKey();
            }
        }
    }
}
