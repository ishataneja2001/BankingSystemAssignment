using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentC_2.Model
{
    internal class CurrentAccount:BankAccount
    {
        private const decimal overdraftLimit = -1000.0m;

        // Default constructor
        public CurrentAccount() 
        {

        }

        // Overloaded constructor
        public CurrentAccount(string accountNumber, string customerName, decimal initialBalance)
            : base(accountNumber, customerName, initialBalance)
        {
        }

        public override void Withdraw(decimal amount)
        {
            if (amount > 0 && (balance - amount) >= overdraftLimit)
            {
                balance -= amount;
                Console.WriteLine($"Withdrawn {amount}. New balance: {balance}");
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount or exceeding overdraft limit.");
            }
        }

        public override void CalculateInterest()
        {
            // Current account has no interest
            Console.WriteLine("No interest for current account.");
        }
    }
}
