// Solution.cs
//
// © 2023.

namespace LeetCodePractice.Console.LeetCodeTasks.MaximumProductSubArray;

public class Solution
{
    public int MaxProduct(int[] nums)
    {
        var ans = nums[0];
        var length = nums.Length;
        var product = 1;
        var productReversed = 1;
        
        for (var i = 0; i < length; i++)
        {
            // reset to 1 when the product becomes zero
            product = (product == 0 ? 1 : product) * nums[i];
            productReversed = (productReversed == 0 ? 1 : productReversed) * nums[length - 1 - i];
            ans = Math.Max(ans, Math.Max(product, productReversed));
        }

        return ans;
    }
}
