namespace LeetCodePractice.Console.LeetCodeTasks.RemoveElement;

public class Solution
{
    public int RemoveElement(int[] nums, int val)
    {
        var index = 0;
        var lastElementPointer = nums.Length - 1;

        while (index <= lastElementPointer)
        {
            var value = nums[index];

            if (value == val)
            {
                nums[index] = nums[lastElementPointer];
                lastElementPointer--;
                continue;
            }

            index++;
        }

        return lastElementPointer + 1;
    }
}
