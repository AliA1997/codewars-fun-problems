using System;
using System.Collections.Generic;

public class Kata
{
  public static bool IsIsogram(string str) => new HashSet<char>(str.ToLower().ToCharArray()).Count == str.Length;
}