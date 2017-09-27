using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab46D
{
    class SalariedEmployee: Employee, IManager, IPay
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

        public double pay(double _annualSalary)
        {
            _annualSalary = _annualSalary / 52.2;
            return Math.Round(_annualSalary, 2); // takes the annual salary and the 2 is for the number of decimal places
            //return _annualSalary;

        }

        public override string talk(string said)
        {
            said = selectJob(" ");

            if (said == "Manager")
            {
                Console.WriteLine(speak("Speaking as a manager"));
            }
            else
            {
                Console.WriteLine(talk("Speaking as a salaried employee"));
            }
            return said = " ";
        }

        public string speak(string said)
        {
            return said;
        }

        //public new string talk(string said)
        //{
        //    said = "Speaking as a salaried employee";
        //    return said;
        //}
    }
}
