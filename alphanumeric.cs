using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Kata
{
  public static bool Alphanumeric(string str)
  {
    if(str == string.Empty)
      return false;
    // your code here
    var nullStrings = new string[] {"nil", "null", "NULL", "None", " "};
    
    bool isAlphanumeric = Regex.IsMatch(str, @"^[a-zA-Z0-9]+$");
    
    return (
      !str.ToCharArray().Select(c => c.ToString()).Any(s => nullStrings.Contains(s))
      && isAlphanumeric
    );
  }
}