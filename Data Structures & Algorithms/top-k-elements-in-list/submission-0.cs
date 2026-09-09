public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        var map = new Dictionary<int, int>();

        foreach(var n in nums)        
        {
            map.TryAdd(n,0);
            map[n]++;
        }

        var pq = new PriorityQueue<int, int>();

        foreach(var key in map.Keys)
        {
            pq.Enqueue(key, map[key]);

            if(pq.Count > k)
                pq.Dequeue();
        }

        var result = new int[k];
        var resultIndex = k;
        
        while(pq.Count > 0)
        {
            result[--resultIndex] = pq.Dequeue();
        }

        return result; 
    }
}
