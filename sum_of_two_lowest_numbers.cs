using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
	public static int sumTwoSmallestNumbers(int[] numbers)
	{
    var orderedNumbers = numbers.OrderBy(n => n).ToList();
    return orderedNumbers[0] + orderedNumbers[1]; 
	}
}