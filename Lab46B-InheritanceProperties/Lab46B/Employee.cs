using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab46B
{
    class Employee : Person
    {
        public int EmployeeID { get; set; }

        protected Employee()
        {

        }

        protected Employee(string firstName, string lastName, int _employeeID)
            : base(firstName, lastName)
        {
            EmployeeID = _employeeID;
        }

        public virtual double pay(double money)
        {
            return money;
        }

        public override string talk(string said)
        {
            said = "Speaking as an employee";
            return said;
        }
        
        //public new string talk(string said)
        //{
        //    said = "Speaking as an employee";
        //    return said;
        //}
    }
}
