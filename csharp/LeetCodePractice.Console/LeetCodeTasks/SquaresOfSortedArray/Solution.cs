using LeetCodePractice.Console.Utilities;

namespace LeetCodePractice.Console.LeetCodeTasks.SquaresOfSortedArray;

/// <summary>
/// https://leetcode.com/problems/squares-of-a-sorted-array/description/
/// </summary>
public class Solution
{

    public static IEnumerable<TestCase<int[], int[]>> GetTestCases()
    {
        yield return new TestCase<int[], int[]>([0, 1, 9, 16, 100], [-4, -1, 0, 3, 10], new Solution().SortedSquares);
        yield return new TestCase<int[], int[]>([4, 9, 9, 49, 121], [-7, -3, 2, 3, 11], new Solution().SortedSquares);
    }

    public int[] SortedSquares(int[] nums)
    {
        var sortedSquared = new int[nums.Length];
        var firstPositiveNumberIndex = GetFirstPositiveNumberIndex(nums);

        var forwardMovingIndex = firstPositiveNumberIndex;
        var backwardsMovingIndex = firstPositiveNumberIndex - 1;
        var sortedSquaredIndex = 0;

        while (forwardMovingIndex < nums.Length || backwardsMovingIndex >= 0)
        {
            if (forwardMovingIndex >= nums.Length)
            {
                var value = nums[backwardsMovingIndex--];
                sortedSquared[sortedSquaredIndex++] = value * value;
                continue;
            }

            if (backwardsMovingIndex < 0)
            {
                var value = nums[forwardMovingIndex++];
                sortedSquared[sortedSquaredIndex++] = value * value;
                continue;
            }

            var forwardValue = nums[forwardMovingIndex];
            var backwardValue = nums[backwardsMovingIndex];

            var forwardValueSquared = forwardValue * forwardValue;
            var backwardValueSquared = backwardValue * backwardValue;

            if (forwardValueSquared > backwardValueSquared)
            {
                backwardsMovingIndex--;
                sortedSquared[sortedSquaredIndex++] = backwardValueSquared;
            }
            else
            {
                forwardMovingIndex++;
                sortedSquared[sortedSquaredIndex++] = forwardValueSquared;
            }
        }

        return sortedSquared;
    }

    private static int GetFirstPositiveNumberIndex(int[] nums)
    {
        var index = Array.BinarySearch(nums, 0);

        return index switch
        {
            < 0 => ~index,
            _ => index
        };
    }
}
