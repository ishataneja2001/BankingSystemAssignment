using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AssignmentTask1112.Model;

namespace AssignmentTask1112.Repository
{
    internal class CustomerRepo:ICustomerRepo
    {
        

        public decimal GetAccountBalance(long accountNumber,Collection<Account> accounts)
        {
            foreach (Account account1 in accounts)
                if (account1.AccountNumber == accountNumber)
                {
                return account1.AccountBalance;
            }
            
                throw new ArgumentException("Account not found.");
            
        }

        public decimal Deposit(long accountNumber, decimal amount, Collection<Account> accounts)
        {
            foreach (Account account1 in accounts)
                if (account1.AccountNumber == accountNumber)
                {
                account1.AccountBalance += amount;
                return account1.AccountBalance;
            }
            
                throw new ArgumentException("Account not found.");
            
        }

        public decimal Withdraw(long accountNumber, decimal amount, Collection<Account> accounts)
        {
            foreach (Account account1 in accounts)
                if (account1.AccountNumber == accountNumber)
                {
                Account account = account1;

                // Check for minimum balance for savings account
                if (account is SavingsAccount && account.AccountBalance - amount < 500)
                {
                    throw new InvalidOperationException("Withdrawal violates minimum balance rule for Savings Account.");
                }

                account.AccountBalance -= amount;
                return account.AccountBalance;
            }
            
                throw new ArgumentException("Account not found.");
            
        }

        public void Transfer(long fromAccountNumber, long toAccountNumber, decimal amount, Collection<Account> accounts)
        {
            
            
                
                Withdraw(fromAccountNumber, amount, accounts);

                
                Deposit(toAccountNumber, amount, accounts);
            
            
                throw new ArgumentException("One or both accounts not found.");
            
        }

        public string GetAccountDetails(long accountNumber,Collection<Account> accounts)
        {
            foreach(Account account1 in accounts) 
            if (account1.AccountNumber == accountNumber)
            {
                
                return $"Account Number: {account1.AccountNumber}, Account Type: {account1.AccountType}, Balance: {account1.AccountBalance}, Customer: {account1.AccountOwner}\n";
                       
            }
                throw new ArgumentException("Account not found.");
            
        }
    }
}
