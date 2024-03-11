namespace LeetCodePractice.Tests;

public class CustomSortStringTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void Tests(string expectedResult, string order, string s)
    {
        var solution = new Console.LeetCodeTasks.CustomSortString.Solution();

        var actual = solution.CustomSortString(order, s);

        Assert.Equal(expectedResult, actual);
    }

    public static IEnumerable<object[]> Data =>
    [
        ["cbad", "cba", "abcd"],
        ["bcad", "bcafg", "abcd"],
        ["abcd", "", "abcd"],
        ["", "sea", ""],
        ["", "", ""],
    ];
}
