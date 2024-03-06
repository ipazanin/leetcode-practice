// GraphNode.cs
//
// © 2023.

using LeetCodePractice.Console.DataStructures.Graphs;

namespace LeetCodePractice.Console.Graphs;

public class GraphNode : IGraphNode<GraphNode, int>
{
    public GraphNode(int value)
    {
        Value = value;
    }

    public int Value { get; }

    public List<GraphNode> ConnectedNodes { get; } = new();
}
