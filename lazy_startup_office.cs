using System;
using System.Linq;
using System.Collections.Generic;

public class Kata
{
    public static string[] BinRota(string[][] matrix)
    {
      var result = new List<string>();
      
      // Take a multidimensional array
      // first value inserted to result would be first, last, first, last, first, last, etc.
      // Loop through each items in the multi-dimensional array
      // If the items is a even number. Reverse the item in the array, since the last item would be the first item in the next sequence.
      for(var i = 0; i < matrix.Length; i++) {
        var arr = matrix[i];
        if((i + 1) % 2 == 0){
          Array.Reverse(arr);
          result.AddRange(arr);
        }
        else
          result.AddRange(arr.ToList());
      }

      return result.ToArray();
    }
}