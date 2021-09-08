using Pandell.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pandell
{
    public class ListOfNumbers : BaseProperties
    {
        public static readonly List<int> listOfNumbers = Enumerable.Range(MinList, MaxList).ToList();
        public ListOfNumbers(int minList, int maxList) : base(minList, maxList) {}

        public List<int> RandomizeList()
        {
            ListOfNumbersExceptions.ParameterExceptions(MinList, MaxList);

            int lastIndex = listOfNumbers.Count - 1;
            Random random = new Random();

            while (lastIndex > 0)
            {
                int randomIndex = random.Next(MinList, MaxList);
                int temp = listOfNumbers[lastIndex];
                listOfNumbers[lastIndex] = listOfNumbers[randomIndex];
                listOfNumbers[randomIndex] = temp;
                lastIndex -= 1;
            }

            return listOfNumbers;
        }
    }
}
