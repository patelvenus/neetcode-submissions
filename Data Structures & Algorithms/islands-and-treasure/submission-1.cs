public class Solution {
    bool[,] visited;

    private int[][] direction = new int[][] {
        new int[] {1, 0}, 
        new int[] {-1, 0},
        new int[] {0, 1}, 
        new int[] {0, -1}
    };

    public void islandsAndTreasure(int[][] grid) 
    {
        var q = new Queue<(int, int)>();

        for(int r = 0;r < grid.Length; r++)
        {
            for(int c=0; c< grid[0].Length;c++)
            {
                if(grid[r][c] == 0)
                {
                    q.Enqueue((r, c));
                }
            }
        }    
    
        while(q.Count > 0)
        {
            var item = q.Dequeue();
            var row = item.Item1;
            var col = item.Item2;

            foreach(var dir in direction)
            {
                var nr = dir[0]+row;
                var nc = dir[1]+col;

                if (nr >= grid.Length || nc >= grid[0].Length || nr < 0 ||
                    nc < 0 || grid[nr][nc] != int.MaxValue) {
                    continue;
                }

                q.Enqueue((nr, nc));
                grid[nr][nc] = grid[row][col] + 1;
                
            }
        }
    }
}
