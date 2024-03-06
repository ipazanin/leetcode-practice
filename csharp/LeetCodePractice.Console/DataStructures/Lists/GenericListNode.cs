// GenericListNode.cs
//
// © 2022 FESB in cooperation with Zoraja Consulting. All rights reserved.

namespace LeetCodePractice.Console.Lists;

public class GenericListNode<T>
{
    public GenericListNode(T value, GenericListNode<T>? next = null)
    {
        Value = value;
        Next = next;
    }

    public T Value { get; }
    public GenericListNode<T>? Next { get; }

    public static GenericListNode<T>? CreateFromArray(IEnumerable<T> values)
    {
        GenericListNode<T>? current = null;

        foreach (var value in values.Reverse())
        {
            current = new GenericListNode<T>(value, current);
        }

        return current;
    }

    public override string ToString()
    {
        return $"{Value}, {Next}";
    }
}
