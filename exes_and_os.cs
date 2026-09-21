using System.Linq;
using System;
public static class Kata 
{
  public static bool XO (string input) => input.ToLower().Split('o').Length == input.ToLower().Split('x').Length;
}