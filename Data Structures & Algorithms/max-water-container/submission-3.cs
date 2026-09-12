public class Solution {
    public int MaxArea(int[] heights) {
        
        int i =0;
        int j = heights.Length- 1;
        int res = 0; 

        while(i<j)
        {
            var tempRes = Math.Min(heights[i], heights[j]) * (j-i);
            res = Math.Max(res, tempRes);
            
            if(heights[i] <= heights[j])
            {
                i++;
            }
            else
            {
                j--;
            }
        }

        return res;
    }
}
