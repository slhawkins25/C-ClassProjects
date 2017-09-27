using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab46B
{
    class SalariedEmployee: Employee
    {
       // private string said;

        public double AnnualSalary { get; set; }
   
        public SalariedEmployee()
        {

        }

        public SalariedEmployee(string firstName, string lastName, int employeeID, double _annualSalary)
            :base(firstName, lastName, employeeID)
        {
            AnnualSalary = _annualSalary;
        }

        public override double pay(double _annualSalary)
        {
            _annualSalary = _annualSalary / 52.2;
            return _annualSalary;

        }

        public override string talk(string said)
        {
            said = "Speaking as a salaried employee";
            return said;
        }

        //public new string talk(string said)
        //{
        //    said = "Speaking as a salaried employee";
        //    return said;
        //}
    }
}
