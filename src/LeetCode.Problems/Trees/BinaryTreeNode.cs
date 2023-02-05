namespace LeetCode.Problems.Trees;

public class BinaryTreeNode
{
    public int Value;
    public BinaryTreeNode Left;
    public BinaryTreeNode Right;

    public BinaryTreeNode(int value = 0, BinaryTreeNode left = null, BinaryTreeNode right = null)
    {
        Value = value;
        Left = left;
        Right = right;
    }
}