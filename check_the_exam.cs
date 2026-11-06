using System;
using System.Linq;
using System.Collections.Generic;
public static class Kata
{
    //Compare questions and answers,and ruseturn the score. if the score is less than zero return 0
    public static int CheckExam(string[] arr1, string[] arr2) => 
      Math.Max(( 
         arr1.Zip(arr2, (f, s) => new { f, s })
            .Where(val => val.f == val.s)
            .Select((p) => p.f)
            .ToArray()
            .Length * 4) - 
        (arr1.Length - arr1.Zip(arr2, (f, s) => new { f, s })
            .Where(val => val.f == val.s || val.f == string.Empty || val.s == string.Empty)
            .Select((p) => p.f)
            .ToArray()
            .Length), 0);
}