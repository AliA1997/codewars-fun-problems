using System;
using System.Linq;

class SumParts
{

    public static int[] PartsSums(int[] ls)
    {
      // Sum of parts meaning, sum everything the array, then remove one item. Then sum parts of remaining, and then remove, until the array is empty.
      int[] result = new int[ls.Length + 1];
      
      // Every last item would be 0, note indexes start at 0
      result[ls.Length] = 0;

      // your code
      for(var i = ls.Length - 1; i >= 0; i--){
        // Have two pointers, one pointer at current result set(source of truth) and another pointer at the result. 
        // By the default set the last item of the result to zero
        // At each iteration point the i pointer, plus one to result item to add to.
        result[i] = ls[i] + result[i + 1];
      }
      return result;
    }
}