using System.Linq;
using System.Collections.Generic;
public class Kata
{
  public static int[] Divisors(int n)
  {
    
    var divisors = new List<int>();
    var counter = 2;
    
    //o(n/2)
    while((counter * 2) <= n) {
      if(n % counter == 0)
        divisors.Add(counter);
      
      counter++;
    }
    
    if(divisors.Count() == 0)
      return null;
  
    return divisors.ToArray();
    
  }
}