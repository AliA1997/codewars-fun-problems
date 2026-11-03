using System;
using System.Linq;
public static class Kata
{
    public static int MissingNo(int[] nums)
    {
        var sumOfNumbers1To100 = Enumerable.Range(1, 100).Sum(); // O(1) Space complexity -> O(n) Time ocmplexity
         var sumOfCurrentNumbers = nums.Sum(); // O(1) Space complexity -> O(n) Time ocmplexity
      
        return sumOfNumbers1To100 - sumOfCurrentNumbers;
    }
}