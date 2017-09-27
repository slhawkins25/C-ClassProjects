using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab46A
{
    class Employee : Person
    {
        public int EmployeeID { get; set; }

        protected Employee()
        {

        }

        protected Employee(string firstName, string lastName, int _employeeID)
            : base(firstName, lastName) // All person constructor parameters
        {
            EmployeeID = _employeeID;
        }

        public virtual double pay(double money)
        {
            return money;
        }
    }
}
