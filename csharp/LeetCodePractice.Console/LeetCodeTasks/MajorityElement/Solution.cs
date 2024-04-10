namespace LeetCodePractice.Console.LeetCodeTasks.MajorityElement;

public class Solution
{
    public int MajorityElement(int[] nums)
    {
        var halfOfNumbersLength = nums.Length / 2;
        for (var i = 0; i < nums.Length; i++)
        {
            var majorityNumber = nums[i];
            var repetitionCount = 0;

            for (var j = 0; j < nums.Length; j++)
            {
                var number = nums[j];

                if (number != majorityNumber)
                {
                    continue;
                }

                repetitionCount++;
            }

            if (nums.Length % 2 == 0 && repetitionCount >= halfOfNumbersLength)
            {
                return majorityNumber;

            }

            if (repetitionCount > halfOfNumbersLength)
            {
                return majorityNumber;

            }
        }

        return int.MinValue;
    }
}
