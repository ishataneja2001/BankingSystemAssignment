using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentC_2.Model
{
    public abstract class BankAccount
    {
        private string accountNumber;
        private string customerName;
        protected decimal balance;

        // Properties
        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }

        public decimal Balance
        {
            get { return balance; }
        }
        public BankAccount()
        {

        }
        // Constructor
        public BankAccount(string accountNumber, string customerName, decimal initialBalance)
        {
            this.accountNumber = accountNumber;
            this.customerName = customerName;
            this.balance = initialBalance;
        }

        // Methods
        public void Deposit(decimal amount)
        {
            if (amount > 0)
            {
                balance += amount;
                Console.WriteLine($"Deposited {amount:C}. New balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Invalid deposit amount. Amount must be greater than zero.");
            }
        }

        public virtual void Withdraw(decimal amount)
        {
            if (amount > 0 && amount <= balance)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn {amount:C}. New balance: {balance:C}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or insufficient funds.");
            }
        }

        public virtual void DisplayAccountInfo()
        {
            Console.WriteLine($"Account Number: {accountNumber}");
            Console.WriteLine($"Customer Name: {customerName}");
            Console.WriteLine($"Balance: {balance:C}");
        }
        public abstract void CalculateInterest();
    }
}
