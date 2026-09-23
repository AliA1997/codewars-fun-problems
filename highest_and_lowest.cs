using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
  public static string HighAndLow(string numbers)
  {
    // Code here or
    // Return the largest and smaller number from a string.
    var numbersArr = numbers.Split().Select(n => int.Parse(n));
    
    return $"{numbersArr.Max().ToString()} {numbersArr.Min().ToString()}";
  }
}