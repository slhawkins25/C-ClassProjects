using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab70
{
    class Budget
    {
        public decimal Revenue { get; set; }
        public decimal Expenses { get; set; }

        public Budget()
        {
        }

        public Budget(decimal revenue, decimal expenses)
        {
            Revenue = revenue;
            Expenses = expenses;
        }

        // 'true' operator ensures Budget properties are not zero.
        public static bool operator true(Budget budget)
        {
            if (budget.Revenue == 0 && budget.Expenses == 0)
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        // 'false' operator only required if 'true' operator is present.
        public static bool operator false(Budget budget)
        {
            return false;
        }

        // '+' overload adds Budget objects.
        public static Budget operator +(Budget a, Budget b)
        {
            Budget sum = new Budget();
            sum.Revenue = a.Revenue + b.Revenue;
            sum.Expenses = a.Expenses + b.Expenses;
            return sum;
        }

        // Show Budget properties.
        public void ShowBudget(string title)
        {
            Console.WriteLine(title);
            Console.WriteLine("Revenue: " + Revenue.ToString("C"));
            Console.WriteLine("Expenses: " + Expenses.ToString("C"));
            Console.WriteLine();
        }
    }
}
