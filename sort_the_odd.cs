using System;
using System.Collections.Generic;
using System.Linq;

public class Kata
{
    public static int[] SortArray(int[] array)
    {
        // 1. Local function to check if a number is odd
        // Handles negative numbers correctly (e.g., -5 % 2 yields -1)
        static bool IsOdd(int num) => num % 2 != 0;

        // 2. Extract and sort only the odd numbers into a Queue
        var sortedOdds = new Queue<int>(array.Where(IsOdd).OrderBy(n => n));

        // 3. Re-build or modify the array in-place
        for (int i = 0; i < array.Length; i++)
        {
            if (IsOdd(array[i]))
            {
                // Dequeue pulls out the smallest remaining sorted odd number
                array[i] = sortedOdds.Dequeue();
            }
        }

        return array;
    }
}