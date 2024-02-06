using AssignmentTask10.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTask10.Repository
{
    internal class Bank
    {
        private List<Account> accounts;
        private int nextAccountNumber;

        public Bank()
        {
            accounts = new List<Account>();
            nextAccountNumber = 1001;
        }

        public void CreateAccount(Customer customer, string accType, decimal balance)
        {
            int accNo = GenerateAccountNumber();
            Account newAccount = new Account(accNo, accType, balance, customer);
            accounts.Add(newAccount);
            Console.WriteLine($"Account created successfully. Account Number: {accNo}");
        }

        public decimal GetAccountBalance(long accountNumber)
        {
            Account account = FindAccountByNumber(accountNumber);
            return account != null ? account.AccountBalance : -1; // Return -1 if account not found
        }

        public decimal Deposit(long accountNumber, decimal amount)
        {
            Account account = FindAccountByNumber(accountNumber);
            if (account != null)
            {
                account.AccountBalance += amount;
                Console.WriteLine($"Deposit successful. Current Balance: {account.AccountBalance:C}");
                return account.AccountBalance;
            }
            else
            {
                Console.WriteLine("Account not found.");
                return -1; // Return -1 if account not found
            }
        }

        public decimal Withdraw(long accountNumber, decimal amount)
        {
            Account account = FindAccountByNumber(accountNumber);
            if (account != null)
            {
                if (account.AccountBalance >= amount)
                {
                    account.AccountBalance -= amount;
                    Console.WriteLine($"Withdrawal successful. Current Balance: {account.AccountBalance:C}");
                    return account.AccountBalance;
                }
                else
                {
                    Console.WriteLine("Insufficient funds.");
                    return -1; // Return -1 for insufficient funds
                }
            }
            else
            {
                Console.WriteLine("Account not found.");
                return -1; // Return -1 if account not found
            }
        }

        public void Transfer(long fromAccountNumber, long toAccountNumber, decimal amount)
        {
            Account fromAccount = FindAccountByNumber(fromAccountNumber);
            Account toAccount = FindAccountByNumber(toAccountNumber);

            if (fromAccount != null && toAccount != null)
            {
                if (fromAccount.AccountBalance >= amount)
                {
                    fromAccount.AccountBalance -= amount;
                    toAccount.AccountBalance += amount;
                    Console.WriteLine($"Transfer successful. From Account Balance: {fromAccount.AccountBalance:C}, To Account Balance: {toAccount.AccountBalance:C}");
                }
                else
                {
                    Console.WriteLine("Insufficient funds for transfer.");
                }
            }
            else
            {
                Console.WriteLine("One or both accounts not found.");
            }
        }

        public void GetAccountDetails(long accountNumber)
        {
            Account account = FindAccountByNumber(accountNumber);
            if (account != null)
            {
                account.PrintAccountInformation();
            }
            else
            {
                Console.WriteLine("Account not found.");
            }
        }

        private int GenerateAccountNumber()
        {
            return nextAccountNumber++;
        }

        private Account FindAccountByNumber(long accountNumber)
        {
            return accounts.Find(account => account.AccountNumber == accountNumber);
        }
    }
}
