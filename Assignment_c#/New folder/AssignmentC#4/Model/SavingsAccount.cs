using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTask1112.Model
{
    internal class SavingsAccount:Account
    {
        private decimal interestRate;

        
        public SavingsAccount(decimal interestRate, Customer accountOwner) : base("Savings", 500, accountOwner)
        {
            this.InterestRate = interestRate;
        }

        // Property for interest rate
        public decimal InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }

        // Method to print savings account information
        public new void PrintAccountInformation()
        {
            base.PrintAccountInformation();
            Console.WriteLine($"Interest Rate: {InterestRate}%");
        }
    }
}
