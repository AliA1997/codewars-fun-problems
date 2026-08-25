using System.Linq;

using System.Text;

using System.Collections.Generic;

using System.IO;

using System;

public static class Kata

{

  public static bool Narcissistic(int value)

  {

    // Code me

    var valueStringified = value.ToString();

    var digits = valueStringified.Split("");
    Console.WriteLine(digits);
    

    var powerOf = double.Parse(valueStringified.Count().ToString());
    Console.WriteLine(powerOf);

    double total = 0;

    

    foreach(var d in digits) {

      total += Math.Pow(double.Parse(d), powerOf);
        Console.WriteLine(total);

    }

      

    return total == value;

  }

}






public class Program
{
    public static void Main()
    {
        Kata.Narcissistic(153);

    }
}