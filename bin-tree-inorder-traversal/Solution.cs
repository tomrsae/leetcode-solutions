public class TreeNode {
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

// LNR
public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        IList<int> li = new List<int>();
        if (root == null) return li;
        
        InorderTraversalRecursive(root, ref li);

        return li;
    }

    private void InorderTraversalRecursive(TreeNode node, ref IList<int> li) {
        if (node.left != null) InorderTraversalRecursive(node.left, ref li);

        li.Add(node.val);

        if (node.right != null) InorderTraversalRecursive(node.right, ref li);
    }
}