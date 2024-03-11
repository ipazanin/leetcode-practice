namespace LeetCodePractice.Console.LeetCodeTasks.CountElementsWithMaxFrequency;

public class Solution
{
    public static IEnumerable<TestCase<int, int[]>> GetTestCases()
    {
        yield return new TestCase<int, int[]>(4, [1, 2, 2, 3, 1, 4], new Solution().MaxFrequencyElements);
        yield return new TestCase<int, int[]>(5, [1, 2, 3, 4, 5], new Solution().MaxFrequencyElements);
    }

    public int MaxFrequencyElements(int[] nums)
    {
        return nums
            .GroupBy(number => number)
            .GroupBy(numberCountGrouping => numberCountGrouping.Count())
            .OrderByDescending(numberWithCountGrouping => numberWithCountGrouping.Key)
            .First()
            .Sum(numberCountGrouping => numberCountGrouping.Count());
    }
}
