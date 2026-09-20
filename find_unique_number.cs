using System.Collections.Generic;
using System.Linq;

public class Kata
{
  public static int GetUnique(IEnumerable<int> numbers)
  {
    var max = numbers.Max();
    var maxCounter = 0;
    var min = numbers.Min();
    var minCounter = 0;
    var result = 0;
    
    foreach(var n in numbers) {
      if(n == max)
        maxCounter++;
      else
        minCounter++;
      
      if(minCounter > 1)
        result = max;
      
      if(maxCounter > 1)
        result = min;
      
      if(minCounter > 1 || maxCounter > 1)
        break;
    }
    
    return result;
  }
}