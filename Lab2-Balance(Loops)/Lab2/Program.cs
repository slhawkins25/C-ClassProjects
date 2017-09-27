using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            double balance;
            double interest;
            double targetBalance;

            double balanceWhile, interestWhile, targetBalanceWhile;

            double balanceDo, interestDo, targetBalanceDo;

            Console.WriteLine("What is your current balance?");
            balance = Convert.ToDouble(Console.ReadLine());
            balanceWhile = balance;
            balanceDo = balance;

            Console.WriteLine("What is your current annual interest rate (in percent %)?");
            interest = 1 + (Convert.ToDouble(Console.ReadLine()) / 100);
            interestWhile = interest;
            interestDo = interest;

            Console.WriteLine("What is your desired balance?");
            targetBalance = Convert.ToDouble(Console.ReadLine());
            targetBalanceWhile = targetBalance;
            targetBalanceDo = targetBalance;

            int numOfYears = 0;
            while (balanceWhile < targetBalanceWhile)
            {
                balanceWhile *= interestWhile;
                numOfYears++;
            }
            Console.WriteLine("It will take you {0} year(s) to reach your target balance of {1}.", numOfYears, targetBalanceWhile);

            for (numOfYears = 0; balance < targetBalance; numOfYears++)  
            {
                balance *= interest;
            }
            Console.WriteLine("It will take you {0} year(s) to reach your target balance of {1}.", numOfYears, targetBalance);

            numOfYears = 0;

            if (balanceDo != targetBalanceDo) // Tests before going into do loop, should use a for or a while if you don't want to force once
            {
                do
                {
                    balanceDo *= interestDo;
                    numOfYears++;
                }
                while (balanceDo < targetBalanceDo);
            }
            Console.WriteLine("It will take you {0} year(s) to reach your target balance of {1}.", numOfYears, targetBalanceDo);

            if (numOfYears == 0)
            {
                Console.WriteLine("To be honest, you really didn’t need to use this calculator");
            }
        }
    }
}
