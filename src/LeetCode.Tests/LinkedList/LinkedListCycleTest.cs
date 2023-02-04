using LeetCode.Problems.LinkedList;

namespace LeetCode.Tests.LinkedList;

public class LinkedListCycleTest
{
    [Fact]
    public void GivenLinkedListWithCycle_WhenCheckingForCycle_ThenReturnTrue()
    {
        var n4 = new SinglyLinkedListNode<int>(-4);
        var n3 = new SinglyLinkedListNode<int>(0, n4);
        var n2 = new SinglyLinkedListNode<int>(2, n3);
        var n1 = new SinglyLinkedListNode<int>(3, n2);

        n4.Next = n2;

        var hasCycle = LinkedListCycle.HasCycle(n1);
        
        Assert.True(hasCycle);
    }
    
    [Fact]
    public void GivenLinkedListWithoutCycle_WhenCheckingForCycle_ThenReturnFalse()
    {
        var head = new SinglyLinkedListNode<int>(1);

        var hasCycle = LinkedListCycle.HasCycle(head);
        
        Assert.False(hasCycle);
    }
}