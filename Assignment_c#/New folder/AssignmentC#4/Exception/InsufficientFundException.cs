using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTask1112.Exception
{
    internal class InsufficientFundException : IOException
    {
        public InsufficientFundException(string message): base(message)
        {

        }
    }
}
