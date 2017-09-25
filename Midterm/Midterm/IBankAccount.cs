using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    interface IBankAccount
    {
        void deposit(decimal amountIn);
        bool withdraw(decimal amountOut);

        decimal Balance { get; }
    }
}
