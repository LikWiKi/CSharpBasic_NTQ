﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Exceptions
{
    class MyException : ApplicationException
    {
        public MyException(string message)
            : base(message)
        {
        }
    }
}
