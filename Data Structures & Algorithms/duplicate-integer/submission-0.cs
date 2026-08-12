public class Solution {
    public bool hasDuplicate(int[] nums) {
        if(nums == null || nums.Length < 2)
            return false;
        
        var hashSet = new HashSet<int>();

        for(int i=0; i<nums.Length; i++)
        {
            if(hashSet.Contains(nums[i]))
                return true;
            else
                hashSet.Add(nums[i]);
        }

        return false;
    }
}