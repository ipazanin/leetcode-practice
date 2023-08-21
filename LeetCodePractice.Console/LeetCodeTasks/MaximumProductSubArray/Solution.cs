// Solution.cs
//
// © 2023.

namespace LeetCodePractice.Console.LeetCodeTasks.MaximumProductSubArray;

public class Solution
{
    public int MaxProduct(int[] nums)
    {
        var maxProductValue = int.MinValue;
        var productValue = 1;
        var numberOfNegativeElements = nums.Count(num => num < 0);

        for (var i = 0; i < nums.Length; i++)
        {
            var number = nums[i];
            if (number == 0)
            {
                productValue = 1;
                continue;
            }

            if ()

            var currentProductValue = productValue * number;

        }
    }
}
