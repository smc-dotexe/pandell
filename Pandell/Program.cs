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
                List<int> randomizedNumbers = listOfNumbers.RandomizeList();

                foreach (int num in randomizedNumbers)
                {
                    Console.WriteLine(num);
                }

                Console.WriteLine("List length: " + randomizedNumbers.Count);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
