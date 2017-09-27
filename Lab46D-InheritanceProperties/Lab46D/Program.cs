using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab46D
{
    class Program
    {
        static void Main(string[] args)
        {
            doWork();
        }

        static void doWork()
        {
            try
            {
               // Person person1 = new Person();
                Employee employee1 = new Employee();
                WageEmployee wageEmployee1 = new WageEmployee("Billy", "Bob", 123, 15.50, 40);
                WageEmployee wageEmployee2 = new WageEmployee("Sally", "Mae", 899, 16.25, 40);
                SalariedEmployee salariedEmployee1 = new SalariedEmployee("Mary", "Sue", 456, 85000);
                double wage = wageEmployee1.pay(wageEmployee1.Wage); // Can set to a variable because the pay method returns a double
                double salary = salariedEmployee1.pay(salariedEmployee1.AnnualSalary);
              
                wageEmployee1.addJob("Apprentice"); // "addJob" sets the value to Apprentice
                wageEmployee2.addJob("Manager");
                salariedEmployee1.addJob("Manager");
                
              
                Console.WriteLine($"{wageEmployee1.FirstName} {wageEmployee1.LastName} {wageEmployee1.EmployeeID} {wageEmployee1.Wage} Wage Employee");

                Console.WriteLine($"{wageEmployee1.FirstName} {wageEmployee1.LastName} makes { wageEmployee1.pay(wageEmployee1.Wage)} per week.");

                Console.WriteLine($"{salariedEmployee1.FirstName} {salariedEmployee1.LastName} {salariedEmployee1.EmployeeID} {salariedEmployee1.AnnualSalary} Salaried Employee");

                Console.WriteLine($"{salariedEmployee1.FirstName} {salariedEmployee1.LastName} makes {salary} per week.");

                Console.WriteLine($"{wageEmployee1.talk(" ")}");

                Console.WriteLine($"{salariedEmployee1.talk(" ")}");

                Console.WriteLine($"{wageEmployee1.FirstName} {wageEmployee1.selectJob(" ")}");

                Console.WriteLine($"{salariedEmployee1.FirstName} {salariedEmployee1.selectJob(" ")}");

                Console.WriteLine($"{wageEmployee2.FirstName} {wageEmployee2.selectJob(" ")}");
               
                // "selectJob" gets the value stored in the set "addJob"

              //  person1.whatIsIt(person1);
                employee1.whatIsIt(employee1);
                salariedEmployee1.whatIsIt(salariedEmployee1);
                wageEmployee1.whatIsIt(wageEmployee1);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("You've reached your final destination...");
            }
        }
    }
}

// An abstract class can invoke non-abstract methods but an abstract method must be contained in an abstract class
// Why use properties? It's pure encapsulation (you can add levels of protection i.e. read, write, private, protected, public
// internal -  anything that is part of the program can see it
// protected- anything in the heiarchy can see it