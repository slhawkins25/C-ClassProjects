using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab46D
{
    public abstract class Person
    {
        private string said;

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person()
        {

        }

        public Person(string firstName, string lastName)
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

        public void whatIsIt(object person)
        {
            if (person is Person)
            {
                person = person.GetType();
                Console.WriteLine(person);
            }
            else
            {
                Console.WriteLine("Not an object.");
            }
        }

        // internal allows program to also access a class

        internal virtual string talk()
        {
            return " speaking as a person.";
        }
       
    }
}
