// VertexIterator.cs
//
// © 2022 FESB in cooperation with Zoraja Consulting. All rights reserved.

using System.Numerics;

namespace LeetCodePractice.Console.WeightedGraphs;

public class VertexIterator<TValue, TWeight> where TWeight : INumber<TWeight>
{
    private Vertex<TValue, TWeight>? _current;

    private readonly Queue<Vertex<TValue, TWeight>> _connectedNodesToVisit = new();
    private readonly HashSet<Vertex<TValue, TWeight>> _visited = new();

    public VertexIterator(Vertex<TValue, TWeight> root)
    {
        _current = root;
    }

    public Vertex<TValue, TWeight> Next()
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

        foreach (var edge in _current!.Edges)
        {
            _connectedNodesToVisit.Enqueue(edge.End);
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
