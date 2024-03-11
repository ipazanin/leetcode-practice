namespace LeetCodePractice.Tests;

public class RemoveElementsTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void Tests(int expectedResult, int[] nums, int val)
    {
        var solution = new Console.LeetCodeTasks.RemoveElement.Solution();

        var actualResult = solution.RemoveElement(nums, val);

        Assert.Equal(expectedResult, actualResult);
    }

    public static IEnumerable<object[]> Data =>
    [
        [2, new int[] { 3, 2, 2, 3 }, 3],
        [5, new int [] { 0, 1, 2, 2, 3, 0, 4, 2}, 2],
        [0, new int [] { 1 }, 1],
        [0, Array.Empty<int>(), 0],
    ];
}
