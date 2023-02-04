namespace LeetCode.Problems.LinkedList;

public class MergeTwoSortedLists
{
    /// <summary>
    /// You are given the heads of two sorted linked lists list1 and list2.
    /// Merge the two lists in a one sorted list. The list should be made by splicing together the nodes of the first two lists.
    /// <example>
    ///(1)->(2)->(4) + (1)->(3)->(4) = (1)->(1)->(2)->(3)->(4)->(4)
    /// </example>
    /// </summary>
    /// <param name="left">The first of the sorted singly linked list</param>
    /// <param name="right">The second of the sorted singly linked list</param>
    /// <returns>Return the head of the merged linked list</returns>
    public static SinglyLinkedListNode<int> Merge(SinglyLinkedListNode<int> left, SinglyLinkedListNode<int> right)
    {
        var dummy = new SinglyLinkedListNode<int>(default);
        var tail = dummy;

        while (left is not null && right is not null)
        {
            if (left.Value < right.Value)
            {
                tail.Next = left;
                left = left.Next;
            }
            else
            {
                tail.Next = right;
                right = right.Next;
            }

            tail = tail.Next;
        }

        if (left is not null)
            tail.Next = left;
        else if (right is not null)
            tail.Next = right;

        return dummy.Next;
    }
}