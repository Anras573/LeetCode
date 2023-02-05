using LeetCode.Problems.Trees;

namespace LeetCode.Tests.Trees;

public class InvertBinaryTreeTest
{
    [Fact]
    public void GivenBinaryTree_WhenCallingInvertBinaryTree_ThenBinaryTreeIsInverted()
    {
        var left = new BinaryTreeNode(2, new BinaryTreeNode(1), new BinaryTreeNode(3));
        var right = new BinaryTreeNode(7, new BinaryTreeNode(6), new BinaryTreeNode(9));
        var tree = new BinaryTreeNode(4, left, right);

        var inverted = InvertBinaryTree.Invert(tree);

        var expectedLeft = new BinaryTreeNode(7, new BinaryTreeNode(9), new BinaryTreeNode(6));
        var expectedRight = new BinaryTreeNode(2, new BinaryTreeNode(3), new BinaryTreeNode(1));
        var expected = new BinaryTreeNode(4, expectedLeft, expectedRight);

        Assert.True(IdenticalTrees(expected, inverted));
    }

    private static bool IdenticalTrees(BinaryTreeNode left, BinaryTreeNode right)
    {
        if (left == null && right == null) {
            return true;
        }
 
        if (left != null && right != null) {
            return left.Value == right.Value
                    && IdenticalTrees(left.Left, right.Left)
                    && IdenticalTrees(left.Right, right.Right);
        }
 
        return false;
    }
}