// Program.cs
//
// © 2023.

namespace LeetCodePractice.Console;

public static class Program
{
    public static void Main()
    {
        foreach (var testCase in LeetCodeTasks.SquaresOfSortedArray.Solution.GetTestCases())
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
