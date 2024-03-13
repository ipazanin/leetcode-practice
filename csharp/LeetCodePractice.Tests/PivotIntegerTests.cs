namespace LeetCodePractice.Tests;

public class PivotIntegerTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void Tests(int expectedResult, int n)
    {
        var solution = new Console.LeetCodeTasks.PivotInteger.Solution();

        var actualResult = solution.PivotInteger(n);

        Assert.Equal(expectedResult, actualResult);
    }

    public static IEnumerable<object[]> Data =>
    [
        [ 6, 8 ],
        [ 1, 1 ],
        [ -1, 4 ],
    ];
}
