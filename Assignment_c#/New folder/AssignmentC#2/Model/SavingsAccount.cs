using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentC_2.Model
{
    public class SavingsAccount : BankAccount
    {
        private double interestRate;

        public double InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }

        // Default constructor
        public SavingsAccount(string accountNumber,string customerName,decimal initialBalance) : base( accountNumber,  customerName,  initialBalance)
        {
            interestRate = 0.045;
        }

        // Overloaded constructor
        public SavingsAccount(string accountNumber, string customerName, decimal initialBalance, double interestRate)
            : base(accountNumber, customerName, initialBalance)
        {
            this.interestRate = interestRate;
        }

        public override void CalculateInterest()
        {
            decimal interest = balance * (decimal)interestRate;
            balance += interest;
            Console.WriteLine($"Interest calculated: {interest}. New balance: {balance}");
        }
    }
}

