using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Midterm
{
    class BankAccount
    {
        static void Main(string[] args)
        {
            GoldAccount theGoldAccount = new GoldAccount(80000.50M);
            SaverAccount theSaverAccount = new SaverAccount(5525.25M);

            theGoldAccount.withdraw(90000M);
            theSaverAccount.withdraw(20M);

            theGoldAccount.deposit(55.50M);
            theSaverAccount.deposit(25M);

           //Console.WriteLine(String.Format("Gold Account Member Balance: = {0,6:C}", theGoldAccount.Balance));
           //Console.WriteLine(String.Format("Saver Account Member Balance: = {0,6:C}", theSaverAccount.Balance));

           Console.WriteLine(theGoldAccount.ToString());
           Console.WriteLine(theSaverAccount.ToString());

        }
    }
}
