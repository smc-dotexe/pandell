using Pandell.Exceptions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Pandell
{
    public class BaseProperties
    {
        public BaseProperties(int minList, int maxList)
        {
            MinList = minList;
            MaxList = maxList;
        }

        public static int MaxList { get; set; }
        public static int MinList { get; set; }
    }
}
