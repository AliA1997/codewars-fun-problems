using System.Text;
namespace Solution
{
  public static class Program
  {
    public static string RepeatStr(int n, string s)
    {
      // Preallocated memory capacity for better performance.
      // A normal loop would continue to destroy the old string when appending to existing string literal. 
      // Stringbuilder is more performant since it bypasses this issue completely.
      var sb = new StringBuilder(s.Length * n);
      
      for(var i = 0; i < n; i++) {
        sb.Append(s);
      }
      return sb.ToString();
    }
  }
}