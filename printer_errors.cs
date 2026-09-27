using System;
using System.Text.RegularExpressions;
using System.Linq;
using System.Collections.Generic;

public class Printer 
{
    public static string PrinterError(String s) 
    {
        // your code
      char[] sArr = s.ToCharArray();
      var errorCounter = 0;
      foreach(var nChar in s) {
        if(!Regex.IsMatch(nChar.ToString(), "[a-m]"))
          errorCounter++;
      }
      
      return $"{errorCounter.ToString()}/{sArr.Length.ToString()}";
    }
}