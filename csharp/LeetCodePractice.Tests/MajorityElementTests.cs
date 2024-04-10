namespace LeetCodePractice.Tests;

public class MajorityElementTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void Tests(int expectedResult, int[] numbers)
    {
        var solution = new Console.LeetCodeTasks.MajorityElement.Solution();

        var actualResult = solution.MajorityElement(numbers);

        Assert.Equal(expectedResult, actualResult);
    }

    public static IEnumerable<object[]> Data =>
    [
        [3, new int[] { 3, 2, 3 }],
        [2, new int[] { 2, 2, 1, 1, 1, 2, 2 }],
        [5, new int[] { 6, 5, 5 }]
    ];
}
