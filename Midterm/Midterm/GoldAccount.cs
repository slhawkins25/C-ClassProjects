using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class GoldAccount : IBankAccount
    {
        public decimal Balance { set;  get; }

        public GoldAccount()
        {

        }

        public GoldAccount(decimal balance)
        {
            Balance = balance;
        }

        public void deposit(decimal amountIn)
        {
            Balance += amountIn;
            
        }

        public bool withdraw(decimal amountOut)
        {
            if (amountOut > Balance)
            {
                Console.WriteLine("Withdrawal failed. Insufficient Funds");
            }
            else
            {
                Balance -= amountOut;
            }
            return true;
        }

        public override String ToString()
        {
            return String.Format("Gold Account Member Balance: = {0,6:C}", Balance);
        }
    }
}
