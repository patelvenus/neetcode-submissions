public class MedianFinder {

    PriorityQueue<int, int> left;
    PriorityQueue<int, int> right;
    bool odd = false;

    public MedianFinder() {
       left = new PriorityQueue<int, int>();
       right = new PriorityQueue<int, int>();  
    }
    
    //peek return min priority value always
    //as per this code : right <= left
    //so we want min value from right hence adding negetive to each priority to peek minimum which actually a max
    // peek min from left 
    //odd will decide to pick only from left or left+right/2.0; 


    // example  consider the total value
    //[3,5,8,10,14,18]
    //left pq [3,5,8]
    //right(with negetive priority) pq (10,14,18)
    // answer will be left.peek(8) = 8  + right.Peek(-10) =  10 /2.0
    public void AddNum(int n)
    {
        odd = !odd;
        int m = right.EnqueueDequeue(n, -n);
        left.Enqueue(m, m);

        if (left.Count - 1 > right.Count)
        {
            m = left.Dequeue();
            right.Enqueue(m, -m);
        }
    }
    
    

    public double FindMedian() =>
        odd ? left.Peek() : (left.Peek() + right.Peek()) / 2.0;
}

/**
 * Your MedianFinder object will be instantiated and called as such:
 * MedianFinder obj = new MedianFinder();
 * obj.AddNum(num);
 * double param_2 = obj.FindMedian();
 */

// public class MedianFinder {

//     private List<int> list;

//     public MedianFinder() {
//         list = new List<int>();    
//     }
    
//     public void AddNum(int num) 
//     {
        
//         list.Add(num);
//         list.Sort(); //O(logn)

//         // we can merge sort algo. 
//     }
    
//     public double FindMedian() 
//     {
        
//         int mid = list.Count / 2 ;

//         if(list.Count % 2== 0)
//         {
//             return (list[mid-1] + list[mid]) / 2.0;
//         }
//         else
//         {
//             return list[mid];
//         }
//     }
// }
