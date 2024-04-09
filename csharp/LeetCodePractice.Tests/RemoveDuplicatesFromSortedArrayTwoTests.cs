namespace LeetCodePractice.Tests;

public class RemoveDuplicatesFromSortedArrayTwoTests
{
    [Theory]
    [MemberData(nameof(Data))]
    public void Tests(int expectedResult, int[] numbers)
    {
        var solution = new Console.LeetCodeTasks.RemoveDuplicatesFromSortedArrayTwo.Solution();

        var actualResult = solution.RemoveDuplicates(numbers);

        Assert.Equal(expectedResult, actualResult);
    }

    public static IEnumerable<object[]> Data =>
    [
        [ 5, new int [] { 1, 1, 1, 2, 2, 3 } ],
        [ 7, new int [] { 0, 0, 1, 1, 1, 1, 2, 3, 3 }],
    ];
}
