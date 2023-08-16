// VertexValueEqualityComparer.cs
//
// © 2023.

using System.Diagnostics.CodeAnalysis;
using System.Numerics;

namespace LeetCodePractice.Console.DataStructures.WeightedGraphs;

public class VertexValueEqualityComparer<TValue, TWeight> : IEqualityComparer<Vertex<TValue, TWeight>>
    where TWeight : INumber<TWeight>
{
    public bool Equals(Vertex<TValue, TWeight>? x, Vertex<TValue, TWeight>? y)
    {
        if (x is null && y is null)
        {
            return true;
        }

        if (x is null)
        {
            return false;
        }

        if (y is null)
        {
            return false;
        }

        if (x.Value is null && y.Value is null)
        {
            return true;
        }

        if (x.Value is null)
        {
            return false;
        }

        return x.Value.Equals(y.Value);
    }

    public int GetHashCode([DisallowNull] Vertex<TValue, TWeight> obj)
    {
        return obj.Value?.GetHashCode() ?? default;
    }
}
