using System;
using System.Collections.Generic;
using System.Text;

namespace Pandell
{
    public class UniqueNumbers
    {
        public static HashSet<int> GenerateUniqueNumbers()
        {
            HashSet<int> generatedNumbers = new HashSet<int>(10000);
            
            Random randomNumber = new Random();

            while (generatedNumbers.Count <= 9999)
            {
                generatedNumbers.Add(randomNumber.Next(0, 10000));
            }

            return generatedNumbers;
        }
    }
}
