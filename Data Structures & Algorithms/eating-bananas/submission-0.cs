public class Solution {
    public int MinEatingSpeed(int[] piles, int h) {
        
        int l =1;
        int r = piles.Max();
        int res = r;

        while(l<=r)
        {
            int k = (l+r) /2;
            int temp=0;

            foreach(int val in piles)
            {
                temp+=(int)Math.Ceiling((double)val / k);
            }

            if(temp<=h)
            {
                res = k;
                r=k-1;
            }
            else
            {
                l=k+1;
            }
        }

        return res;
    }
}
