using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14DatabaseConnectivity.Exception
{
    internal class OverDraftLimitExcededException:IOException
    {
        public OverDraftLimitExcededException() : base("OverDraft limit excededException ")
        {

        }
        public OverDraftLimitExcededException(string message): base(message)
        {

        } 


    }
}
