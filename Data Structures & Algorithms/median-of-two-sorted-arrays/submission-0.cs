public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] a = nums1.Length < nums2.Length ? nums1 : nums2;
        int[] b = nums1.Length < nums2.Length ? nums2 : nums1;
        int total = (a.Length+b.Length); 
        int half = (total +1) /2;

        int l= 0; 
        int r = a.Length;

        while(l<=r)
        {
            int midA = (l+r) /2;
            int midB = half - midA;

            int leftA = midA > 0 ? a[midA-1] : int.MinValue;
            int rightA = midA < a.Length ? a[midA] : int.MaxValue;
            
            int leftB = midB > 0 ? b[midB-1] : int.MinValue;
            int rightB = midB < b.Length ? b[midB] : int.MaxValue;

            if(leftA <= rightB && leftB<=rightA) //Answer
            {
                if(total % 2 != 0)
                {
                    return Math.Max(leftA,leftB);
                }
                else
                {
                    return (Math.Max(leftA,leftB)+Math.Min(rightA, rightB)) / 2.0;
                }
            }
            else if(leftA > rightB)
            {
                r = midA - 1;
            }
            else
                l = midA + 1;
        }
        return -1;
    }
}
//Look at the video solution and read the program and dry run on the example. 
// look at the second video for more undestanding if needed only https://www.youtube.com/watch?v=T8rD7XbUCLI&t=1166s