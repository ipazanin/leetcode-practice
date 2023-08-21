// Solution.cs
//
// © 2023.

namespace LeetCodePractice.Console.LeetCodeTasks.PartitionEqualSubsetSum;

public class Solution
{
    /// <summary>
    /// In the provided code, the variable resultArray stands for "dynamic programming." It's an array used to store the intermediate results of solving the problem. Dynamic programming is an optimization technique that breaks down a complex problem into simpler subproblems and stores the solutions to those subproblems in a table (in this case, the resultArray array) to avoid redundant computations.
    ///
    /// In the context of the Subset Sum problem, the resultArray array is used to keep track of whether it's possible to achieve a particular target sum using a subset of the given numbers. Each element resultArray[i] in the array corresponds to whether it's possible to achieve the sum i using some combination of the numbers from the input array.
    ///
    /// Here's how the resultArray array is used in the solution:
    ///
    /// Initialize resultArray[0] to true, because it's always possible to achieve a sum of 0 using an empty subset.
    ///
    /// For each number num in the nums array, iterate through the resultArray array in reverse order (from targetSum down to num).
    ///
    /// For each index j in the resultArray array that is greater than or equal to num, update resultArray[j] to be true if either:
    ///
    /// resultArray[j - num] is already true (indicating that it's possible to achieve the sum j - num), or
    /// Include the current num to achieve the sum j.
    /// By iterating through the nums array and updating the resultArray array in this manner, the algorithm effectively builds up the possibilities of achieving various target sums using different combinations of the input numbers. At the end of the process, if resultArray[targetSum] is true, it means it's possible to partition the array into two subsets with equal sums, and the method returns true. Otherwise, it returns false.
    ///
    /// In essence, the resultArray array helps avoid recomputing the same subproblems by storing their solutions and reusing them to solve larger subproblems, making the algorithm more efficient.
    /// </summary>
    /// <param name="nums"></param>
    /// <returns></returns>
    public bool CanPartition(int[] nums)
    {
        var sum = nums.Sum();

        // Odd cannot be partitioned
        if (sum % 2 != 0)
        {
            return false;
        }

        var targetSum = sum / 2;
        var resultArray = new bool[targetSum + 1];
        resultArray[0] = true;

        foreach (var num in nums)
        {
            for (var j = targetSum; j >= num; j--)
            {
                resultArray[j] = resultArray[j] || resultArray[j - num];
            }
        }

        return resultArray[targetSum];
    }
}
