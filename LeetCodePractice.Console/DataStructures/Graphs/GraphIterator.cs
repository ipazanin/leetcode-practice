// GraphIterator.cs
//
// © 2023.

namespace LeetCodePractice.Console.DataStructures.Graphs;

public class GraphIterator<TNode, TValue> where TNode : IGraphNode<TNode, TValue>
{
    private IGraphNode<TNode, TValue>? _current;

    private readonly Queue<IGraphNode<TNode, TValue>> _connectedNodesToVisit = new();
    private readonly HashSet<IGraphNode<TNode, TValue>> _visited = new();

    public GraphIterator(IGraphNode<TNode, TValue> root)
    {
        _current = root;
    }

    public IGraphNode<TNode, TValue> NextNode()
    {
        if (_current is null)
            throw new Exception("Empty");

        var value = _current;

        MoveNext();

        return value;
    }

    public bool HasNext()
    {
        return _current is not null;
    }

    private void MoveNext()
    {
        _visited.Add(_current!);

        foreach (var connectedNode in _current!.ConnectedNodes)
        {
            _connectedNodesToVisit.Enqueue(connectedNode);
        }

        _current = null;

        while (_connectedNodesToVisit.TryDequeue(out var connectedNode))
        {
            if (_visited.Contains(connectedNode))
                continue;

            _current = connectedNode;
            break;
        }
    }
}
