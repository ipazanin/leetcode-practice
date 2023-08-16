// IGraphNode.cs
//
// © 2023.

namespace LeetCodePractice.Console.DataStructures.Graphs;

public interface IGraphNode<TNode, TValue> where TNode : IGraphNode<TNode, TValue>
{
    public TValue Value { get; }

    public List<TNode> ConnectedNodes { get; }
}
