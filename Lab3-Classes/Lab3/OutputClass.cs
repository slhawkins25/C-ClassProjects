using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class OutputClass
    {
        private string myString ;
        
        //this creates a default object 
        public OutputClass()
        {
            myString = "This is the default"; //This is a property (attribute) of the object
        }

        //Constuctors create objects
        public OutputClass( string myString) // (string myOtherString)
        {
           this.myString = myString; // "this" refers to this instance of the string, to the field
           // myString = myOtherString;
        }

        public void printString() // Not static because static makes it only accessible within the class, it can't be called out
        {
            Console.WriteLine(myString);
        }
    }
}
