using Pandell.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace Pandell.Tests
{
    public class ListOfNumbersTests
    {
        private readonly List<int> _listOfNumbers = new List<int>();
        public int minList = 0;
        public int maxList = 10000;
        public ListOfNumbersTests()
        {
            ListOfNumbers _listInitial = new ListOfNumbers(minList, maxList);
            _listOfNumbers = _listInitial.RandomizeList();
        }

        [Fact]
        public void VerifyNoDuplicatesInList()
        {
            List<int> duplicateNumbersList = _listOfNumbers.GroupBy(num => num)
              .Where(groupOfDuplicateNums => groupOfDuplicateNums.Count() > 1)
              .Select(duplicateNum => duplicateNum.Key)
              .ToList();

            Assert.Empty(duplicateNumbersList);
        }

        [Fact]
        public void VerifyListLength()
        {
            Assert.Equal(maxList, _listOfNumbers.Count);
        }

        [Fact]
        public void NegativeExceptionThrown()
        {
            ListOfNumbers list = new ListOfNumbers(-100, -200);

            var ex = Assert.Throws<NegativeException>(() => list.RandomizeList());

            Assert.Equal("Inputs can't be negative", ex.Message);
        }

        [Fact]
        public void RangeExceptionThrown()
        {
            ListOfNumbers list = new ListOfNumbers(100, 10);

            var ex = Assert.Throws<RangeException>(() => list.RandomizeList());

            Assert.Equal("Minimum range must be less than Maximum range", ex.Message);
        }
    }
}
