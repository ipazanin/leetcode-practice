namespace LeetCodePractice.Console.LeetCodeTasks.MinimumCommonValue;

/// <summary>
/// https://leetcode.com/problems/minimum-common-value/?envType=daily-question&envId=2024-03-09
/// </summary>
public class Solution
{
    public static IEnumerable<TestCase> GetTestCases()
    {
        yield return new TestCase<int, int[], int[]>(2, [1, 2, 3], [2, 4], new Solution().GetCommon);
        yield return new TestCase<int, int[], int[]>(2, [1, 2, 3, 6], [2, 3, 4, 5], new Solution().GetCommon);
        yield return new TestCase<int, int[], int[]>(-1, [], [5], new Solution().GetCommon);
        yield return new TestCase<int, int[], int[]>(-1, [5], [], new Solution().GetCommon);
        yield return new TestCase<int, int[], int[]>(-1, [1], [2], new Solution().GetCommon);
    }

    public int GetCommon(int[] nums1, int[] nums2)
    {
        var firstPointer = 0;
        var secondPointer = 0;

        while (firstPointer < nums1.Length && secondPointer < nums2.Length)
        {
            var firstNumber = nums1[firstPointer];
            var secondNumber = nums2[secondPointer];

            if (firstNumber == secondNumber)
            {
                return firstNumber;
            }
            else if (firstNumber > secondNumber)
            {
                secondPointer++;
            }
            else
            {
                firstPointer++;
            }
        }

        return -1;
    }
}
