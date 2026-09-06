public class Kata
{
    public static int Find(int[] integers)
    {
      
      var oddCounter = 0;
      var lastOddNumIdx = -1;
      var evenCounter = 0;
      var lastEvenNumIdx = -1;
      for(var i = 0; i < integers.Length; i++) {
        var intNum = integers[i];
        
        if(intNum == 0 || intNum % 2 == 0) {
          evenCounter++;
          lastEvenNumIdx = i;
        } else  {
          oddCounter++;
          lastOddNumIdx = i;
        }
        
        // Once it hits 3 numbers, and the even counter is greater than zero and odd counter is greater than zero, check the outlier.
        if(i >= 2 && evenCounter > 0 && oddCounter > 0) {
          if(evenCounter > oddCounter) return integers[lastOddNumIdx];
          if(oddCounter > evenCounter) return integers[lastEvenNumIdx];
        }
          
      }
      
      return -1;
    
    }
  

}