using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab46B
{
    class Program
    {
        static void Main(string[] args)
        {
            WageEmployee wageEmployee1 = new WageEmployee("Billy", "Bob", 123, 15.50, 40);
            SalariedEmployee salariedEmployee1 = new SalariedEmployee("Mary", "Sue", 456, 85000);
            double wage = wageEmployee1.pay(wageEmployee1.Wage);
            double salary = salariedEmployee1.pay(salariedEmployee1.AnnualSalary);

            Console.WriteLine($"{wageEmployee1.FirstName} {wageEmployee1.LastName} {wageEmployee1.EmployeeID} {wageEmployee1.Wage} Wage Employee");

            Console.WriteLine($"{wageEmployee1.FirstName} {wageEmployee1.LastName} makes { wageEmployee1.pay(wageEmployee1.Wage)} per week.");

            Console.WriteLine($"{salariedEmployee1.FirstName} {salariedEmployee1.LastName} {salariedEmployee1.EmployeeID} {salariedEmployee1.AnnualSalary} Salaried Employee");

            Console.WriteLine($"{salariedEmployee1.FirstName} {salariedEmployee1.LastName} makes {salary} per week.");

            Console.WriteLine($"{wageEmployee1.FirstName} is {wageEmployee1.talk(" ")}");

            Console.WriteLine($"{salariedEmployee1.FirstName} is {salariedEmployee1.talk(" ")}");
        }
    }
}
