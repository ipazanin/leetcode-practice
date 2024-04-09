namespace LeetCodePractice.Console.LeetCodeTasks.RemoveDuplicatesFromSortedArrayTwo;

/// <summary>
/// https://leetcode.com/problems/remove-duplicates-from-sorted-array-ii/?envType=study-plan-v2&envId=top-interview-150
/// </summary>
public class Solution
{
    private const int MAX_NUMBER_OF_REPETITIONS = 2;

    public int RemoveDuplicates(int[] nums)
    {
        var resultCount = 0;
        var repetitionCount = 1;
        var previousNumber = int.MinValue;

        for (var i = 0; i < nums.Length; i++)
        {
            var number = nums[i];

            if (number != previousNumber)
            {
                nums[resultCount] = number;
                resultCount++;

                previousNumber = number;
                repetitionCount = 1;
            }
            else if (number == previousNumber && repetitionCount < MAX_NUMBER_OF_REPETITIONS)
            {
                nums[resultCount] = number;
                resultCount++;

                repetitionCount++;
            }
            else
            {
                continue;
            }
        }

        return resultCount;
    }
}
