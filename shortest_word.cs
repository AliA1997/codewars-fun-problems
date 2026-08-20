public class Kata
{
  public static int FindShort(string s)
  {
    var words = s.Split(" ");
    if(words.Length < 1) return 0;
    if(words.Length == 1) return words[0].Length;
    
    string shortestWord = words[0];
    
    foreach(var w in words){
      if(shortestWord.Length > w.Length)
        shortestWord = w;
    }
    
    return shortestWord.Length;
  }
}