using System;
using System.IO;

public class Kata
{
  public static int? FoldTo(double distance)
  {
    Console.Write(distance);
    if(distance < 0 || double.IsNaN(distance))
      return null;
    
    
    // Fold a paper using 0.0001m thickness
    var foldPaperThickness = 0.0001;
    var currAmt = foldPaperThickness;
    var currentFold = 0;
    
    while(currAmt < distance){
      currAmt *= 2;
      currentFold += 1;
    }
        
    return currentFold;
  }
}