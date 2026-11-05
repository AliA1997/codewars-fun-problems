using System;
using System.Collections.Generic;
using System.Linq; // Added for LINQ extension methods

public class Kata
{
    public static string AlphabetWar(string fight)
    {
        // Left side power -> w = 4, p = 3, b = 2, s = 1
        // Right side power -> m = 4, q = 3, d = 2, z = 1
        var leftSideLetterArr = new char[] { 'w', 'p', 'b', 's' };
        
        // Changed List<object> to a strongly-typed List of ValueTuples
        var leftsideLetters = new List<(string Item1, int Item2)>() 
        { 
            new ("w", 4),
            new ("p", 3),
            new ("b", 2),
            new ("s", 1),  
        };
      
        var rightSideLettersArr = new char[] { 'm', 'q', 'd', 'z' };
      
        // Changed List<object> to a strongly-typed List of ValueTuples
        var rightsideLetters = new List<(string Item1, int Item2)>() 
        { 
            new ("m", 4),
            new ("q", 3),
            new ("d", 2),
            new ("z", 1),  
        };

        var rightTotal = 0;
        var rightResultArr = fight.ToCharArray().Where(a => rightSideLettersArr.Contains(a)).Select(c => c.ToString()).ToList();

        var leftTotal = 0;
        var leftResultArr = fight.ToCharArray().Where(a => leftSideLetterArr.Contains(a)).Select(c => c.ToString()).ToList();
      
        foreach(var l in leftResultArr) {
            var leftSideItem = leftsideLetters.First(li => li.Item1 == l);
            leftTotal += leftSideItem.Item2; // Removed ?? 0 since Item2 is a non-nullable int
        }
      
        foreach(var r in rightResultArr) {
            // Fixed typo: changed 'l' to 'r' inside the lambda
            var rightSideItem = rightsideLetters.First(ri => ri.Item1 == r);
            rightTotal += rightSideItem.Item2; // Removed ?? 0 since Item2 is a non-nullable int
        }
      
        if(rightTotal > leftTotal)
            return "Right side wins!";
        else if(leftTotal > rightTotal)
            return "Left side wins!";
        else
            return "Let's fight again!";
    }
}
