namespace LeetCodePractice.Console.LeetCodeTasks.RemoveZeroSumSublists;

/// <summary>
/// https://leetcode.com/problems/remove-zero-sum-consecutive-nodes-from-linked-list/?envType=daily-question&envId=2024-03-12
/// </summary>
public class Solution
{
    public ListNode RemoveZeroSumSublists(ListNode head)
    {
        var dummyNode = new ListNode(0, head);
        var nodePrefixSums = new Dictionary<int, ListNode>
        {
            {0, dummyNode},
        };
        var prefixSum = 0;

        var curent = head;

        while (curent is not null)
        {
            prefixSum += curent.val;

            if (nodePrefixSums.TryGetValue(prefixSum, out var node))
            {
                var nodeToDelete = node.next;
                var tempSum = prefixSum + nodeToDelete!.val;

                while (curent != nodeToDelete)
                {
                    nodePrefixSums.Remove(tempSum);
                    nodeToDelete = nodeToDelete.next;
                    tempSum += nodeToDelete!.val;
                }

                node.next = curent.next;
            }
            else
            {
                nodePrefixSums[prefixSum] = curent;
            }

            curent = curent.next;
        }

        return dummyNode.next!;
    }
}
