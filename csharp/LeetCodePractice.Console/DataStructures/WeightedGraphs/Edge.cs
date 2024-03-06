// Edge.cs
//
// © 2023.

using System.Numerics;

namespace LeetCodePractice.Console.WeightedGraphs;

public class Edge<TValue, TWeight> where TWeight : INumber<TWeight>
{
    public Edge(
        TWeight weight,
        Vertex<TValue, TWeight> start,
        Vertex<TValue, TWeight> end)
    {
        Weight = weight;
        Start = start;
        End = end;
    }

    public TWeight Weight { get; }

    public Vertex<TValue, TWeight> Start { get; }

    public Vertex<TValue, TWeight> End { get; }

    public override string ToString()
    {
        return $"{Start.Value} -> {Weight} -> {End.Value}";
    }
}
