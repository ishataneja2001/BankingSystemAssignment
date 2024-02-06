using AssignmentTask1112.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTask1112.Repository
{
    internal class BankRepo:IBankRepo
    {
        protected List<Account> accountsList = new List<Account>();

        public void CreateAccount(Customer customer, long accNo, string accType, decimal balance)
        {
            // Create an account based on the account type
            Account newAccount;
            if (accType.Equals("Savings", StringComparison.OrdinalIgnoreCase))
            {
                newAccount = new SavingsAccount(2.5m, customer); // Example interest rate for savings account
            }
            else if (accType.Equals("Current", StringComparison.OrdinalIgnoreCase))
            {
                newAccount = new CurrentAccount(1000, customer); // Example overdraft limit for current account
            }
            else if (accType.Equals("ZeroBalance", StringComparison.OrdinalIgnoreCase))
            {
                newAccount = new ZeroBalanceAccount(customer);
            }
            else
            {
                throw new ArgumentException("Invalid account type.");
            }

            // Set additional details and initial balance
            newAccount.AccountNumber = (int)accNo;
            newAccount.AccountBalance = balance;

            // Add the new account to the list
            accountsList.Add(newAccount);
        }

        public Account[] ListAccounts()
        {
            return accountsList.ToArray();
        }

        public void CalculateInterest()
        {
            
        }


    }
}
