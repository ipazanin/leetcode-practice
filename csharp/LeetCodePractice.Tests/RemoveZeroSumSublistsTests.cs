using LeetCodePractice.Console.DataStructures.Lists;
using LeetCodePractice.Console.Lists;

namespace LeetCodePractice.Tests;

public class RemoveZeroSumSublistsTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void Tests(ListNode expectedResult, ListNode head)
    {
        var solution = new Console.LeetCodeTasks.RemoveZeroSumSublists.Solution();

        var actualResult = solution.RemoveZeroSumSublists(head);

        Assert.Equal(expectedResult, actualResult, ListNodeValueComparer.Instance);
    }

    public static IEnumerable<object[]> Data =>
    [
        [ListNode.CreateFromArray([3, 1]), ListNode.CreateFromArray([1, 2, -3, 3, 1])],
        [ListNode.CreateFromArray([1, 2, 4]), ListNode.CreateFromArray([1, 2, 3, -3, 4])],
    ];
}
