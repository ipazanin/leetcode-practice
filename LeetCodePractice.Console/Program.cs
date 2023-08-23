// Program.cs
//
// © 2023.

namespace LeetCodePractice.Console;

public static class Program
{
    public static void Main()
    {
        var testCases = new[]
        {
            // new TestCase<int, int[]>(4, new[] { 3, -1, 4 }, new LeetCodeTasks.MaximumProductSubArray.Solution().MaxProduct),
            new TestCase<int, int[]>(4, new[] { 3, -1, -1, -1, 4 }, new LeetCodeTasks.MaximumProductSubArray.Solution().MaxProduct),
            // new TestCase<int, int[]>(0, new[] { -2, 0 }, new LeetCodeTasks.MaximumProductSubArray.Solution().MaxProduct),
            // new TestCase<int, int[]>(2, new[] { 0, 2 }, new LeetCodeTasks.MaximumProductSubArray.Solution().MaxProduct),
            // new TestCase<int, int[]>(-2, new[] { -2 }, new LeetCodeTasks.MaximumProductSubArray.Solution().MaxProduct),
            // new TestCase<int, int[]>(6, new[] { 2, 3, -2, 4 }, new LeetCodeTasks.MaximumProductSubArray.Solution().MaxProduct),
            // new TestCase<int, int[]>(48, new[] { 2, -3, -2, 4 }, new LeetCodeTasks.MaximumProductSubArray.Solution().MaxProduct),
            // new TestCase<int, int[]>(0, new[] { -2, 0, -1 }, new LeetCodeTasks.MaximumProductSubArray.Solution().MaxProduct),
            // new TestCase<int, int[]>(2, new[] { -2, 1, -1 }, new LeetCodeTasks.MaximumProductSubArray.Solution().MaxProduct),
            // new TestCase<int, int[]>(2, new[] { 2, 0, 1 }, new LeetCodeTasks.MaximumProductSubArray.Solution().MaxProduct),
            // new TestCase<int, int[]>(27, new[] { 2, 2, 0, 3, 3, 3 }, new LeetCodeTasks.MaximumProductSubArray.Solution().MaxProduct),
            // new TestCase<int, int[]>(9, new[] { 3, 3, 0, 2, 1, 1 }, new LeetCodeTasks.MaximumProductSubArray.Solution().MaxProduct),
            // new TestCase<int, int[]>(9, new[] { -3, -3, 0, -2, 1, 1 }, new LeetCodeTasks.MaximumProductSubArray.Solution().MaxProduct),
            // new TestCase<int, int[]>(2, new[] { -3, 3, 0, -2, -1, 1 }, new LeetCodeTasks.MaximumProductSubArray.Solution().MaxProduct),
        };

        foreach (var testCase in testCases)
        {
            try
            {
                testCase.Assert();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
