using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab30A
{
    class Program
    {
        static void Main(string[] args)
        {
            //Layout layout1 = new Layout();

            IntIndexer intIndexer1 = new IntIndexer(10);


            intIndexer1[3] = "Another value";
            intIndexer1[5] = "Any value";
            intIndexer1[9] = "Some value";

            Console.WriteLine("Indexer Output \n");

            Console.WriteLine($" intIndexer1[0]: {intIndexer1[0]}\n intIndexer1[0]: {intIndexer1[0]}\n intIndexer1[1]: {intIndexer1[1]}\n intIndexer1[2]: { intIndexer1[2]}\n intIndexer1[3]: { intIndexer1[3]}\n intIndexer1[4]: { intIndexer1[4]}");
            Console.WriteLine($" intIndexer1[5]: { intIndexer1[5]}\n intIndexer1[6]: { intIndexer1[6]}\n intIndexer1[7]: { intIndexer1[7]}\n intIndexer1[8]: {intIndexer1[8]}\n intIndexer1[9]: { intIndexer1[9]}");

            //for (int i = 0; i < IntIndexer.size; i++)
            //{
            //    Console.WriteLine($"intIndexer[{i}] {intIndexer1[i]}");
            //}



        }
    }
}
