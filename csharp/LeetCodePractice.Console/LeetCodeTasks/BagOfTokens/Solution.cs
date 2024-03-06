namespace LeetCodePractice.Console.LeetCodeTasks.BagOfTokens;

/// <summary>
/// https://leetcode.com/problems/bag-of-tokens/?envType=daily-question&envId=2024-03-04
/// </summary>
public class Solution
{
    public static IEnumerable<TestCase<int, int[], int>> GetTestCases()
    {
        yield return new TestCase<int, int[], int>(0, [100], 50, new Solution().BagOfTokensScore);
        yield return new TestCase<int, int[], int>(1, [200, 100], 150, new Solution().BagOfTokensScore);
        yield return new TestCase<int, int[], int>(2, [100, 200, 300, 400], 200, new Solution().BagOfTokensScore);
        yield return new TestCase<int, int[], int>(0, [71, 55, 82], 54, new Solution().BagOfTokensScore);
    }

    public int BagOfTokensScore(int[] tokens, int power)
    {
        Array.Sort(tokens);
        var endPointer = tokens.Length - 1;
        var startPointer = 0;
        var score = 0;

        while (endPointer >= startPointer)
        {
            var currentPower = power - tokens[startPointer];

            if (currentPower < 0)
            {

                if (endPointer == startPointer)
                {
                    break;
                }

                if (score == 0)
                {
                    break;
                }

                score--;
                power += tokens[endPointer--];
            }
            else
            {
                startPointer++;
                score++;
                power = currentPower;
            }
        }

        return score;
    }
}
