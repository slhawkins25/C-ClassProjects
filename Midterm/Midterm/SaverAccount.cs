using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class SaverAccount : IBankAccount
    {
        public decimal Balance { set; get; }

        public SaverAccount()
        {

        }

        public SaverAccount(decimal balance)
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
                Console.WriteLine("Insufficient Funds. Withdrawl attempt failed.");
            }
            else
            {
                Balance -= amountOut;
            }
            return true;
        }

        public override String ToString()
        {
            return String.Format("Saver Account Member Balance: = {0,6:C}", Balance);
        }
    }
}
