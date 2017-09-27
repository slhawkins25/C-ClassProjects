using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab70
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal revenue = 1043000m, expenses = 102030m;
            decimal revenue1 = 2043000m, expenses1 = 202030m;

            Budget retail = new Budget(revenue, expenses); // Create budget.
            retail.ShowBudget("Brick & Mortar Budget:");

            Budget online = new Budget(revenue1, expenses1); // Create budget.
            online.ShowBudget("Online Budget:");

            Budget combined = retail + online;             // Combine budgets.
            combined.ShowBudget("Brick & Mortar and Online Budgets Combined:");
            //Budget emptyBudget = new Budget(0,0);             // Create budget.

            Budget emptyBudget = new Budget();             // Create budget.
            if (emptyBudget)                              // Ensure balances
            {                                            // are not zero.
                emptyBudget.ShowBudget("Budget is not empty.");
            }
            else
            {
                Console.WriteLine("Revenue = {0}", emptyBudget.Revenue);
                Console.WriteLine("Expenses = {0}", emptyBudget.Expenses);
                Console.WriteLine("Empty Budget.");

            }
            Console.ReadLine();
        }
    }
}
