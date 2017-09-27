using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab46D
{
    class Employee : Person
    {
        public string Job { get; set; }
        public int EmployeeID { get; set; }

        public Employee()
        {

        }

        public Employee(string firstName, string lastName, int _employeeID)
            : base(firstName, lastName)
        {
            EmployeeID = _employeeID;
           
        }

        //public virtual double pay(double money)
        //{
        //    return money;
        //}

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

        public void addJob(string Job)
        {
            

            if (Job == "Manager" && GetType().ToString() == "Lab46D.WageEmployee")
            {
                throw new Exception("A wage employee cannot be a Manager"); // Anon. This only changes the message, it does not create a new exception
            }
            else
            {
                this.Job = Job;
            }

        }

        public string selectJob(string Job)
        {
            return this.Job;
        }
    }
}
