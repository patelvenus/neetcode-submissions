public class Solution {

    List<List<int>> map;
    HashSet<int> visited;

    public bool ValidTree(int n, int[][] edges) 
    {

        if (edges.Length > n - 1) {
            return false;
        }

        map = new();
        visited = new();
        for(int i = 0;i <n;i++)
        {
            map.Add(new List<int>());
        }

        foreach(var edge in edges)
        {
            map[edge[0]].Add(edge[1]);
            map[edge[1]].Add(edge[0]);
        }

        if(!DFS(0, -1)) return false;

        return visited.Count == n;

    }

    public bool DFS(int node, int parent)
    {
        if(visited.Contains(node)) return false;
        
        visited.Add(node);

        foreach (var nei in map[node])
        {
            if(nei == parent) continue;
            if(!DFS(nei, node))
                return false;
        }

        return true;
    }
}
