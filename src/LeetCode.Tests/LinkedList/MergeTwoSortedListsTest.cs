using LeetCode.Problems.LinkedList;

namespace LeetCode.Tests.LinkedList;

public class MergeTwoSortedListsTest
{
    [Fact]
    public void MergeTwoEqualSizedSortedLists()
    {
        var list1 = new SinglyLinkedListNode<int>(1,
            new SinglyLinkedListNode<int>(2, 
                new SinglyLinkedListNode<int>(4)));
        var list2 = new SinglyLinkedListNode<int>(1,
            new SinglyLinkedListNode<int>(3,
                new SinglyLinkedListNode<int>(4)));

        var merged = MergeTwoSortedLists.Merge(list1, list2);

        var curr = merged;
        Assert.Equal(1, curr.Value);
        curr = curr.Next;
        Assert.Equal(1, curr.Value);
        curr = curr.Next;
        Assert.Equal(2, curr.Value);
        curr = curr.Next;
        Assert.Equal(3, curr.Value);
        curr = curr.Next;
        Assert.Equal(4, curr.Value);
        curr = curr.Next;
        Assert.Equal(4, curr.Value);
    }
    
    [Fact]
    public void MergeTwoNotEqualSizedSortedLists()
    {
        var list1 = new SinglyLinkedListNode<int>(1,
            new SinglyLinkedListNode<int>(2));
        var list2 = new SinglyLinkedListNode<int>(1,
            new SinglyLinkedListNode<int>(3,
                new SinglyLinkedListNode<int>(4)));

        var merged = MergeTwoSortedLists.Merge(list1, list2);

        var curr = merged;
        Assert.Equal(1, curr.Value);
        curr = curr.Next;
        Assert.Equal(1, curr.Value);
        curr = curr.Next;
        Assert.Equal(2, curr.Value);
        curr = curr.Next;
        Assert.Equal(3, curr.Value);
        curr = curr.Next;
        Assert.Equal(4, curr.Value);
    }
}