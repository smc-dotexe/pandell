using System;
using System.Collections.Generic;
using System.Text;

namespace Pandell.Exceptions
{
    public class NegativeException : Exception
    {
        public NegativeException(string message) : base(message) { }
    }
}
