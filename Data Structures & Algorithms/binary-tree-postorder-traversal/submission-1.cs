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
    public List<int> PostorderTraversal(TreeNode root) {
        var res = new List<int>();
        if(root==null) return res;

        var s1 = new Stack<TreeNode>();
        var s2 = new Stack<TreeNode>();

        s1.Push(root);

        while(s1.Count()>0)
        {
            root = s1.Pop();
            s2.Push(root);

             if(root.left!=null)
                s1.Push(root.left);

             if(root.right!=null)
                s1.Push(root.right);
        }

        while(s2.Count()>0)
        {
            root = s2.Pop();
            res.Add(root.val);
        }

        return res;
    }
}