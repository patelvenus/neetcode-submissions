public class Solution {

    HashSet<(int, int)> visited;

    public int MaxAreaOfIsland(int[][] grid) {

        int res =0;
        visited = new HashSet<(int, int)>();

        for(int r = 0; r<grid.Length; r++)
        {
            for(int c = 0; c<grid[0].Length; c++)
            {
                if(grid[r][c] == 1 && !visited.Contains((r,c)))
                {
                    res = Math.Max(res, DFS(r, c, grid));
                }
            }
        }
        
        return res;
    }

    public int DFS(int r, int c, int[][] grid)
    {
        if(r<0 || c<0 || r>= grid.Length || c>= grid[0].Length || visited.Contains((r,c)) || grid[r][c] == 0)
            return 0;

        var res = 1;
        visited.Add((r, c));

        res = res + DFS(r+1, c, grid);
        res = res + DFS(r-1, c, grid);
        res = res + DFS(r, c+1, grid);
        res = res + DFS(r, c-1, grid);

        return res;
    }
}
