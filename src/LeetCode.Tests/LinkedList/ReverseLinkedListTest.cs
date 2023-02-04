using LeetCode.Problems.LinkedList;

namespace LeetCode.Tests.LinkedList;

public class ReverseLinkedListTest
{
    [Fact]
    public void ReverseLinkedListIteratively()
    {
        var list = new SinglyLinkedListNode<int>(
            1, 
            new SinglyLinkedListNode<int>(
                2, 
                new SinglyLinkedListNode<int>(
                    3, 
                    new SinglyLinkedListNode<int>(
                        4, 
                        new SinglyLinkedListNode<int>(5)))));

        var reverse = ReverseLinkedList.ReverseIteratively(list);
        
        var curr = reverse;
        
        Assert.Equal(5, curr.Value);
        curr = curr.Next;
        Assert.Equal(4, curr.Value);
        curr = curr.Next;
        Assert.Equal(3, curr.Value);
        curr = curr.Next;
        Assert.Equal(2, curr.Value);
        curr = curr.Next;
        Assert.Equal(1, curr.Value);
    }
    
    [Fact]
    public void ReverseLinkedListRecursively()
    {
        var list = new SinglyLinkedListNode<int>(
            1, 
            new SinglyLinkedListNode<int>(
                2, 
                new SinglyLinkedListNode<int>(
                    3, 
                    new SinglyLinkedListNode<int>(
                        4, 
                        new SinglyLinkedListNode<int>(5)))));

        var reverse = ReverseLinkedList.ReverseRecursively(list);
        
        var curr = reverse;
        
        Assert.Equal(5, curr.Value);
        curr = curr.Next;
        Assert.Equal(4, curr.Value);
        curr = curr.Next;
        Assert.Equal(3, curr.Value);
        curr = curr.Next;
        Assert.Equal(2, curr.Value);
        curr = curr.Next;
        Assert.Equal(1, curr.Value);
    }
}