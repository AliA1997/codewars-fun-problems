using System;

public static class Kata
{
  public static int[] ReverseSeq(int n)
  {
    var result = new int[n];
    var idx = 0;
    for(var i = n; i > 0; i--)
    {
      result[idx] = i;
      idx++;
    }
    
    return result;
  }
}