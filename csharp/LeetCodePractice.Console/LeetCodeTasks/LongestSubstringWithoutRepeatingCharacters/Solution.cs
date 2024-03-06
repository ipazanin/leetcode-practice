// Solution.cs
//
// © 2023.

namespace LeetCodePractice.Console.LeetCodeTasks.LongestSubstringWithoutRepeatingCharacters;

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        var max = 0;

        var characters = new Dictionary<char, int>();

        for (var i = 0; i < s.Length; i++)
        {
            var character = s[i];
            if (characters.TryGetValue(character, out var index))
            {
                max = Math.Max(characters.Count, max);
                characters.Clear();
                i = index;
            }
            else
            {
                characters.Add(character, i);
            }
        }

        max = Math.Max(characters.Count, max);
        return max;
    }
}
