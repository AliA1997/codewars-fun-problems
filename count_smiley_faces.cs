using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;


public static class Kata
{
  public static int CountSmileys(string[] smileys) => smileys.Count(face => Regex.IsMatch(face,  @"^[:;][-~]?[)D]$"));
}