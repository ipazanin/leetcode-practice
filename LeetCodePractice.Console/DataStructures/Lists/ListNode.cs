// ListNode.cs
//
// © 2022 FESB in cooperation with Zoraja Consulting. All rights reserved.

namespace LeetCodePractice.Console.Lists;

public class ListNode
{
    public int val;
    public ListNode? next;

    public ListNode(int val = 0, ListNode? next = null)
    {
        this.val = val;
        this.next = next;
    }

    public static ListNode CreateFromArray(IEnumerable<int> values)
    {
        ListNode? current = null;

        foreach (var value in values.Reverse())
        {
            current = new ListNode(value, current);
        }

        return current ?? throw new ArgumentException(nameof(values));
    }

    public IList<int> GetArrayFromList()
    {
        var values = new List<int>();
        var pointer = this;

        while (pointer is not null)
        {
            values.Add(pointer.val);
            pointer = pointer.next;
        }

        return values;
    }

    public override string ToString()
    {
        return $"{val}, {next}";
    }
}
