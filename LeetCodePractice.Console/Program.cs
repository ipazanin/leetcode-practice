// Program.cs
//
// © 2023.

using System.Diagnostics;

namespace LeetCodePractice.Console;

public static class Program
{
    public static void Main()
    {
        var result = new LeetCodeTasks.PartitionEqualSubsetSum.Solution().CanPartition(new[] { 2, 2, 1, 1 });
        System.Console.WriteLine(result);
    }
}
