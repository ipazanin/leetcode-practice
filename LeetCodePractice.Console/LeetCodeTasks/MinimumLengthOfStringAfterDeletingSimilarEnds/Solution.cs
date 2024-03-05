using LeetCodePractice.Console.Utilities;

namespace LeetCodePractice.Console.LeetCodeTasks.MinimumLengthOfStringAfterDeletingSimilarEnds;

/// <summary>
/// https://leetcode.com/problems/minimum-length-of-string-after-deleting-similar-ends/description/?envType=daily-question&envId=2024-03-05
/// </summary>
public class Solution
{
    public static IEnumerable<TestCase<int, string>> GetTestCases()
    {
        yield return new TestCase<int, string>(2, "ca", new Solution().MinimumLength);
        yield return new TestCase<int, string>(0, "cabaabac", new Solution().MinimumLength);
        yield return new TestCase<int, string>(3, "aabccabba", new Solution().MinimumLength);
        yield return new TestCase<int, string>(1, "bbbbbbbbbbbbbbbbbbbbbbbbbbbabbbbbbbbbbbbbbbccbcbcbccbbabbb", new Solution().MinimumLength);
    }

    public int MinimumLength(string s)
    {
        var startPointer = 0;
        var endPointer = s.Length - 1;

        while (endPointer > startPointer)
        {
            var startCharacter = s[startPointer];
            var endCharacter = s[endPointer];

            if (startCharacter != endCharacter)
            {
                break;
            }

            while (startPointer <= endPointer)
            {
                var character = s[startPointer];
                if (startCharacter != character)
                {
                    break;
                }

                startPointer++;
            }

            while (startPointer <= endPointer)
            {
                var character = s[endPointer];
                if (startCharacter != character)
                {
                    break;
                }

                endPointer--;
            }
        }

        return endPointer - startPointer + 1;
    }
}
