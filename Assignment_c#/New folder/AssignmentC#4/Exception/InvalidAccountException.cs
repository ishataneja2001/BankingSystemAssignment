﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentTask1112.Exception
{
    internal class InvalidAccountException : IOException
    {
        public InvalidAccountException(string message): base(message) 
        {

        }
    }
}
