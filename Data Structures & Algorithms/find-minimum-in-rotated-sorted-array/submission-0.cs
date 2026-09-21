public class Solution {
    public int FindMin(int[] nums) {

     int low = 0;
     int high = nums.Length-1;
     int mid;

     while(low<=high)
     {
         mid = (low+high)/2;

         if(nums[low] <= nums[high])
            return nums[low];
        else if(nums[mid] >= nums[low])
            low = mid + 1;
        else
            high = mid;
     }

     return -1;

    }
}