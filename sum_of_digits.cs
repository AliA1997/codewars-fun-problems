using System;
using System.Linq;
using System.Collections.Generic;

public class Number
{
  public static int DigitalRoot(long n)
  {
    // Your awesome code here!
    // SPlit the numbers to individual numbers
    var numbers = n.ToString().ToCharArray().Select(n => n.ToString()).ToList();
    
    // Current Summed numbers
    var currentSum = numbers.Select(ni => int.Parse(ni.ToString())).Aggregate(0, (acc, n) => acc+=n);
        
    while(!(currentSum < 10 && currentSum % 1 == 0)) {
      currentSum = currentSum.ToString().ToCharArray().Select(n => n.ToString()).Select(n => int.Parse(n)).Aggregate(0, (acc, n) => acc+= n);
    }
      
    return currentSum;
    
  }
}