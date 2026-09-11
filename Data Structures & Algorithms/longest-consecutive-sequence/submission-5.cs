public class Solution {
    public int LongestConsecutive(int[] nums) {
        
        if(nums.Length> 0)
        {   
            var set = new HashSet<int>();
            foreach(int x in nums)
                set.Add(x);

            var res = 1;

            foreach(int x in set)
            {
                int e = x;
                var runresult = 1; 
                if(!set.Contains(e-1))
                {
                    if(set.Contains(e+1))
                    {
                        while(set.Contains(e+1))
                        {
                            runresult++;
                            e++;
                        }
                     res = Math.Max(res, runresult);
                    }
                }
            }
            return res;
        }

        return 0;

    }
}
//We can consider a number num as the start of a sequence if and only if num - 1 does not exist in the given array. We iterate through the array and only start building the sequence if it is the start of a sequence. This avoids repeated work. We can use a hash set for O(1) lookups by converting the array to a hash set.