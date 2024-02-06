using AssignmentTask1112.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTask1112.Repository
{
    internal interface IBankRepo
    {
        void CreateAccount(Customer customer, long accNo, string accType, decimal balance);
        Account[] ListAccounts();
        void CalculateInterest();
    }
}
