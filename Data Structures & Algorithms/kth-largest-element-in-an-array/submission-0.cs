public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        
        var pq = new PriorityQueue<int, int>();
        
        foreach(var item in nums)        
        {
            pq.Enqueue(item, item);

            if(pq.Count > k)
                pq.Dequeue();
        }

        return pq.Dequeue();
    }
}
