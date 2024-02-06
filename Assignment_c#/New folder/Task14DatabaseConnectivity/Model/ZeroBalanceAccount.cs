using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14DatabaseConnectivity.Model
{
    internal class ZeroBalanceAccount : Accounts
    {
        public ZeroBalanceAccount(int accountId, int customerId) : base(accountId, customerId, "ZeroBalance", 0)
        {
            // No additional attributes for ZeroBalanceAccount
        }
    }
}
