using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14DatabaseConnectivity.Model
{
    internal class Transactions
    {
        public int TransactionId { get; set; } // Primary Key
        public int AccountId { get; set; } // Foreign Key
        public string TransactionType { get; set; }
        public decimal Amount { get; set; }
        public DateTime TransactionDate { get; set; }

        // Constructor
        public Transactions(int transactionId, int accountId, string transactionType, decimal amount, DateTime transactionDate)
        {
            TransactionId = transactionId;
            AccountId = accountId;
            TransactionType = transactionType;
            Amount = amount;
            TransactionDate = transactionDate;
        }

        // Default Constructor
        public Transactions()
        {
            
        }
        public override string ToString()
        {
            return $"TransactionId: {TransactionId}\t AccountID:{AccountId}\t TransactionType: {TransactionType}\t Amount: {Amount}\t TransactionDate: {TransactionDate}";
        }

    }
}
