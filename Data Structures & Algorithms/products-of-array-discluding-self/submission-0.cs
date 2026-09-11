public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int pre = 1; int post= 1;
        var res = new int[nums.Length];
        
        // Input : [1,2,4,6]
        for(int i =0; i<nums.Length;i++)
        {
            res[i] = pre;
            pre *= nums[i];
        }
        
        //res : [1, 1, 2, 8]
        for(int i = nums.Length -1 ; i>=0;i--)
        {
            res[i] *= post;
            post *= nums[i];
        }
        
        //res : [48,24,12,8]

        return res;

    }
}

// bsically instead of taking prefix array and postfix array we are doing eveything into res array for o(1) space solution.
// Input : [1,2,4,6]
// i.e. prefix array would be [1, 2, 8, 48]
// i.e. postfix array would be [48, 48, 24,6]
// res array would be simple take pre and post number from both array and multiple
// like nums[0] pre would be no value so consider 1 and postfix would postfix[1] = 48
// so res[0] = 48 and similar for other nums [i] and final res = [48, 24, 12, 8]
// Look at the video solution
