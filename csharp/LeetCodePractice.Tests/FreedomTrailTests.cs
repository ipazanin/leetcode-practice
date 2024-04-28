namespace LeetCodePractice.Tests;

public class FreedomTrailTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void Tests(int expectedResult, string ring, string key)
    {
        var solution = new Console.LeetCodeTasks.FreedomTrail.Solution();

        var actual = solution.FindRotateSteps(ring, key);

        Assert.Equal(expectedResult, actual);
    }

    public static IEnumerable<object[]> Data =>
    [
        [4, "godding", "gd"],
        [13, "godding", "godding"],
        [6, "abcde", "ade"],
        [11, "iotfo", "fioot"],
        [17, "ababcab", "acbaacba"],
    ];
}
