using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab46D
{
    class WageEmployee : Employee, IPay
    {
     
        public double Wage { get; set; }
        public int Hours { get; set; }

        public WageEmployee()
        {

        }

        public WageEmployee(string firstName, string lastName, int _employeeID, double _wage, int _hours)
            :base(firstName, lastName, _employeeID)
        {
            Wage = _wage;
            Hours = _hours;
        }

        public double pay(double Wage)
        {
            Wage = Wage * Hours;
            return Wage;

        }

        public override string talk(string said)
        {
            said = "Speaking as a wage employee";
            return said;
        }

        //public new string talk(string said)
        //{
        //    said = "Speaking as a wage employee";
        //    return said;
        //}
    }
}
