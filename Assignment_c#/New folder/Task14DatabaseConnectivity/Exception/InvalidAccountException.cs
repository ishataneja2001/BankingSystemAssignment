using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14DatabaseConnectivity.Exception
{
    internal class InvalidAccountException :IOException
    {
        public InvalidAccountException(): base("Invalid Account ID")
        {

        }
        public InvalidAccountException(string message): base(message)
        {

        }
    }
}
