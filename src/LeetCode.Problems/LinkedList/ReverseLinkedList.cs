namespace LeetCode.Problems.LinkedList;

public class ReverseLinkedList
{
    /// <summary>
    /// Given the head of a singly linked list, reverse the list, and return the reversed list.
    /// <example>
    ///(1)->(2)->(3)->(4)->(5) => (5)->(4)->(3)->(2)->(1)
    /// </example>
    /// </summary>
    /// <param name="head">The head of the singly linked list</param>
    /// <typeparam name="T">The type of the values in the singly linked list</typeparam>
    /// <returns>The reserved singly linked list</returns>
    public static SinglyLinkedListNode<T> ReverseIteratively<T>(SinglyLinkedListNode<T> head)
    {
        SinglyLinkedListNode<T> prev = null;
        var curr = head;

        while (curr is not null)
        {
            var next = curr.Next;
            curr.Next = prev;
            prev = curr;
            curr = next;
        }
        
        return prev;
    }
    
    /// <summary>
    /// Given the head of a singly linked list, reverse the list, and return the reversed list.
    /// <example>
    ///(1)->(2)->(3)->(4)->(5) => (5)->(4)->(3)->(2)->(1)
    /// </example>
    /// </summary>
    /// <param name="head">The head of the singly linked list</param>
    /// <typeparam name="T">The type of the values in the singly linked list</typeparam>
    /// <returns>The reserved singly linked list</returns>
    public static SinglyLinkedListNode<T> ReverseRecursively<T>(SinglyLinkedListNode<T> head)
    {
        if (head is null) return null;

        var newHead = head;

        if (head.Next is not null)
        {
            newHead = ReverseRecursively(head.Next);
            head.Next.Next = head;
        }

        head.Next = null;
        return newHead;
    }
}