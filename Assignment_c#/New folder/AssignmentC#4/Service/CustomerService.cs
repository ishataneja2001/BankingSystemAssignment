using AssignmentTask1112.Model;
using AssignmentTask1112.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTask1112.Service
{
    internal class CustomerService:ICustomerService
    {
        private ICustomerRepo customerRepo;

        public CustomerService(ICustomerRepo customerRepo)
        {
            this.customerRepo = customerRepo;
        }

        public decimal GetAccountBalance(long accountNumber, Collection<Account> accounts)
        {
            return customerRepo.GetAccountBalance(accountNumber,accounts);
        }

        public decimal Deposit(long accountNumber, decimal amount, Collection<Account> accounts)
        {
            return customerRepo.Deposit(accountNumber, amount, accounts);
        }

        public decimal Withdraw(long accountNumber, decimal amount, Collection<Account> accounts)
        {
            return customerRepo.Withdraw(accountNumber, amount, accounts);
        }

        public void Transfer(long fromAccountNumber, long toAccountNumber, decimal amount, Collection<Account> accounts)
        {
            customerRepo.Transfer(fromAccountNumber, toAccountNumber, amount, accounts);
        }

        public string GetAccountDetails(long accountNumber,Collection<Account> accounts)
        {
            return customerRepo.GetAccountDetails(accountNumber , accounts);
        }

        
    }
}
