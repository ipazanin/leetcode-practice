namespace LeetCodePractice.Console.LeetCodeTasks.FindDuplicateNumber;

/// <summary>
/// https://leetcode.com/problems/find-the-duplicate-number/?envType=daily-question&envId=2024-03-24
/// </summary>
public class Solution
{
    public int FindDuplicate(int[] nums)
    {
        var slow = nums[0];
        var fast = nums[0];

        while (true)
        {
            slow = nums[slow];
            fast = nums[nums[fast]];

            if (fast == slow)
            {
                break;
            }
        }

        slow = nums[0];

        while (slow != fast)
        {
            slow = nums[slow];
            fast = nums[fast];
        }

        return slow;
    }
}
