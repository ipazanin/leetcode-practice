namespace LeetCodePractice.Tests;

public class LengthOfLastWordTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void Tests(int result, string s)
    {
        var solution = new Console.LeetCodeTasks.LengthOfLastWord.Solution();

        var actualResult = solution.LengthOfLastWord(s);

        Assert.Equal(result, actualResult);
    }

    public static IEnumerable<object[]> Data =>
    [
        [5, "Hello World"],
        [4, "   fly me   to   the moon  "],
        [6, "luffy is still joyboy"],
        [0, ""],
    ];
}
