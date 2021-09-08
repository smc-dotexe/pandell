using System;
using System.Collections.Generic;

namespace Pandell
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ListOfNumbers listOfNumbers = new ListOfNumbers(0, 10000);
                List<int> listOfUniqueNumbers = listOfNumbers.RandomizeList();

                foreach (int num in listOfUniqueNumbers)
                {
                    Console.WriteLine(num);
                }

                Console.WriteLine("List length: " + listOfUniqueNumbers.Count);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
