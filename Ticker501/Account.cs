using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ticker501
{
    class Account
    {
        private decimal cashBalance;
        private List<Portfolio> portfolios;

        public Account()
        {
            cashBalance = 0;
            portfolios = new List<Portfolio>();
        }

        /*-------------------------------------
         * Adds the designated amount of money
         * to the account's cash balance.
        --------------------------------------*/
        public void Deposit(decimal amount)
        {
            cashBalance += amount;
        }

        /*-------------------------------------
         * Attempts to remove the designated
         * amount of money from the account's
         * cash balance. Return value represents
         * whether the transaction was successful.
        --------------------------------------*/
        public bool Withdraw(decimal amount)
        {
            //need to make this account for positions balance and attempt to sell stocks if neccessary
            //will likely need to change return behaviour to do this
            if(amount < cashBalance)
            {
                cashBalance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        /*-------------------------------------
         * Returns the current cash balance.
        --------------------------------------*/
        public decimal GetCashBalance()
        {
            return cashBalance;
        }

    }
}
