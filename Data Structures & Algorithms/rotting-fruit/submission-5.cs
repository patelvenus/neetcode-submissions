public class Solution {
    int m;
    int n;
    int res;
    int[][] direction = new int[][]{
        new int [] {0, 1},
        new int [] {0, -1},
        new int [] {1, 0},
        new int [] {-1, 0}
    };

    public int OrangesRotting(int[][] grid) {
        m = grid.Length;
        n = grid[0].Length;
        res = 0;
        int totalGoodFruit = 0;
        var q = new Queue<(int, int)>();

        for(int r=0;r<m;r++)
        {
            for(int c=0;c<n;c++)
            {
                if(grid[r][c]==1)
                    totalGoodFruit++;
                if(grid[r][c]==2)
                    q.Enqueue((r, c));
            }
        }

        while(q.Count > 0)
        {
            int count = q.Count;
            bool hasRotten = false;

            for(int i=0;i< count;i++)
            {
                var item = q.Dequeue();
                var row = item.Item1;
                var col = item.Item2;

                foreach (var dir in direction)
                {
                    var nr = row + dir[0];
                    var nc = col + dir[1];

                    if (nc>=0 && nr>=0 && nr < m && nc < n &&  grid[nr][nc] == 1)
                    {
                        grid[nr][nc] = 2;
                        q.Enqueue((nr, nc));
                        totalGoodFruit--;
                        if(!hasRotten) 
                            hasRotten = true;
                    }
                }
            }

            if(hasRotten)
                res++;
            
        }

        if(totalGoodFruit == 0)
            return res;
        else return -1;
    }
}
