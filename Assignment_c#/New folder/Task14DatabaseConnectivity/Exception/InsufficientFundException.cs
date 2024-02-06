using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14DatabaseConnectivity.Exception
{
    internal class InsufficientFundException:IOException
    {
        public InsufficientFundException() : base("Insufficient Funds in the account")
        {

        }
        public InsufficientFundException(string message) : base(message)
        {
        }
    }
}
