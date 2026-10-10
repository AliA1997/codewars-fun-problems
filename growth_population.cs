using System;
class Arge {
    
    public static int NbYear(int p0, double percent, int aug, int p) {
        // your code
        var yearPassed = 0;
        var percentDecimal = percent/100;
        
        double currPopulation = p0; //3000
        while(currPopulation < (double)p) {        
            currPopulation += Math.Floor(currPopulation * percentDecimal);
            currPopulation += aug;
            yearPassed++;
        }
      
      return yearPassed;
    }
}