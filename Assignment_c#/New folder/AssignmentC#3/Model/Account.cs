using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTask10.Model
{
    internal class Account
    {
        private int accountNumber;
        private string accountType;
        private decimal accountBalance;
        private Customer accountOwner; // Reference to the customer who owns the account

        // Properties
        public int AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        public string AccountType
        {
            get { return accountType; }
            set { accountType = value; }
        }

        public decimal AccountBalance
        {
            get { return accountBalance; }
            set { accountBalance = value; }
        }

        public Customer AccountOwner
        {
            get { return accountOwner; }
            set { accountOwner = value; }
        }

        // Constructors
        public Account()
        {
            // Default constructor
        }

        public Account(int accountNumber, string accountType, decimal accountBalance, Customer accountOwner)
        {
            // Overloaded constructor
            AccountNumber = accountNumber;
            AccountType = accountType;
            AccountBalance = accountBalance;
            AccountOwner = accountOwner;
        }

        // Methods
        public void PrintAccountInformation()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Type: {AccountType}");
            Console.WriteLine($"Account Balance: {AccountBalance:C}");
            Console.WriteLine("Account Owner Information:");
            AccountOwner.PrintCustomerInformation();
        }
    }
}
