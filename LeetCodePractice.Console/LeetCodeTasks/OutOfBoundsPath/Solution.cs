namespace LeetCodePractice.Console.LeetCodeTasks.OutOfBoundsPath;

/// <summary>
/// https://leetcode.com/problems/out-of-boundary-paths/?envType=daily-question&envId=2024-01-26
/// </summary>
public class Solution
{
    public static IEnumerable<TestCase<int, int, int, int, int, int>> GetTestCases()
    {
        yield return new TestCase<int, int, int, int, int, int>(6, 2, 2, 2, 0, 0, new Solution().FindPaths);
        yield return new TestCase<int, int, int, int, int, int>(12, 1, 3, 3, 0, 1, new Solution().FindPaths);
        yield return new TestCase<int, int, int, int, int, int>(1104, 2, 3, 8, 1, 0, new Solution().FindPaths);
    }

    private const int Mod = 1_000_000_000 + 7;

    private int _numberOfRows;
    private int _numberOfColumns;
    private int[,,] _dynamicPaths = new int[0, 0, 0];

    public int FindPaths(int m, int n, int maxMove, int startRow, int startColumn)
    {
        _dynamicPaths = new int[m, n, maxMove + 1];
        _numberOfRows = m;
        _numberOfColumns = n;

        return FindPathsRecursive(maxMove, startRow, startColumn);
    }

    private int FindPathsRecursive(int moves, int row, int column)
    {
        // Edges case
        if (row < 0 || row >= _numberOfRows || column < 0 || column >= _numberOfColumns)
        {
            return 1;
        }

        // No more moves
        if (moves <= 0)
        {
            return 0;
        }

        // Stuck in middle, no way to reach end
        if (moves <= row && moves <= column && row + moves < _numberOfRows && column + moves < _numberOfColumns)
        {
            return 0;
        }

        // If path vas visited with same move number return cache
        if (_dynamicPaths[row, column, moves] != default)
        {
            return _dynamicPaths[row, column, moves];
        }

        var res = 0;

        res = (res + FindPathsRecursive(moves - 1, row + 1, column)) % Mod;
        res = (res + FindPathsRecursive(moves - 1, row, column - 1)) % Mod;
        res = (res + FindPathsRecursive(moves - 1, row - 1, column)) % Mod;
        res = (res + FindPathsRecursive(moves - 1, row, column + 1)) % Mod;

        _dynamicPaths[row, column, moves] = res;

        return res;
    }
}
