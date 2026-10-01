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
    public int KthSmallest(TreeNode root, int k) {
        var s = new Stack<TreeNode>();
        int result = -1;

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
                k--;

                if(k==0)
                {
                    result = root.val;
                    break;
                }
                else
                {
                    root= root.right;
                }
            }
        }

        return result;
    }
}
