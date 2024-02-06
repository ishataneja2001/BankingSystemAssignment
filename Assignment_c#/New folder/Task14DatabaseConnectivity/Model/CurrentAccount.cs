using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14DatabaseConnectivity.Model
{
    internal class CurrentAccount : Accounts
    {
        public decimal OverdraftLimit = 500;
        

        // Constructor
        public CurrentAccount(int accountId, int customerId, decimal overdraftLimit) : base(accountId, customerId, "Current", 0)
        {
            OverdraftLimit = overdraftLimit;
        }
        public CurrentAccount(decimal balance)
        {
            base.Balance = balance;
        }
       
        public bool OverDraftLimit(float amount)
        {
            decimal availableBalance = Balance + OverdraftLimit;

            if ((decimal)amount > availableBalance)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
