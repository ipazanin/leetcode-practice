// GraphNode.cs
//
// © 2022 FESB in cooperation with Zoraja Consulting. All rights reserved.

namespace LeetCodePractice.Console.Graphs;

public class GraphNode
{
    public GraphNode(int value)
    {
        Value = value;
    }

    public int Value { get; }

    public ISet<GraphNode> ConnectedNodes { get; } = new HashSet<GraphNode>();
}
