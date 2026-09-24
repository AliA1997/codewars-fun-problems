using System;
using System.Linq;
using System.Collections.Generic;

public class TwoToOne 
{
  
	public static string Longest (string s1, string s2) => string.Join("", new HashSet<char>($"{s1.Trim()}{s2.Trim()}".ToCharArray()).OrderBy(n => n));
}