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

public class Codec {

    // Encodes a tree to a single string.
    public string Serialize(TreeNode root) {
        
        if(root==null)
            return "*";

        return root.val+ "," + Serialize(root.left) + "," + Serialize(root.right); // preorder serialize. ABC- will be A,B,*,*,C,*,*
    }

    // Decodes your encoded data to tree.
    public TreeNode Deserialize(string data) {
        
        var array = data.Split(",");
        return Deserialize(array);
    }
    
    int index = 0;

    public TreeNode Deserialize(string[] data) {

        if(data[index]== "*")
        {
            index++;
            return null;
        }

        var root = new TreeNode(Convert.ToInt32(data[index]));
        
        index++;

        root.left = Deserialize(data);
        root.right = Deserialize(data);

        return root;

    }


}
