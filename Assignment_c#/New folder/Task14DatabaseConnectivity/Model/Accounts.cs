using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14DatabaseConnectivity.Model
{
    internal class Accounts
    {
        public int AccountId { get; set; } // Primary Key
        public int CustomerId { get; set; } // Foreign Key
        public string AccountType { get; set; }
        public decimal Balance { get; set; }

        // Constructor
        public Accounts(int accountId, int customerId, string accountType, decimal balance)
        {
            AccountId = accountId;
            CustomerId = customerId;
            AccountType = accountType;
            Balance = balance;
        }

        // Default Constructor
        public Accounts()
        {
            
        }

        
        public override string ToString()
        {
            return $"AccountID: {AccountId}\t CustomerID:{CustomerId}\t AccountType:{AccountType}\t Balance:{Balance}";
        }
    }
}
