using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14DatabaseConnectivity.Model
{
    internal class SavingsAccount :Accounts
    {
        public decimal InterestRate { get; set; }

        public decimal MinimumBalance = 500;

        // Constructor
        public SavingsAccount(int accountId, int customerId, decimal interestRate, decimal Balance) : base(accountId, customerId, "Savings",Balance)
        {
            InterestRate = interestRate;
            
        }
        public SavingsAccount(decimal balance)
        {
            base.Balance=balance;
        }
        public bool IsminBalance(float amount)
        {
            if(Balance - (decimal)amount < MinimumBalance )
            
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public decimal calculateInterest(decimal balance,decimal interestRate)
        {
            decimal Cal_interest = balance * interestRate;
            return balance+Cal_interest;
        } 
    }
}
