namespace LeetCodePractice.Console.LeetCodeTasks.RemoveDuplicatesFromSortedArray;

/// <summary>
/// https://leetcode.com/problems/remove-duplicates-from-sorted-array/?envType=study-plan-v2&envId=top-interview-150
/// </summary>
public class Solution
{
    public int RemoveDuplicates(int[] nums)
    {
        var uniqueCount = 0;
        var previousNumber = int.MinValue;

        for (var i = 0; i < nums.Length; i++)
        {
            var number = nums[i];
            if (number != previousNumber)
            {
                previousNumber = number;
                nums[uniqueCount] = number;
                uniqueCount++;
            }
        }

        return uniqueCount;
    }
}
