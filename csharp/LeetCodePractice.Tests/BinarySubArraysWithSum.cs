namespace LeetCodePractice.Tests;

public class BinarySubArraysWithSum
{
    [Theory]
    [MemberData(nameof(Data))]
    public void Tests(int expectedResult, int[] numbers, int goal)
    {
        var solution = new Console.LeetCodeTasks.BinarySubArraysWithSum.Solution();

        var actualResult = solution.NumSubarraysWithSum(numbers, goal);

        Assert.Equal(expectedResult, actualResult);
    }

    public static IEnumerable<object[]> Data =>
    [
        // [ 4, new int[] { 1, 0, 1, 0, 1 }, 2 ],
        [ 15, new int[] { 0, 0, 0, 0, 0 }, 0 ],
    ];
}
