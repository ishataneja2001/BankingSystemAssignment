using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14DatabaseConnectivity.Service
{
    internal interface IBankService
    {
        public void Create_Account(); 

        public void ListAccount();
    }
}
