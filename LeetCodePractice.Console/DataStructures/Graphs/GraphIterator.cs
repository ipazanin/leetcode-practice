// GraphIterator.cs
//
// © 2022 FESB in cooperation with Zoraja Consulting. All rights reserved.

namespace LeetCodePractice.Console.Graphs;

public class GraphIterator
{
    private GraphNode? _current;

    private readonly Queue<GraphNode> _connectedNodesToVisit = new();
    private readonly HashSet<GraphNode> _visited = new();

    public GraphIterator(GraphNode root)
    {
        _current = root;
    }

    public int Next()
    {
        if (_current is null)
        {
            throw new Exception("Empty");
        }

        var value = _current.Value;

        MoveNext();

        return value;
    }

    public GraphNode NextNode()
    {
        if (_current is null)
        {
            throw new Exception("Empty");
        }

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
            {
                continue;
            }

            _current = connectedNode;
            break;
        }
    }
}
