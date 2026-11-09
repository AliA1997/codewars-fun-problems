using System;
using System.Collections.Generic;
using System.Linq;

public static class Kata
{
  public static string Likes(string[] name)
  {
    var endingText = " like this";
    if(name.Length == 0)
      return "no one likes this";
    
    if(name.Length == 1)
      return $"{name[0]} likes this";
    else if(name.Length == 2)
      return string.Join(" and ", name) + endingText;
    else if(name.Length == 3)
      return $"{name[0]}, {name[1]} and {name[2]}" + endingText;
    else
      return $"{name[0]}, {name[1]} and {name.Length - 2} others" + endingText;
    
  }
}