using System;
using System.Text.RegularExpressions;

public class Kata
{
  public static bool ValidatePin(string pin)
  {
    //string like "1234\n56" or "1234\n" can cause unexpected behavior or partial matches depending on how it's evaluated, because $ looks at line endings rather than the absolute end of the entire input.
      return Regex.IsMatch(pin, @"\A(?:\d{4}|\d{6})\z");
  }
}