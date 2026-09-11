public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums == null || nums.Length == 0)
            return 0;

        var set = new HashSet<int>();
        foreach(var n in nums)
        {
            set.Add(n);
        }
        
        int res = 1;

        foreach(var n in set)
        {
            var tempRes = 1;
            var tempN = n; 
            if(!set.Contains(tempN-1))
            {
                if(set.Contains(tempN+1))
                {
                    while(set.Contains(tempN+1))
                    {
                        tempRes++;
                        tempN++;
                    }
                    res = Math.Max(res, tempRes);
                }
            }
        }

        return res;
    }
}
//We can consider a number num as the start of a sequence if and only if num - 1 does not exist in the given array. We iterate through the array and only start building the sequence if it is the start of a sequence. This avoids repeated work. We can use a hash set for O(1) lookups by converting the array to a hash set.