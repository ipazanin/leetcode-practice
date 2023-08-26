// Solution.cs
//
// © 2023.

namespace LeetCodePractice.Console.LeetCodeTasks.MinimumWindowSubstring;

public class Solution
{
    public string MinWindow(string s, string t)
    {
    }

    private Span<char> GetMinimumWindowSubString(Span<char> inputCharacters, Dictionary<char, int> charactersToFind)
    {
        for (var i = 0; i < inputCharacters.Length; i++)
        {
            var character = inputCharacters[i];

            if (!charactersToFind.TryGetValue(character, out var numberOfCharacters))
            {
                continue;
            }
        }
    }
}
