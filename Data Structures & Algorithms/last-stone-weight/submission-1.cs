public class Solution {
    public int LastStoneWeight(int[] stones) {
        if(stones==null)
            return 0;

        if(stones.Length == 1)
            return stones[0];

        var pq  = new PriorityQueue<int, int>();
        var list = new List<int>();

        foreach(int i in stones)
        {
            pq.Enqueue(i, i);
        }

        while(pq.Count > 2)
        {
            list.Add(pq.Dequeue());
        }

        int last = Math.Abs(pq.Dequeue() - pq.Dequeue());

        if(last!=0)
            list.Add(last);

        return list.Count != 0 ? LastStoneWeight(list.ToArray()) : 0;
    }
}
