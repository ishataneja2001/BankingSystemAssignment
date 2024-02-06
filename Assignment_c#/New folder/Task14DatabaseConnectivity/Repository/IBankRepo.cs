using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task14DatabaseConnectivity.Model;

namespace Task14DatabaseConnectivity.Repository
{
    internal interface IBankRepo
    {
        bool Create_Account(Customers customer, string account_type, float balance);

        List<Accounts> ListAccounts();


    }
}
