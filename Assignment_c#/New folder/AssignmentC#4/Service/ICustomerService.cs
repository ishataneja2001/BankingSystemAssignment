using AssignmentTask1112.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTask1112.Service
{
    internal interface ICustomerService
    {
        decimal GetAccountBalance(long accountNumber, Collection<Account> accounts);
        decimal Deposit(long accountNumber, decimal amount, Collection<Account> accounts);
        decimal Withdraw(long accountNumber, decimal amount, Collection<Account> accounts);
        void Transfer(long fromAccountNumber, long toAccountNumber, decimal amount, Collection<Account> accounts);
        string GetAccountDetails(long accountNumber, Collection<Account> accounts);
    }
}
