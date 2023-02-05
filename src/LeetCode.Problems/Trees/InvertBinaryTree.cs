namespace LeetCode.Problems.Trees;

public class InvertBinaryTree
{
    /// <summary>
    /// Given the root of a binary tree, invert the tree, and return its root.
    /// </summary>
    /// <param name="root">The root of the binary tree, to be inverted</param>
    /// <returns>The root of the inverted binary tree.</returns>
    public static BinaryTreeNode Invert(BinaryTreeNode root)
    {
        if (root is null) return null;

        (root.Left, root.Right) = (root.Right, root.Left);

        Invert(root.Left);
        Invert(root.Right);
        
        return root;
    }
}