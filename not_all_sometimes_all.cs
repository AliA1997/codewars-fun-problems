using System.Collections.Generic;
using System.Text.RegularExpressions;

public class Kata
{
  public static string Remove(string str, Dictionary<char,int> what)
  {
    var result = str;
    foreach(var k in what.Keys){
      var regexToCompare = new Regex(k.ToString());
      result = regexToCompare.Replace(result, (match) => "", what[k]);
      
    }
    return result;
  }
}