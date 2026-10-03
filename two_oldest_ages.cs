using System;
using System.Linq;

public class LargestTwo
{
    public static int[] TwoOldestAges(int[] ages)
    {
        var oldIdx = Array.IndexOf(ages, ages.Max());
        var oldest = ages[oldIdx];
        ages = ages.Where((a, idx) => idx != oldIdx).ToArray();
        var secondOldest = ages.Max();
      
        return new int[2] {secondOldest, oldest};
    }
}