using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14DatabaseConnectivity.Service
{
    internal interface ICustomerService
    {
        public void get_account_balance();

        public void Deposit();

        public void Withdraw();

        public void Transfer();

        public void GetAccountDetails();

        public void GetTransactions();
    }
}
