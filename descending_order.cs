using System;
using System.Linq;
using System.Collections.Generic;

public static class Kata
{
  public static int DescendingOrder(int num) => int.Parse(string.Join("", num.ToString().ToCharArray().Select(n => int.Parse($"{n}")).OrderByDescending(n => n)));
}
