using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.model
{
    internal class CurrentAccount:Account
    {
        const double overDraftLimit = -100.00;
        public CurrentAccount(int accountNumber, double accountBalance) : base(accountNumber, "Current", accountBalance)
        {
        }

        
        public override void Withdrawal(double amount)
        {
            if (amount > 0)
            {
                if (amount <= AccountBalance || amount <= - overDraftLimit)
                {
                    AccountBalance -= amount;
                    Console.WriteLine($"Withdrawal of {amount} successful. New balance: {AccountBalance}");
                }
                else
                {
                    Console.WriteLine("Insufficient funds.");
                }
            }
            else
            {
                Console.WriteLine("Invalid withdrawal amount.");
            }
        }
    }
}
