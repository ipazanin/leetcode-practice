// Vertex.cs
//
// © 2022 FESB in cooperation with Zoraja Consulting. All rights reserved.

using System.Numerics;

namespace LeetCodePractice.Console.WeightedGraphs;

public class Vertex<TValue, TWeight> where TWeight : INumber<TWeight>
{
    private readonly List<Edge<TValue, TWeight>> _edges;

    public Vertex(TValue value) : this(value, new List<Edge<TValue, TWeight>>())
    {
    }

    public Vertex(TValue value, IReadOnlyList<Edge<TValue, TWeight>> edges)
    {
        Value = value;
        _edges = edges.ToList();
    }

    public TValue Value { get; }

    public IReadOnlyList<Edge<TValue, TWeight>> Edges => _edges;

    public void AddNeighbor(Vertex<TValue, TWeight> neighbor, TWeight weight)
    {
        var edge = new Edge<TValue, TWeight>(weight, this, neighbor);

        _edges.Add(edge);
    }

    public void AddDoubleEdgeNeighbor(Vertex<TValue, TWeight> neighbor, TWeight weight)
    {
        AddNeighbor(neighbor, weight);
        neighbor.AddNeighbor(this, weight);
    }

    public override string ToString()
    {
        return $"{Value}";
    }
}
