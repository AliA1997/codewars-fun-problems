using System;

public static class Kata
{
  public static string AddBinary(int a, int b)
  {
    var result = a + b;
    
    // By 2, which would mean by 0 - 1.
    return Convert.ToString(result, 2);
  }
}