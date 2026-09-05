using System.Text;
using System.Collections.Generic;
using System.Linq;

public class Accumul 
{
    public static string Accum(string s) 
    {
        var result = new List<string> { s[0].ToString().ToUpper() };

        for(var i = 1; i < s.Length; i++) {
            char currentChar = s[i];

            // currentChar is already a char, so new string() works perfectly
            result.Add($"{char.ToUpper(currentChar)}{new string(char.ToLower(currentChar), i)}");
        }
        
        return string.Join("-", result);
    }
}