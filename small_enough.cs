using System;
using System.Linq;
using System.Collections.Generic;
public class Kata
{
  public static bool SmallEnough(int[] a, int limit) => !a.ToList().Any(n => n > limit);
}