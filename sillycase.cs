using System;

public static class Kata
{
    public static string SillyCase(string str)
    {
        // Round half up for odd lengths: 5 / 2.0 = 2.5 -> Ceiling becomes 3
        int mid = (int)Math.Ceiling(str.Length / 2.0);
        
        string firstHalf = str[..mid].ToLower();
        string secondHalf = str[mid..].ToUpper();
        
        return firstHalf + secondHalf;
    }
}