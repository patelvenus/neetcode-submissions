public class Solution {

        Dictionary<int, List<int>> map = new Dictionary<int, List<int>>();
        HashSet<int> visited = new HashSet<int>();

    public bool CanFinish(int numCourses, int[][] prerequisites) {
        
        for(int i=0; i < numCourses;i++)
        {
            map[i] = new List<int>();
        }

        foreach (var p in prerequisites) {
            map[p[0]].Add(p[1]);
        }

        for (int c = 0; c < numCourses; c++) {
            if (!Dfs(c)) {
                return false;
            }
        }
        return true;
    }

    public bool Dfs(int c)
    {
        if(visited.Contains(c))
            return false;

        if(map[c].Count==0)
            return true;
        

        visited.Add(c);

        foreach(var pre in map[c])
        {
            if(!Dfs(pre))
                return false;
        }

        visited.Remove(c);
        map[c].Clear();

        return true;

    }
}
