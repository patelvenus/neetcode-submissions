public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int i=0;int j=numbers.Length-1;

        while(i<j)
        {
            if(numbers[i] + numbers[j] > target)
            {
                j--;
            }
            else if(numbers[i] + numbers[j] < target)
            {
                i++;
            }
            else
                return [i+1,j+1];
        }

        return null;
    }
}
