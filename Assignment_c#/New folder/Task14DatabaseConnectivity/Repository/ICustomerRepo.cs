using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task14DatabaseConnectivity.Model;

namespace Task14DatabaseConnectivity.Repository
{
    internal interface ICustomerRepo
    {
        double get_account_balance(long account_id);

        double Deposit(long account_id, float amount);

        decimal Withdraw(long amount_id, float amount);

        bool Transfer(long from_acc_id, long to_acc_id, float amount);

        Collection<object> GetAccountDetails(long account_id);

        List<Transactions> GetTransactions(DateTime startDate, DateTime endDate);

    }
}
