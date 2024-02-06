using AssignmentTask1112.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTask1112.Model
{
    internal class CustomerNameComparer :IComparer<Account>
    {
        public int Compare(Account x, Account y)
        {
            string customerNameX = $"{x.AccountOwner.FirstName} {x.AccountOwner.LastName}";
            string customerNameY = $"{y.AccountOwner.FirstName} {y.AccountOwner.LastName}";
            return string.Compare(customerNameX, customerNameY, StringComparison.Ordinal);
        }
    }

}
