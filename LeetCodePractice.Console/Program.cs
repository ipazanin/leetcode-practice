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
            new TestCase<bool, int[]>(true, new[] { 2, 2, 1, 1 }, new LeetCodeTasks.PartitionEqualSubsetSum.Solution().CanPartition),
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
