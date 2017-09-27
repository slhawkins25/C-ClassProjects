using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab46A
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        protected Person() // should only be used by the children
        {

        }

        protected Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
