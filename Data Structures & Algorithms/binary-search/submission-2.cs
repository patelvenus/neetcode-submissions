public class Solution {
    public int Search(int[] nums, int target) {
        return BinarySearch(nums, 0, nums.Length - 1, target);
    }

    public int BinarySearch(int[] nums, int start, int end, int target)
    {
        if(start > end)
            return -1;
        
        int mid = (start + end) /2;
        
        if(nums[mid] == target)
            return mid;
        
        if(nums[mid] > target)
            return BinarySearch(nums, start, mid-1, target);
        else
            return BinarySearch(nums, mid+1, end, target);
    }
}
