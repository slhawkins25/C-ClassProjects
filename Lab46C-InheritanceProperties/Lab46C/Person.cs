using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab46B
{
    class Person
    {
        private string said;

        public string FirstName { get; set; }
        public string LastName { get; set; }

        protected Person()
        {

        }

        protected Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
         
        }

        public virtual string talk(string said)
        {

            this.said = said;
            said = "Speaking as a person";
            return said;
        }

        //public string talk(string said)
        //{
        //    this.said = said;
        //    said = "Speaking as a person";
        //    return said;
        //}
    }
}
