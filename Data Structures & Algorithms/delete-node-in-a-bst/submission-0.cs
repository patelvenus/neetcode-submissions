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
    public TreeNode DeleteNode(TreeNode root, int key) {
        if(root == null)
            return root;

        if(key < root.val)
            root.left = DeleteNode(root.left, key);
        else if(key > root.val)
            root.right = DeleteNode(root.right, key);
        else
        {
            if (root.left ==null)
            {
                return root.right; 
            }

            if (root.right ==null)
            {
                return root.left; 
            }

            var node = FindMin(root.right);
            root.val = node.val;
            root.right = DeleteNode(root.right, node.val);
        
        }

        return root; 
    }

    public TreeNode FindMin(TreeNode root)
    {
        if(root.left == null)
            return root;

        return FindMin(root.left);
    }
}

// Step-by-Step Algorithm
// Handle the Base Case:

// If the tree is empty (node == null), return null as there is nothing to delete.
// Traverse the Tree to Find the Node to Delete:

// If the key to delete is smaller than the current node’s value (key < node.val), recursively search in the left subtree by calling delete(node.left, key).
// If the key is greater than the current node’s value (key > node.val), recursively search in the right subtree by calling delete(node.right, key).
// Node to be Deleted is Found:

// If key == node.val, proceed to handle the deletion cases.
// Case 1: Node Has No Left Child (Only Right Child or Leaf Node)

// If node.left == null, return node.right, effectively removing the current node.
// Case 2: Node Has No Right Child (Only Left Child)

// If node.right == null, return node.left, effectively removing the current node.
// Case 3: Node Has Two Children (Both Left and Right Exist)

// Find the inorder successor, which is the smallest node in the right subtree.
// Use the helper function minValueNode(node.right) to locate this successor.
// Copy the inorder successor's value to the current node (node.val = successor.val).
// Recursively delete the successor node from the right subtree using delete(node.right, successor.val).
// Return the Updated Node:

// After handling all cases, return the updated node to maintain the tree structure.