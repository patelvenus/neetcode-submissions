public class Solution {

    List<List<int>> map;
    HashSet<int> visited;
    int res;
    
    public int CountComponents(int n, int[][] edges) 
    {
        map = new();
        visited =new();
        res = 0;

        for(int i=0; i<n; i++)
        {
            map.Add(new List<int>());
        }

        foreach(var edge in edges)
        {
            map[edge[0]].Add(edge[1]);
            map[edge[1]].Add(edge[0]);
        }

        for(int i=0; i<n; i++)
        {
            //BFS(i);
            if(!visited.Contains(i))
            {
                DFS(i);
                res++;
            }
        }

        return res;
    }

    public void BFS(int v)
    {
        if(!visited.Contains(v))
        {
            var q = new Queue<int>();
            q.Enqueue(v);
            
            visited.Add(v);

            while(q.Count > 0)
            {
                var node = q.Dequeue();
                foreach(var nei in map[node])
                {
                    if(visited.Contains(nei)) continue;
                    q.Enqueue(nei);
                    visited.Add(nei);
                }
            }
            res++;
        }
    }


    public void DFS(int v)
    {
        
        visited.Add(v);
        foreach(var nei in map[v])
        {
            if(!visited.Contains(nei))
                DFS(nei);
        }
    }
}
