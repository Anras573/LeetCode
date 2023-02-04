namespace LeetCode.Problems.LinkedList;

public class LinkedListCycle
{
    /// <summary>
    /// Given head, the head of a linked list, determine if the linked list has a cycle in it.
    /// There is a cycle in a linked list if there is some node in the list that can be reached again
    /// by continuously following the next pointer.
    /// </summary>
    /// <param name="head">The singly linked list that we want to determine if it has a cycle.</param>
    /// <typeparam name="T">The type of the value in the singly linked list.</typeparam>
    /// <returns>Returns true if there is a cycle in the linked list. Otherwise, returns false.</returns>
    public static bool HasCycle<T>(SinglyLinkedListNode<T> head)
    {
        var slow = head;
        var fast = head;

        while (fast?.Next != null)
        {
            slow = slow.Next;
            fast = fast.Next.Next;

            if (slow == fast)
                return true;
        }
        
        return false;
    }
}