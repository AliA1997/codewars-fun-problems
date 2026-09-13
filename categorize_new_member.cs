using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    private const string OpenCategory = "Open";
    private const string SeniorCategory = "Senior";
    
    private static string ReturnCategory(int age, int handicap) 
    {
      if(age >= 55 && handicap > 7)
        return SeniorCategory;
      else
        return OpenCategory;
    }
    public static IEnumerable<string> OpenOrSenior(int[][] data)
    {
      var result = new List<string>();
        //your code here
      foreach(var itm in data) {
        var age = itm[0];
        var handicap = itm[1];
        
        result.Add(ReturnCategory(age, handicap));
      }
      
      return result.ToList();
    }
}