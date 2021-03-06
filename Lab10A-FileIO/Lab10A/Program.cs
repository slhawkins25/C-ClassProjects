﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab10A
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader myStreamReader = new StreamReader("inputFile.txt");
            try
            {
               
                {
                    string line;
                    while ((line = myStreamReader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                myStreamReader.Close(); // Not necessary because the close statement is generated by the using statement implementing IDisposable
            }
        }
    }
}
