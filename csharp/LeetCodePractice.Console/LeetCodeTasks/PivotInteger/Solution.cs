namespace LeetCodePractice.Console.LeetCodeTasks.PivotInteger;

/// <summary>
/// https://leetcode.com/problems/find-the-pivot-integer/?envType=daily-question&envId=2024-03-13
/// </summary>
public class Solution
{
    public int PivotInteger(int n)
    {
        var startPointer = 0;
        var startPointerSum = 0;
        var endPointer = n;
        var endPointerSum = 0;

        while (startPointer < endPointer)
        {
            if (startPointerSum > endPointerSum)
            {
                endPointerSum += endPointer;
                endPointer--;
            }
            else
            {
                startPointerSum += startPointer;
                startPointer++;
            }
        }

        return (startPointerSum == endPointerSum) switch
        {
            true => startPointer,
            false => -1
        };
    }
}
