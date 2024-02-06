using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.model
{
    internal class Account
    {
        public int AccountNumber { get; set; }
        public string? AccountType { get; set; }
        public double AccountBalance { get; set; }

        //default constructure
        public Account() 
        {

        }
        //overload constructor with acc
        public Account(int accountNumber, string accountType, double accountBalance)
        {
            AccountNumber = accountNumber;
            AccountType = accountType;
            AccountBalance = accountBalance;
        }
        public void DisplayAccountDetails()
        {
            Console.WriteLine($"AccountNumber::{AccountNumber}\nAccountType(Savings or Current)::{AccountType}\nAccountBalance::{AccountBalance}");
        }
        //overloaded deposite
        public void Deposit(int amount)
        {
            Deposit((double)amount);
        }
        //overloaded withdrawal
        public void Withdrawal(int amount)
        {
            Withdrawal((double)amount);
        }
        public  void Deposit(float amount)
        {
            Deposit((double)amount);
        }
        public void Withdrawal(float amount)
        {
            Withdrawal((double)amount);
        }
        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                AccountBalance += amount;
                Console.WriteLine($"Deposite of {amount} successful. New balance is {AccountBalance}");
            }
            else 
            {
                Console.WriteLine("Invalid deposite amount");
            }

            
        }
        public virtual void Withdrawal(double amount)
        {
            if (amount <= AccountBalance)
            {
                AccountBalance -= amount;
                Console.WriteLine($"Withdrawal of {amount} successful . New balance is {AccountBalance}");
            }
            else
            {
                Console.WriteLine("insufficient fund");
            }
        }
        public virtual void Calculate_Interest()
        {
            if (AccountType == "Savings")
            {
                double interestRate = 0.045; //4.5%
                double interestAmount = AccountBalance * interestRate;
                AccountBalance += interestAmount;
                Console.WriteLine($"Interest of {interestAmount} added. New account balance is {AccountBalance}");
            }
            else
            {
                Console.WriteLine("Interest calculation is only valid to Saving account");
            }
        }

    }
}
