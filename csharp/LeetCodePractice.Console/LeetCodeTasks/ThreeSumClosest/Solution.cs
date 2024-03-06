// Solution.cs
//
// © 2023.

namespace LeetCodePractice.Console.LeetCodeTasks.ThreeSumClosest;

public class Solution
{
    public int ThreeSumClosest(int[] nums, int target)
    {
        var closest = int.MaxValue;
        var closestSum = -1;

        for (var i = 0; i < nums.Length; i++)
        {
            for (var j = i + 1; j < nums.Length; j++)
            {
                for (var z = j + 1; z < nums.Length; z++)
                {
                    var first = nums[i];
                    var second = nums[j];
                    var third = nums[z];

                    var sum = first + second + third;
                    var currentClosest = Math.Abs(Math.Abs(target) - Math.Abs(sum));

                    if (currentClosest < closest)
                    {
                        closest = currentClosest;
                        closestSum = sum;
                    }
                }
            }
        }

        return closestSum;
    }
}
