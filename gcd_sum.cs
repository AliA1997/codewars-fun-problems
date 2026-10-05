using System;
using System.Linq;
using System.Collections.Generic;

public class GCDsum
{
    public static (int,int) solve (int s, int g){         
      var divisor = s / g;      
      if(!(divisor % 1 == 0) || !(s % g == 0))
        return (-1, -1);
      
      if(divisor == 2)
        return (g, g);
      
      // Greatest Common Denominator in ascending order. 
      
      return (g, s - g);
      
    }        
}