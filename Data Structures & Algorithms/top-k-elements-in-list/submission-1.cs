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
    // best solution with O(n) time and O(n) space
    // public int[] TopKFrequent(int[] nums, int k) {
    //     Dictionary<int, int> count = new Dictionary<int, int>();
    //     List<int>[] freq = new List<int>[nums.Length + 1];
    //     for (int i = 0; i < freq.Length; i++) {
    //         freq[i] = new List<int>();
    //     }

    //     foreach (int n in nums) {
    //         if (count.ContainsKey(n)) {
    //             count[n]++;
    //         } else {
    //             count[n] = 1;
    //         }
    //     }
    //     foreach (var entry in count){
    //         freq[entry.Value].Add(entry.Key);
    //     }

    //     int[] res = new int[k];
    //     int index = 0;
    //     for (int i = freq.Length - 1; i > 0 && index < k; i--) {
    //         foreach (int n in freq[i]) { //this for each to support multiple number with same frequency like [1, 1, 2, 2, 3]
    //             res[index++] = n;
    //             if (index == k) {
    //                 return res;
    //             }
    //         }
    //     }
    //     return res;
    // }
}
