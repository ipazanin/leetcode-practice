namespace LeetCodePractice.Console.LeetCodeTasks.LinkedListCycle;

/// <summary>
/// https://leetcode.com/problems/linked-list-cycle/?envType=daily-question&envId=2024-03-06
/// </summary>
public class Solution
{
    public static IEnumerable<TestCase<bool, ListNode>> GetTestCases()
    {
        yield return new TestCase<bool, ListNode>(true, ListNode.CreateCyclicFromArray([3, 2, 0, -4]), new Solution().HasCycle);
        yield return new TestCase<bool, ListNode>(true, ListNode.CreateCyclicFromArray([1, 2]), new Solution().HasCycle);
        yield return new TestCase<bool, ListNode>(false, ListNode.CreateFromArray([1]), new Solution().HasCycle);
    }

    public bool HasCycle(ListNode head)
    {
        var seenNodes = new HashSet<ListNode>();
        var current = head;

        while (current is not null)
        {
            if (seenNodes.Contains(current))
            {
                return true;
            }

            seenNodes.Add(current);

            current = current.next;
        }

        return false;
    }
}
