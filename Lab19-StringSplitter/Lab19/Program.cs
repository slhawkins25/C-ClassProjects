using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab19
{
    class Program
    {
        static void Main(string[] args)
        {
            string myString = "This is a test"; // String is an array of characters (char)
            char[] seperator = {' '};
            string[] myWords;

            myWords = myString.Split(seperator);

            Console.WriteLine("Result: ({0} elements):",
                              myWords.Length);

            foreach (string word in myWords)
            {
                Console.WriteLine(word); 
            }

            
        }
    }
}
