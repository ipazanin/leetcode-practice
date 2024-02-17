
namespace LeetCodePractice.Console.LeetCodeTasks.DailyTemperatures;

/// <summary>
/// https://leetcode.com/problems/daily-temperatures/description/?envType=daily-question&envId=2024-01-31
/// </summary>
public class Solution
{
    public static IEnumerable<TestCase<int[], int[]>> GetTestCases()
    {
        yield return new TestCase<int[], int[]>([1, 1, 4, 2, 1, 1, 0, 0], [73, 74, 75, 71, 69, 72, 76, 73], new Solution().DailyTemperatures);
    }

    public int[] DailyTemperatures(int[] temperatures)
    {
        var result = new int[temperatures.Length];

        for (var i = 0; i < temperatures.Length; i++)
        {
            var currentTemperature = temperatures[i];
            for (var j = i + 1; j < temperatures.Length; j++)
            {
                var futureTemperature = temperatures[j];

                if (futureTemperature > currentTemperature)
                {
                    result[i] = j - i;
                    break;
                }
            }
        }

        return result;
    }
}
