public class Solution {
    
    Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
    HashSet<int> cycle = new HashSet<int>();
    HashSet<int> visit = new HashSet<int>();
    List<int> res = new List<int>();

    public int[] FindOrder(int n, int[][] pre) 
    {
        for(int i=0;i<n;i++)
            map[i] = new List<int>();

        foreach(var p in pre)
            map[p[0]].Add(p[1]);

        for(int crs=0;crs<n;crs++)
            if(!DFS(crs))
                return new int[0];

        return res.ToArray();
    }

    public bool DFS (int crs)
    {
        if(cycle.Contains(crs)) return false;

        if(visit.Contains(crs)) return true;

        cycle.Add(crs);

        foreach(var p in map[crs])
        {
            if(!DFS(p))
                return false;

        }

        cycle.Remove(crs);
        visit.Add(crs);
        res.Add(crs);

        return true;
    }

}
