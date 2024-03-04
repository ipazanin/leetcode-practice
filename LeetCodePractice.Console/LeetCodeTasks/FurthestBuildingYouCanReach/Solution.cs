using LeetCodePractice.Console.Utilities;

namespace LeetCodePractice.Console.LeetCodeTasks.FurthestBuildingYouCanReach;

public class Solution
{
    public static IEnumerable<TestCase<int, int[], int, int>> GetTestCases()
    {
        yield return new TestCase<int, int[], int, int>(4, [4, 2, 7, 6, 9, 14, 12], 5, 1, new Solution().FurthestBuilding);
        yield return new TestCase<int, int[], int, int>(7, [4, 12, 2, 7, 3, 18, 20, 3, 19], 10, 2, new Solution().FurthestBuilding);
        yield return new TestCase<int, int[], int, int>(3, [14, 3, 19, 3], 17, 0, new Solution().FurthestBuilding);
    }

    public int FurthestBuilding(int[] heights, int bricks, int ladders)
    {
        var largestJumps = new List<int>(ladders);
        var leftoverBricks = bricks;

        for (var i = 1; i < heights.Length; i++)
        {
            var currentJump = heights[i] - heights[i - 1];

            if (currentJump <= 0)
            {
                continue;
            }

            var additionalBricks = GetNumberOfAdditionalBricksNecessary(largestJumps, currentJump, ladders);

            leftoverBricks -= additionalBricks;

            if (leftoverBricks < 0)
            {
                return i - 1;
            }
        }

        return heights.Length - 1;
    }

    private static int GetNumberOfAdditionalBricksNecessary(List<int> largestJumps, int currentJump, int ladders)
    {
        if (ladders == 0)
        {
            return currentJump;
        }

        var smallestLargeJump = 0;

        if (largestJumps.Count == ladders)
        {
            smallestLargeJump = largestJumps[0];

            if (smallestLargeJump >= currentJump)
            {
                return currentJump;
            }

            largestJumps.RemoveAt(0);
        }

        InsertAtAppropriateIndex(largestJumps, currentJump);

        return smallestLargeJump;
    }

    private static void InsertAtAppropriateIndex(List<int> largestJumps, int currentJump)
    {
        var index = largestJumps.BinarySearch(currentJump);

        if (index < 0)
        {
            largestJumps.Insert(~index, currentJump);
        }
        else if (index < largestJumps.Count)
        {
            largestJumps.Insert(index, currentJump);
        }
        else
        {
            largestJumps.Add(currentJump);
        }
    }
}

