using System;
using System.Collections.Generic;
using System.Text;

namespace Pandell
{
    public class ListOfNumbers
    {
        public static List<int> InsertUniqueNumbersToList(HashSet<int> uniqueNumbers)
        {
            List<int> listOfNumbers = new List<int>(10000);
            foreach (int num in uniqueNumbers)
            {
                listOfNumbers.Add(num);
            }

            return listOfNumbers;
        }
    }
}
