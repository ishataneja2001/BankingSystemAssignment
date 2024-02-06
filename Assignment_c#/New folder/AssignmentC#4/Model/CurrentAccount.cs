using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTask1112.Model
{
    internal class CurrentAccount:Account
    {
        private decimal overdraftLimit;

       
        public CurrentAccount(decimal overdraftLimit, Customer accountOwner) : base("Current", 0, accountOwner)
        {
            this.OverdraftLimit = overdraftLimit;
        }

        // Property for overdraft limit
        public decimal OverdraftLimit
        {
            get { return overdraftLimit; }
            set { overdraftLimit = value; }
        }

        // Method to withdraw with overdraft limit
        public void Withdraw(decimal amount)
        {
            if (amount > AccountBalance + overdraftLimit)
            {
                Console.WriteLine("Withdrawal amount exceeds available balance and overdraft limit.");
            }
            else
            {
                AccountBalance -= amount;
                Console.WriteLine($"Withdrawal of {amount:C} successful. Remaining balance: {AccountBalance:C}");
            }
        }

        // Method to print current account information
        public new void PrintAccountInformation()
        {
            base.PrintAccountInformation();
            Console.WriteLine($"Overdraft Limit: {OverdraftLimit:C}");
        }
    }
}
