using System;
using System.Collections.Generic;

public static class Kata
{
  // return masked string
  public static string Maskify(string cc)
  {
    // Take a string, and make the only last 4 character not be a hashtag(#)
    
    var ccArr = cc.ToCharArray();
    if(ccArr.Length > 4){
      var numbersNotMasked = ccArr.Length - 4;
      var ccMasked = ccArr[..numbersNotMasked];
      var ccUnmasked =  string.Join("", ccArr[numbersNotMasked..]);
      Array.Fill(ccMasked, '#');
      return string.Join("", ccMasked) + ccUnmasked;
    } else {
      return cc;
    }
  }
}
