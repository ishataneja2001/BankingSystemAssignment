using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTask1112.Model
{
    internal class Account
    {
        private static int lastAccNo = 1000; 

        // Attributes
        private int accountNumber;
        private string accountType;
        private decimal accountBalance;
        private Customer accountOwner; 

        // Constructors
        public Account()
        {
            
            lastAccNo++;
            accountNumber = lastAccNo;
        }

        public Account(string accountType, decimal accountBalance, Customer accountOwner)
        {
            
            lastAccNo++;
            accountNumber = lastAccNo;

            AccountType = accountType;
            AccountBalance = accountBalance;
            AccountOwner = accountOwner;
        }

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

        // Method to print account information
        public void PrintAccountInformation()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Account Type: {AccountType}");
            Console.WriteLine($"Account Balance: {AccountBalance:C}");
            Console.WriteLine("Account Owner Information:");
            accountOwner.PrintCustomerInformation();
        }
    }
}
