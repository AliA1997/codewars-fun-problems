using System;
using System.Collections.Generic;
using System.Linq;

public class Remover
{
  public static List<int> RemoveSmallest(List<int> numbers)
  {
    // Good Luck!
    // Removes exhibits with the lowest ratings
    if(numbers.Count() == 0)
      return new List<int>();
    
    var result = new List<int>(numbers);
    
    var minNumInList = result.Min();

    var index = result.FindIndex(n => n == minNumInList);
    result.RemoveAt(index);
    
    return result;
  }
}