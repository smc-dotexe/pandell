# Pandell Code Challenge
**Instructions**: Write a program that generates a list of 10,000 numbers in random order each time it is run. Each number in the list must be unique and be between 1 and 10,000 (inclusive).

**Built With**: 
* Windows 10
* Visual Studio 2019 
* .Net Core Console App 3.1
* XUnit 2.4.0

## Project Solution 
**_First Approach_**: 

Initially I used a HashSet in which I randomized numbers using the Random class in a While loop. Since Hashets doesn't store duplicates, I thought it would be a good way to not have to iterate over a List and check if the number already exists or not. I would then use the .CopyTo method and add the unique numbers to the List as the final solution.
The problems with this approach is the possibility of the Random.Next method generating a duplicate, which will effect the time complexity by having to create another number that doesn't already exist in the HashSet. The other problem is the creation of two Collections (HashSet and the List) which is inefficient and takes up more space. 

**_Refactored_**: 

After researching about randomizing a list, I found out about the Durstenfield Shuffle Algorithm (which is implemented in ListOfNumbers.cs Line 21). This is a much more efficient approach since it's now using only 1 List and randomizing the values in it. The time complexity for running this algorithm is O(N) since it depends how large the range is.
