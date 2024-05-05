namespace LeetCodePractice.Tests;

public class BoatsToSavePeopleTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void Tests(int expectedResult, int[] people, int limit)
    {
        var solution = new Console.LeetCodeTasks.BoatsToSavePeople.Solution();

        var actualResult = solution.NumRescueBoats(people, limit);

        Assert.Equal(expectedResult, actualResult);
    }

    public static IEnumerable<object[]> Data =>
    [
        [ 1, new int[] { 1,2 }, 3 ],
        [ 3, new int[] { 3, 2, 2, 1 }, 3 ],
        [ 4, new int[] { 3, 5, 3, 4 }, 5 ],
        [ 3, new int[] { 3, 8, 7, 1, 4 }, 9 ],
    ];
}
