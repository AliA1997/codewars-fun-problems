namespace myjinxin
{
    using System.Threading.Tasks;
    using System;
    
    public class Kata
    {
        public int Lamps(int[] a){
 
            if (a == null || a.Length < 1) return 0;
 
            var mismatchesStartingWithZero = 0;
            for (var i = 0; i < a.Length; i++)
            {
                var expected = i % 2; // 0,1,0,1,...
                if (a[i] != expected) mismatchesStartingWithZero++;
            }
 
            var mismatchesStartingWithOne = a.Length - mismatchesStartingWithZero;
 
            return Math.Min(mismatchesStartingWithZero, mismatchesStartingWithOne);
        }
    }
}