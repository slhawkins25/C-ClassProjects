using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab46A
{
    class SalariedEmployee: Employee
    {

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
    }
}
