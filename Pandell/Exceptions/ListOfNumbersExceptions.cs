using System;
using System.Collections.Generic;
using System.Text;

namespace Pandell.Exceptions
{
    public static class ListOfNumbersExceptions
    {
        public static void ParameterExceptions(int minParam, int maxParam)
        {
            if (minParam < 0 || maxParam < 0)
                throw new NegativeException("Inputs can't be negative");
            if (minParam > maxParam || minParam == maxParam)
                throw new RangeException("Minimum range must be less than Maximum range");
        }
    }
}
