public class Solution {
    public int[] TwoSum(int[] nums, int target) {

        //if(nums==null || nums.Length < 2)
        //    return null;

        var map = new Dictionary<int, int>();
       // map.Add(target - nums[0], 0);

        for(int i = 0; i < nums.Length; i++)
        {
            if(map.ContainsKey(nums[i]))
                return new int[] { map[nums[i]], i };
            else
                map.Add(target - nums[i], i);
        }
        return null;
    }
}
