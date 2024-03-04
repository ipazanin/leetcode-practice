using LeetCodePractice.Console.Utilities;

namespace LeetCodePractice.Console.LeetCodeTasks.RemoveNthNodeFromEndOfList;

/// <summary>
/// https://leetcode.com/problems/remove-nth-node-from-end-of-list/?envType=daily-question&envId=2024-03-03
/// </summary>
public class Solution
{
    public static IEnumerable<TestCase<ListNode, ListNode, int>> GetTestCases()
    {
        yield return new TestCase<ListNode, ListNode, int>(ListNode.CreateFromArray([1, 2, 3, 5]), ListNode.CreateFromArray([1, 2, 3, 4, 5]), 2, new Solution().RemoveNthFromEnd);
        yield return new TestCase<ListNode, ListNode, int>(null!, ListNode.CreateFromArray([1]), 1, new Solution().RemoveNthFromEnd);
        yield return new TestCase<ListNode, ListNode, int>(ListNode.CreateFromArray([1]), ListNode.CreateFromArray([1, 2]), 1, new Solution().RemoveNthFromEnd);
    }

    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
#nullable enable
        var firstPointer = head;

        // second pointer should be N after first pointer so when first pointer finished it will be exactly N before end
        ListNode? secondPointer = null;

        var count = 0;

        while (firstPointer != null)
        {
            if (count == n)
            {
                secondPointer = head;
            }
            else if (count > n)
            {
                secondPointer = secondPointer?.next;
            }

            firstPointer = firstPointer.next;
            count++;
        }

        if (secondPointer is not null)
        {
            secondPointer.next = secondPointer?.next?.next;
        }
        else if (count == n)
        {
            head = head.next!;
        }

        return head;
    }
}
