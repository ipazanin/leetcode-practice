namespace LeetCodePractice.Console.LeetCodeTasks.BinarySubArraysWithSum;

/// <summary>
/// https://leetcode.com/problems/binary-subarrays-with-sum/description/?envType=daily-question&envId=2024-03-14
/// </summary>
public class Solution
{
    public int NumSubarraysWithSum(int[] nums, int goal)
    {
        if (nums.Length == 1)
        {
            return nums[0] == goal ? 1 : 0;
        }

        var numbersSum = new int[nums.Length + 1];
        var sum = 0;
        var count = 0;

        for (var i = 0; i < nums.Length; i++)
        {
            sum += nums[i];

            if (sum == goal)
            {
                count++;
            }

            if (sum >= goal)
            {
                count += numbersSum[sum - goal];
            }

            numbersSum[sum]++;
        }

        return count;
    }
}
