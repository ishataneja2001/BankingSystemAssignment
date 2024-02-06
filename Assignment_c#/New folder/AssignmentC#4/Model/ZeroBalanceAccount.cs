using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTask1112.Model
{
    internal class ZeroBalanceAccount:Account
    {
        public ZeroBalanceAccount(Customer accountOwner) : base("ZeroBalance", 0, accountOwner)
        {
           
        }

        
        public new void PrintAccountInformation()
        {
            base.PrintAccountInformation();
        }
    }
}
