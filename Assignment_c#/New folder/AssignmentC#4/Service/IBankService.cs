using AssignmentTask1112.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTask1112.Service
{
    internal interface IBankService:ICustomerService
    {
        void CreateAccount(Customer customer, string accType, decimal balance);
        
        void CalculateInterest();
    }
}
