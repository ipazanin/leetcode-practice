// BinaryTreeNode.cs
//
// © 2022 FESB in cooperation with Zoraja Consulting. All rights reserved.

namespace LeetCodePractice.Console.Trees;

public class BinaryTreeNode
{
    public int val;

    public BinaryTreeNode? left;

    public BinaryTreeNode? right;

    public BinaryTreeNode(
        int val = 0,
        BinaryTreeNode? left = null,
        BinaryTreeNode? right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }

    public static BinaryTreeNode? CreateFromArray(IReadOnlyList<int?> values)
    {
        if (values.Count == 0 || !values[0].HasValue)
        {
            return null;
        }

        var root = new BinaryTreeNode(values[0]!.Value);
        var parents = new Queue<BinaryTreeNode>();
        parents.Enqueue(root);
        parents.Enqueue(root);

        for (var i = 1; i < values.Count; i++)
        {
            var value = values[i];
            var current = value.HasValue ? new BinaryTreeNode(value.Value) : null;
            var parent = parents.Dequeue();

            if (i % 2 == 0)
            {
                parent.right = current;
            }
            else
            {
                parent.left = current;
            }

            if (current is not null)
            {
                parents.Enqueue(current);
                parents.Enqueue(current);
            }
        }

        return root;
    }

    public override string ToString()
    {
        return $"{val}, {left}, {right}";
    }
}
