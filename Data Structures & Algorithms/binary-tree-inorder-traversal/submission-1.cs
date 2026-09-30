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
    public List<int> InorderTraversal(TreeNode root) {
        var res = new List<int>();
        var s = new Stack<TreeNode>();

        while(true)
        {
            if(root!=null)
            {
                s.Push(root);
                root = root.left;
            }
            else
            {
                if(s.Count() == 0) break;

                root = s.Pop();
                res.Add(root.val);
                root = root.right;
            }
        }
        
        return res;
    }
}