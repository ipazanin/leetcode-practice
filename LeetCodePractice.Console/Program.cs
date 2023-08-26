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
            new TestCase<string, string, string>("BANC", "ADOBECODEBANC", "ABC", new LeetCodeTasks.MinimumWindowSubstring.Solution().MinWindow),
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
