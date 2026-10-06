using System;
using System.Linq;
using System.Collections.Generic;


public class NthSeries {
	
	public static string seriesSum (int n) {
		// Happy Coding ^_^
    var arrayOfDecimals = new List<decimal>();
    // First value is 1
    decimal currentValue = 0;
    for(var i = 0; i < n; i++) {
      currentValue = (decimal)1/(1 + 3 * i);
      arrayOfDecimals.Add(currentValue);
    }
    var accumTotal = arrayOfDecimals.Aggregate((decimal)0.00, (ac, n) => ac += n);
    
    return $"{accumTotal:F2}";
	}
}