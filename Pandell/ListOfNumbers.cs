using System;
using System.Collections.Generic;
using System.Text;

namespace Pandell
{
    public class ListOfNumbers : BaseProperties
    {
        public static List<int> InsertUniqueNumbersToList(HashSet<int> uniqueNumbers)
        {
            List<int> listOfNumbers = new List<int>(ListCapacity);
            foreach (int num in uniqueNumbers)
            {
                listOfNumbers.Add(num);
            }

            return listOfNumbers;
        }
    }
}
