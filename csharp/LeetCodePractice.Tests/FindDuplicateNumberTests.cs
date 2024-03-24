namespace LeetCodePractice.Tests;

public class FindDuplicateNumberTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void Tests(int expectedResult, int[] numbers)
    {
        var solution = new Console.LeetCodeTasks.FindDuplicateNumber.Solution();

        var actual = solution.FindDuplicate(numbers);

        Assert.Equal(expectedResult, actual);
    }

    public static IEnumerable<object[]> Data =>
    [
        [2, new int[] { 1, 3, 4, 2, 2 }],
        [3, new int[] { 3, 1, 3, 4, 2 }],
        [3, new int[] { 3, 3, 3, 3 }],
        [4, new int[] { 4, 4, 4, 4, 4 }],
    ];
}
