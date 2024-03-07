namespace LeetCodePractice.Console.LeetCodeTasks.MiddleOfLinkedList;

/// <summary>
/// https://leetcode.com/problems/middle-of-the-linked-list/?envType=daily-question&envId=2024-03-07
/// </summary>
public class Solution
{
    public static IEnumerable<TestCase<ListNode, ListNode>> GetTestCases()
    {
        yield return new TestCase<ListNode, ListNode>(ListNode.CreateFromArray([3, 4, 5]), ListNode.CreateFromArray([1, 2, 3, 4, 5]), new Solution().MiddleNode);
        yield return new TestCase<ListNode, ListNode>(ListNode.CreateFromArray([4, 5, 6]), ListNode.CreateFromArray([1, 2, 3, 4, 5, 6]), new Solution().MiddleNode);
    }

    public ListNode MiddleNode(ListNode head)
    {
        var slow = head;
        var fast = head;

        while (fast != null)
        {
            if (fast.next is not null)
            {
                slow = slow!.next;
            }

            fast = fast.next?.next;
        }

        return slow!;
    }
}
