// Solution.cs
//
// © 2023.

namespace LeetCodePractice.Console.LeetCodeTasks.PartitionEqualSubsetSum;

public class Solution
{

    public bool CanPartition(int[] nums)
    {
        var sum = nums.Sum();

        
    }

    // public bool CanPartition(int[] nums)
    // {
    //     Array.Sort(nums);
    //     var numbers = nums.AsSpan();

    //     for (var i = 1; i < numbers.Length; i++)
    //     {
    //         var firstHalf = numbers[..i];
    //         var secondHalf = numbers[i..];

    //         var firstHalfSum = SpanSum(firstHalf);
    //         var secondHalfSum = SpanSum(secondHalf);

    //         if (firstHalfSum == secondHalfSum)
    //         {
    //             return true;
    //         }

    //         if (firstHalfSum > secondHalfSum)
    //         {
    //             return false;
    //         }
    //     }

    //     return false;
    // }

    // private static int SpanSum(Span<int> numbers)
    // {
    //     var sum = 0;

    //     for (var i = 0; i < numbers.Length; i++)
    //     {
    //         sum += numbers[i];
    //     }

    //     return sum;
    // }
}
