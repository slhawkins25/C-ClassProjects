using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab30
{
    class Layout
    {
        private string[] nameArray = new string[size];
        static public int size = 100;

        public Layout() // Default constructor
        {
           
        }

        public string this[int number] 
        {
            get // Read context
            {
                string name;

                if (number >= 0 && number <= nameArray.Length) 
                {
                    name = nameArray[number]; 
                }
                else
                {
                    name = "error";
                }

                return (name);
            }
            set // Write context

            {
                if (number >= 0 && number <= size - 1)
                {
                    nameArray[number] = value; // Keyword for indexers, value is the string in the individual indexes
                }
            }
        }
    }
}
