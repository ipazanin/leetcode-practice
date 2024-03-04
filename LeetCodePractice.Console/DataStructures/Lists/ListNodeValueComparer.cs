using System.Diagnostics.CodeAnalysis;

namespace LeetCodePractice.Console.DataStructures.Lists;

public class ListNodeValueComparer : IEqualityComparer<ListNode>
{
    public static ListNodeValueComparer Instance { get; } = new();

    public bool Equals(ListNode? x, ListNode? y)
    {
        if (x is null && y is null)
            return true;
        else if (x is null || y is null)
        {
            return false;
        }

        var firstValues = x.GetArrayFromList();
        var secondValues = y.GetArrayFromList();

        return firstValues.SequenceEqual(secondValues);
    }

    public int GetHashCode(ListNode obj)
    {
        var values = obj.GetArrayFromList();

        var hash = new HashCode();

        foreach (var value in values)
        {
            hash.Add(value);
        }

        return hash.ToHashCode();
    }
}
