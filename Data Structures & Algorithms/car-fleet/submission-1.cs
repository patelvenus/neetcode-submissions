public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        double[] carTimes = new double[target];
        for(int i = 0; i < position.Length; i++)
        {
            carTimes[position[i]] = (((double)target - (double)position[i]) / speed[i]);
        }
        int fleets = 0;
        double previousTime = 0;
        for(int i = target - 1; i >= 0; i--)
        {
            if(carTimes[i] > previousTime)
            {
                fleets++;
                previousTime = carTimes[i];
            }
        }
        return fleets;
    }
}

// Approach from leetcode C# solution
// This approach completely avoids sorting, making it much faster than most solutions.

// We first create an array size as big as the target, we treat each index as the car that starts at that position, and we store the time it takes for that car to reach the target.

// Then, in the for loop, we check if the car is slower that the previous fleet, if it is, it creates a new fleet, if it's faster, it joins the previous fleet so there is no need to increase the counter.

// Complexity
// Time complexity:
// O(n + target)

// Space complexity:
// O(target)



