using System;
using System.Collections.Generic;
using System.Linq;


namespace Solution
{
  public class NumItem {
    public int Val { get; set; }
    public int Counter { get; set; }
  }
  class Kata
    {
      public static int find_it(int[] seq) 
      {
          var seqInfo = seq.Aggregate(new List<NumItem>(){}, (acc, n) => {
            var idxOfA = acc.FindIndex(a => a.Val == n);
            if(idxOfA != -1)
              acc[idxOfA].Counter++;
            else 
              acc.Add(new NumItem() { Val = n, Counter = 1 });
            
            return acc;
          });
        
          return seqInfo.First(n => !(n.Counter % 2 == 0)).Val;
//           // Find a number that appears an odd number of times.
//           var uniqueValues = new HashSet<int>(seq);

//           // Get the unique values, n squared.
//           foreach(int uV in uniqueValues) 
//           {
//             var numberOfTimesOfUniqueValue = seq.Where(s => s == uV).Count();

//             if(!(numberOfTimesOfUniqueValue % 2 == 0))
//               return uV;

//             continue;
//           }
        
//           return 0;
        }
       
    }
}