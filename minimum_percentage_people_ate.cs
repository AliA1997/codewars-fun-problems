using System;
using System.Linq;

public class Kata
{
  public static int MinimumPercentage(int[] foods)
  {

    // Popcorn 76%
    // Hot Dogs - 50%
    // Cotton Candy - 50%
    // Max Percentage of visitors ate both items be 50%
    // Minimum percentage of 0% ate both items
    // 65 + 80 + 80 + 90
    
    // Add up the totals then subtract from n(number of foods) - 1 * 100(represents 100 percent) 
    var n = foods.Length;
    var totals = foods.Aggregate(0, (acc, f) => acc += f);
    var threshold = (n - 1) * 100;
    var peopleDidntEat = totals - threshold;
    
    if(peopleDidntEat <= 0) 
      return 0;
    
    return peopleDidntEat;
  }
}