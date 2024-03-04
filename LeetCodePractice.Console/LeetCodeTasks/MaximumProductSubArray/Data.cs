// Data.cs
//
// © 2023.

using LeetCodePractice.Console.Utilities;

namespace LeetCodePractice.Console.LeetCodeTasks.MaximumProductSubArray;

public class Data
{
    public static readonly TestCase<int, int[]>[] TestCases = new[]
    {
        new TestCase<int, int[]>(4, new[] { 3, -1, 4 }, new Solution().MaxProduct),
        new TestCase<int, int[]>(4, new[] { 3, -1, -1, -1, 4 }, new Solution().MaxProduct),
        new TestCase<int, int[]>(0, new[] { -2, 0 }, new Solution().MaxProduct),
        new TestCase<int, int[]>(2, new[] { 0, 2 }, new Solution().MaxProduct),
        new TestCase<int, int[]>(-2, new[] { -2 }, new Solution().MaxProduct),
        new TestCase<int, int[]>(6, new[] { 2, 3, -2, 4 }, new Solution().MaxProduct),
        new TestCase<int, int[]>(48, new[] { 2, -3, -2, 4 }, new Solution().MaxProduct),
        new TestCase<int, int[]>(0, new[] { -2, 0, -1 }, new Solution().MaxProduct),
        new TestCase<int, int[]>(2, new[] { -2, 1, -1 }, new Solution().MaxProduct),
        new TestCase<int, int[]>(2, new[] { 2, 0, 1 }, new Solution().MaxProduct),
        new TestCase<int, int[]>(27, new[] { 2, 2, 0, 3, 3, 3 }, new Solution().MaxProduct),
        new TestCase<int, int[]>(9, new[] { 3, 3, 0, 2, 1, 1 }, new Solution().MaxProduct),
        new TestCase<int, int[]>(9, new[] { -3, -3, 0, -2, 1, 1 }, new Solution().MaxProduct),
        new TestCase<int, int[]>(2, new[] { -3, 3, 0, -2, -1, 1 }, new Solution().MaxProduct),
    };
}
