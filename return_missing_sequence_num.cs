using System.Collections.Generic;

class Solution
{
    public int solution(int[] A)
    {
        var numbers = new HashSet<int>(A);

        for (int candidate = 1; candidate <= A.Length + 1; candidate++)
        {
            if (!numbers.Contains(candidate))
                return candidate;
        }

        return A.Length + 1;
    }
}