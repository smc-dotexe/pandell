using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Pandell.Tests
{
    public class ListOfNumbersTests
    {
        private List<int> _listOfNumbers = new List<int>();
        public ListOfNumbersTests()
        {
            _listOfNumbers = ListOfNumbers.InsertUniqueNumbersToList(UniqueNumbers.GenerateUniqueNumbers());
        }

        [Fact]
        public void VerifyNoDuplicatesInList()
        {

            List<int> duplicateQuery = _listOfNumbers.GroupBy(num => num)
              .Where(groupOfDuplicateNums => groupOfDuplicateNums.Count() > 1)
              .Select(duplicateNum => duplicateNum.Key)
              .ToList();

            Assert.Empty(duplicateQuery);
        }

        [Fact]
        public void VerifyListLength()
        {
            Assert.Equal(10000, _listOfNumbers.Count);
        }
    }
}
