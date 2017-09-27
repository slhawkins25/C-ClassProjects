using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab30A
{
    class Layout
    {
        protected string[] nameArray = new string[size];
        static public int size = 100;

        public Layout() // Default constructor
        {
           
        }

        public string this[int number] 
        {
            get
            {
                string name;

                if (number >= 0 && number <= nameArray.Length) // can use .length instead of variable 
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
                    nameArray[number] = value;
                }
            }
        }
    }
}
