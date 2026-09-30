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
    public List<int> PreorderTraversal(TreeNode root) {
        List<int> res = new List<int>();
        if(root==null) return res;

        Stack<TreeNode> s = new Stack<TreeNode>();
        s.Push(root);

        while(s.Count()>0)
        {

            root= s.Pop();
            res.Add(root.val);
            
            if(root.right!=null)
                s.Push(root.right);

            if(root.left!=null)
                s.Push(root.left);
        }
        return res;
    }
}