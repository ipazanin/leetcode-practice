// WeightedGraphDijkstraAlgorithm.cs
//
// © 2023.

using System.Numerics;

namespace LeetCodePractice.Console.WeightedGraphs;

public static class WeightedGraphDijkstraAlgorithm
{
    public static IReadOnlyDictionary<Vertex<TValue, TWeight>, TWeight> GetShortestPathTable<TValue, TWeight>(
        Vertex<TValue, TWeight> sourceVertex)
        where TWeight : INumber<TWeight>, IMinMaxValue<TWeight>
    {
        var unvisitedVertices = GetAllVertices(sourceVertex);
        var visitedVertices = new List<Vertex<TValue, TWeight>>(unvisitedVertices.Count);

        var shortestPathsTable = unvisitedVertices.ToDictionary(
            keySelector: vertex => vertex,
            elementSelector: _ => TWeight.MaxValue);

        shortestPathsTable[sourceVertex] = TWeight.Zero;

        while (unvisitedVertices.Count != 0)
        {
            var (currentVertex, currentWeight) = shortestPathsTable
                .Where(shortestPathVertex => !visitedVertices.Contains(shortestPathVertex.Key))
                .MinBy(shortestPathVertex => shortestPathVertex.Value);

            foreach (var edge in currentVertex.Edges)
            {
                var neighborVertex = edge.End;
                var neighborCurrentWeight = shortestPathsTable[neighborVertex];
                var neighborPotentialWeight = currentWeight + edge.Weight;

                if (neighborPotentialWeight < neighborCurrentWeight)
                    shortestPathsTable[neighborVertex] = neighborPotentialWeight;
            }

            unvisitedVertices.Remove(currentVertex);
            visitedVertices.Add(currentVertex);
        }

        return shortestPathsTable;
    }

    private static List<Vertex<TValue, TWeight>> GetAllVertices<TValue, TWeight>(
        Vertex<TValue, TWeight> sourceVertex)
        where TWeight : INumber<TWeight>
    {
        var vertexIterator = new VertexIterator<TValue, TWeight>(sourceVertex);

        var result = new List<Vertex<TValue, TWeight>>();

        while (vertexIterator.HasNext())
        {
            result.Add(vertexIterator.Next());
        }

        return result;
    }
}
