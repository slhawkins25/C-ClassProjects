using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab41
{
    class Person
    {
        private string name;

        public Person()
        {

        }

        public Person(string name)
        {
            this.name = name;
        }

        public void say(string message)
        {
            Console.WriteLine($"{name} says: {message}");
        }
    }
}
