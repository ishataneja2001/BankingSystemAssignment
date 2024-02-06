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
    internal class BankService: CustomerService, IBankService
    {
        private Collection<Account> accounts = new Collection<Account>();
        //public HashSet<Acccount> account = new HashSet<Account>();
        //public Dictionary<int,Account> idAccountDict = new Dictionary<int,Account>();
        private string branchName;
        private string branchAddress;

        public BankService(ICustomerRepo customerRepo, Collection<Account> accounts, string branchName, string branchAddress)
            : base(customerRepo)
        {
            this.accounts = accounts;
            this.branchName = branchName;
            this.branchAddress = branchAddress;
        }

        public new void CreateAccount(Customer customer, string accType, decimal balance)
        {


            // Add the created account to the account list
            Account newAccount = new Account(accType, balance, customer );
                
            accounts.Add(newAccount);

        }

        public new Collection<Account> ListAccounts()
        {
            return accounts;
        }

        public new void CalculateInterest()
        {
            
            Console.WriteLine("Calculating interest for all accounts in the bank.");
        }
    }
}
