// BinarySearchTreeIterator.cs
//
// © 2022 FESB in cooperation with Zoraja Consulting. All rights reserved.

namespace LeetCodePractice.Console.Trees;

public class BinarySearchTreeIterator
{
    private BinaryTreeNode? _current;

    private readonly Stack<BinaryTreeNode> _parents = new();

    public BinarySearchTreeIterator(BinaryTreeNode root)
    {
        _current = GetLeftMost(root);
    }

    public int Next()
    {
        if (_current is null)
        {
            throw new Exception("Empty");
        }

        var value = _current.val;

        if (_current.right is not null)
        {
            _current = GetLeftMost(_current.right);
            return value;
        }

        if (_parents.Count != 0)
        {
            _current = _parents.Pop();
            return value;
        }

        _current = null;
        return value;
    }

    public bool HasNext()
    {
        return _current is not null;
    }

    private BinaryTreeNode GetLeftMost(BinaryTreeNode root)
    {
        var current = root;

        while (current.left != null)
        {
            _parents.Push(current);
            current = current.left;
        }

        return current;
    }
}
