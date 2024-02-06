using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTask1112.Exception
{
    internal class OverDraftLimitExcededException : IOException
    {
        public OverDraftLimitExcededException(string message):base(message)
        {

        }
    }
}
