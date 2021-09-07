using System;
using System.Collections.Generic;

namespace Pandell
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listOfUniqueNumbers = ListOfNumbers.InsertUniqueNumbersToList(UniqueNumbers.GenerateUniqueNumbers());

            foreach (int num in listOfUniqueNumbers)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("list length: " + listOfUniqueNumbers.Count);
        }
    }
}
