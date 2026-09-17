using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;

public class JohnMeeting
{
	public static string Meeting(string s) {
    // Seperate each name 
    // format name
    // return result
    string[] arr = s.Split(';');
    var result = new List<string>();
    foreach(var fullName in arr) {
      var names = fullName.Split(':');
      var firstName = names[0].ToUpper();
      var lastName = names[1].ToUpper();
      
      result.Add($"({lastName}, {firstName})");
    }
		return string.Join("", result.OrderBy(n => n).ToArray());
	}
}