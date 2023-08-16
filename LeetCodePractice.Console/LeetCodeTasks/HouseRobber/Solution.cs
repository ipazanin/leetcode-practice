// Solution.cs
//
// © 2023.

namespace LeetCodePractice.Console.LeetCodeTasks.HouseRobber;

public class Solution
{
    public int Rob(int[] nums)
    {
        if (nums.Length == 0)
            return 0;

        var prev1 = 0;
        var prev2 = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            var tmp = prev1;

            prev1 = Math.Max(prev2 + nums[i], prev1);
            prev2 = tmp;
        }

        return Math.Max(prev1, prev2);
    }
}
