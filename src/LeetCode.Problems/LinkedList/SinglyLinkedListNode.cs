namespace LeetCode.Problems.LinkedList;

public class SinglyLinkedListNode<T>
{
    public SinglyLinkedListNode<T>? Next { get; set; }
    public T Value { get; set; }

    public SinglyLinkedListNode(T value, SinglyLinkedListNode<T>? next = null)
    {
        Value = value;
        Next = next;
    }
}