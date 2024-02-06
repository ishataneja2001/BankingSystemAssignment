using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.model
{
    internal abstract class BankAccount:Account
    {
        public int AccountNumber { get; set; }
        public string CustomerName { get; set; }
        protected double Balance { get; set; } // Protected to allow access for subclasses

        // Default constructor
        public BankAccount()
        {
            // Initialize attributes with default values or leave them uninitialized
        }

        // Overloaded constructor
        public BankAccount(int accountNumber, string customerName, double initialBalance)
        {
            AccountNumber = accountNumber;
            CustomerName = customerName;
            Balance = initialBalance;
        }

        // Method to print all information of attributes
        public void PrintAccountInformation()
        {
            Console.WriteLine($"Account Number: {AccountNumber}");
            Console.WriteLine($"Customer Name: {CustomerName}");
            Console.WriteLine($"Balance: {Balance:C}");
        }

        // Abstract method for deposit
        public abstract void Deposit(double amount);
    }

    

    
      
 }

