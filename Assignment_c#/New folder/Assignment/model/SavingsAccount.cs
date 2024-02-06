using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.model
{
    internal class SavingsAccount:Account
    {
        double InterestRate ;
        public SavingsAccount(int accountNumber , double interestRate, double accountBalance) : base(accountNumber, "Savings", accountBalance)
        {
            InterestRate = interestRate;
        }
        public override void Calculate_Interest()
        {
            double interestAmount = AccountBalance * InterestRate;
            AccountBalance += interestAmount;
            Console.WriteLine($"Interest of {interestAmount} added. New balance is {AccountBalance}");
        }
    }
}
