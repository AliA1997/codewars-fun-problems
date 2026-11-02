using System;
using System.Linq;
using System.Collections.Generic;
public class Predicter
{
    public static int PredictAge(int age1, int age2, int age3, int age4, int age5, int age6, int age7, int age8){
      var paramsList = new List<int> { age1, age2, age3, age4, age5, age6, age7, age8 };
      // multiply each number by itself
      // add them together.
      // square root of result. / 2
      var sum = paramsList.Select(n => (double)(n * n)).Aggregate(0.0d, (acc, n) => acc += n);
      
      return (int)(Math.Sqrt(sum)/2d);
      
    }
}