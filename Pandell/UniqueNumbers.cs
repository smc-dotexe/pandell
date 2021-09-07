using System;
using System.Collections.Generic;
using System.Text;

namespace Pandell
{
    public class UniqueNumbers : BaseProperties
    {
        public static HashSet<int> GenerateUniqueNumbers()
        {
            HashSet<int> generatedNumbers = new HashSet<int>(ListCapacity);
            
            Random randomNumber = new Random();

            while (generatedNumbers.Count <= 9999)
            {
                generatedNumbers.Add(randomNumber.Next(0, ListCapacity));
            }

            return generatedNumbers;
        }
    }
}
