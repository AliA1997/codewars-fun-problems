public class Kata 
{
  public static int BreakChocolate(int n, int m) 
  {
    //     breaks = n x m - 1
    //     5 by 5 is 25 total pieces, you can break the chocolate into 24 times.
    var totalBreaks = (n * m) - 1;
    if(totalBreaks < 1)
      return 0;
    return totalBreaks;
  }
}