/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    int res; 
    
    public int MaxPathSum(TreeNode root) {
        res =  root.val;
        Dfs(root);
        return res;
    }

    private int Dfs(TreeNode root)
    {
        if(root==null)
            return 0;

        int leftMax = Math.Max(Dfs(root.left), 0);
        int rightMax = Math.Max(Dfs(root.right), 0);

        res = Math.Max(res, root.val + leftMax + rightMax);// save result

        return root.val + Math.Max(leftMax, rightMax);
    }
}
