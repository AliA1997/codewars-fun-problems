using System;
public class Kata
{
  public static long FindNextSquare(long num)
  {
    // Check if it's a perfect square. 
    var root = (long)Math.Sqrt(num);
    if(root * root != num)
      return -1;
    
    var nextSquare = root + 1;
    
    return nextSquare * nextSquare;
  }
}