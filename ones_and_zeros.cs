using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;


namespace Solution
{
  class Kata
    {
      public static int binaryArrayToNumber(int[] BinaryArray) => Convert.ToInt32(string.Join("", BinaryArray.Select(n => n.ToString()).ToArray()), 2);
    }
}