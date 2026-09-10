using System;
using System.Text;
public static class Kata
{
  public static string[] Capitalize(string s)
  {
    var evenCapitalizedResult = new StringBuilder();
    var oddCapitalizedResult = new StringBuilder();
    
    
    var idx = 0;
    foreach(char ch in s) {
      bool isEven = idx == 0 || idx % 2 == 0;
      bool isOdd = !isEven;
      var capitalizedChar = char.ToUpper(ch);
      if(isEven) 
      {
        evenCapitalizedResult.Append(capitalizedChar);
        oddCapitalizedResult.Append(ch);
      }
      else
      { 
        oddCapitalizedResult.Append(capitalizedChar);
        evenCapitalizedResult.Append(ch);
      }
      idx++;
    }
    
    return new string[] { evenCapitalizedResult.ToString(), oddCapitalizedResult.ToString() };
  }
}