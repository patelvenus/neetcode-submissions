public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        int index = FindRowIndex(matrix, target);
        if(index ==-1) return false;
        return FindDataInRow(matrix, index, target);
    }
    
    public bool FindDataInRow(int[][] m, int rowIndex, int t)
    {
         int l = 0;
         int h = m[rowIndex].Length - 1;

        while(l<=h)
        {
            int mid = (l+h)/2;

            if(m[rowIndex][mid] == t)
            {
                return true;
            }
            else if(m[rowIndex][mid] > t)
                h = mid -1;
            else
                l = mid +1;
        }

        return false;
    }

    public int FindRowIndex(int[][] m, int t)
    {
        int l = 0;
        int h = m.Length -1 ;

        while(l<=h)
        {
            int mid = (l+h)/2;

            if(m[mid][0] <= t && m[mid][m[0].Length - 1]>= t)
            {
                return mid;
            }
            else if(m[mid][0] > t)
                h = mid -1;
            else
                l = mid +1;
        }

        return -1;
    }
}
