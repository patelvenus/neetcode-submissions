public class Solution {
    int m, n;
    int[][] direction = new int[][]{
        new int [] {0, 1},
        new int [] {0, -1},
        new int [] {1, 0},
        new int [] {-1, 0}
    };

    public List<List<int>> PacificAtlantic(int[][] grid) {
        var res = new List<List<int>>();
        m = grid.Length;
        n= grid[0].Length;

        var atl = new bool[m,n];
        var pac = new bool[m,n];


        for (int c = 0;c<n;c++)
        {
            DFS(0, c, grid, pac, grid[0][c]);
            DFS(m-1, c, grid, atl, grid[m-1][c]);
        }

        for(int r = 0; r< m;r++)
        {
            DFS(r, 0, grid, pac, grid[r][0]);
            DFS(r, n-1, grid, atl, grid[r][n-1]);
        }

        for (int r = 0; r < m; r++) {
            for (int c = 0; c < n; c++) {
                if (pac[r, c] && atl[r, c]) {
                    res.Add(new List<int> { r, c });
                }
            }
        }

        return res;
    }

    public void DFS(int r, int c, int[][] grid, bool[,] visited, int prev)
    {
        if(r<0 ||c<0 ||r>=m ||c>=n|| visited[r, c]|| grid[r][c]< prev)
            return;

        visited[r,c] = true;

        foreach(var dir in direction)
        {
            DFS(r+dir[0], c+dir[1], grid, visited, grid[r][c]);
        }
    }
}