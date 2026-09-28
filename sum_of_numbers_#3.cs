  using System;
  using System.Linq;
  public class Sum
  {
     public int GetSum(int a, int b)
     {
       //Good Luck!
       var maxValue = Math.Max(a, b);
       var minValue = Math.Min(a, b);
       var result = 0;
        for(var i = minValue; i <= maxValue; i++) {
          result += i;
        }
      
       return a == b ? a : result;
     }
  }