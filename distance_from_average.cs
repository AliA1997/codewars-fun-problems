using System;
using System.Linq;
using System.Collections.Generic;

public class Kata
{
    public static double[] DistancesFromAverage(int[] input)
    {
        //your code here
        // Get the addition or subraction for each .
        // First day would be the subtract or addtion to the average of the all days.
        // Average is all days divided by length of array.
        // Double using binary decimal numbers whi
        decimal average = input.Aggregate(0.00m, (acc, vl) => acc += vl) / input.Length;
        Console.WriteLine(average);
        double[] result = new double[input.Length];
        
        for(var i = 0; i < input.Length; i++){
          var itm = input[i];
          Console.WriteLine(itm);
          decimal differential = itm - average;
        
          result[i] = (double)(Math.Round(differential > 0 ? -differential : Math.Abs(differential), 2, MidpointRounding.AwayFromZero));
        }
      
        return result;
    }
}