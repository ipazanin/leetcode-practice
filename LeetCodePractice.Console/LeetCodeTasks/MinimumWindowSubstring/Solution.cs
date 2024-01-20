// Solution.cs
//
// © 2023.

namespace LeetCodePractice.Console.LeetCodeTasks.MinimumWindowSubstring;

public class Solution
{
    /// <summary>
    /// 
    /// </summary>
    /// <param name="s"></param>
    /// <param name="t"></param>
    /// <remarks>
    /// https://leetcode.com/problems/minimum-window-substring/description/?envType=study-plan&envId=level-2&plan=leetcode-75
    /// </remarks>
    /// <returns></returns>
    public string MinWindow(string s, string t)
    {
        var lettersMap = GetLettersMap(t);

        var minWindowStart = 0;
        var minWindowEnd = 0;
        var windowStart = 0;
        var windowEnd = 0;
        int stringIndex;

        var isPointerEnd = true;

        while ((stringIndex = isPointerEnd ? windowEnd++ : windowStart++) != s.Length)
        {
            var character = s[stringIndex];

            if (lettersMap.TryGetValue(character, out var characterCount))
            {
                var valueToIncrement = isPointerEnd ? -1 : 1;
                lettersMap[character] = characterCount + valueToIncrement;
            }

            if (isPointerEnd && DoesWindowCoverAllLetters(lettersMap))
            {
                isPointerEnd = false;

                (minWindowStart, minWindowEnd) = GetMinWindowStartAndEnd(minWindowStart, minWindowEnd, windowStart, windowEnd);
            }

            if (!isPointerEnd && !DoesWindowCoverAllLetters(lettersMap))
            {
                (minWindowStart, minWindowEnd) = GetMinWindowStartAndEnd(minWindowStart, minWindowEnd, windowStart - 1, windowEnd);
                isPointerEnd = true;
            }
        }

        // String does not contain all required characters
        if (minWindowEnd == 0 && minWindowStart == 0)
        {
            return string.Empty;
        }

        return s.Substring(minWindowStart, minWindowEnd - minWindowStart);
    }

    public static IEnumerable<TestCase<string, string, string>> GetTestCases()
    {
        yield return new TestCase<string, string, string>("", "A", "AA", new Solution().MinWindow);
        yield return new TestCase<string, string, string>("BANC", "ADOBECODEBANC", "ABC", new Solution().MinWindow);

    }

    private static bool DoesWindowCoverAllLetters(Dictionary<char, int> lettersMap)
    {
        return !lettersMap.Values.Any(value => value > 0);
    }

    private static Dictionary<char, int> GetLettersMap(string letters)
    {
        return letters.GroupBy(character => character)
            .ToDictionary(characterGrouping => characterGrouping.Key, characterGrouping => characterGrouping.Count());
    }

    private static (int minWindowStart, int minWindowEnd) GetMinWindowStartAndEnd(
        int minWindowStart,
        int minWindowEnd,
        int windowStart,
        int windowEnd)
    {
        if (minWindowEnd == 0)
        {
            return (windowStart, windowEnd);
        }

        var previousMin = minWindowEnd - minWindowStart;
        var currentMin = windowEnd - windowStart;

        return (previousMin < currentMin) switch
        {
            true => (minWindowStart, minWindowEnd),
            false => (windowStart, windowEnd)
        };
    }
}
