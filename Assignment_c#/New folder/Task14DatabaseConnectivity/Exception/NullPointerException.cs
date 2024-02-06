using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task14DatabaseConnectivity.Exception
{
    internal class NullPointerException: IOException
    {
        public NullPointerException(): base ("Null Pointer")
        {

        }
        public NullPointerException(string message):base(message)
        {

        }
    }
}
