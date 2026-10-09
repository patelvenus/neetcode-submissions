public class Solution {    
    int m;
    int n;
    bool[,] visited;

    public int NumIslands(char[][] grid) {
        
        int res = 0;
        m = grid.Length;
        n = grid[0].Length;
        
        visited = new bool[m,n];

        for(int r=0; r<m; r++)
        {
            for(int c=0; c<n; c++)
            {
                if(grid[r][c] == '1' && !visited[r,c])
                {
                    DFS(r, c, grid);
                    res++;
                }
            }
        }

        return res;
    }


    public void DFS(int r, int c, char[][] grid)
    {
        if(r < 0 || r>=m || c<0 || c >= n || visited[r,c] || grid[r][c]=='0')
            return;

        visited[r,c] = true;

        DFS(r+1, c, grid);
        DFS(r-1, c, grid);
        DFS(r, c+1, grid);
        DFS(r, c-1, grid);
    }
}
