public class Solution {
    public int[] FindRedundantConnection(int[][] edges) {
        var map  = new List<List<int>>();
        var n  = edges.Length;
        
        for(int i=0; i<=n; i++)
            map.Add(new List<int>());

        foreach(var edge in edges)
        {
            var u = edge[0];
            var v = edge[1];

            map[u].Add(v);
            map[v].Add(u);

            bool[] visited = new bool[n + 1];

            if(DFS(u, -1, map, visited))
            {
                return new int[] {u, v};
            }
        }
        return new int[] {};
    }

    private bool DFS(int node, int parent, List<List<int>> map, bool[] visited)
    {
        if(visited[node]) return true;
        visited[node] = true;
        foreach(var nei in map[node])
        {
            if(nei == parent) continue;
            if(DFS(nei, node, map, visited)) return true;
        }
        return false;
    }
}