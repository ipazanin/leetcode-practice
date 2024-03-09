namespace LeetCodePractice.Tests;

public class MergeSortedArraysTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void Tests(int[] result, int[] nums1, int m, int[] nums2, int n)
    {
        var solution = new Console.LeetCodeTasks.MergeSortedArrays.Solution();

        solution.Merge(nums1, m, nums2, n);

        Assert.True(result.SequenceEqual(nums1));
    }

    public static IEnumerable<object[]> Data =>
    [
        [new int[] { 1, 2, 2, 3, 5, 6 }, new int[] { 1, 2, 3, 0, 0, 0 }, 3, new int[] { 2, 5, 6 }, 3],
        [new int[] { 1 }, new int[] { 1 }, 1, new int[0], 0],
        [new int[] { 1 }, new int[] { 0 }, 0, new int[] { 1 }, 1],
    ];
}
