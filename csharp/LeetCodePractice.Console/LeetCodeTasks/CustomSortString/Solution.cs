using System.Text;

namespace LeetCodePractice.Console.LeetCodeTasks.CustomSortString;

public class Solution
{
    public string CustomSortString(string order, string s)
    {
        var sOccurrences = GetCharacterOccurrences(s);

        var resultBuilder = new StringBuilder(s.Length);

        foreach (var character in order)
        {
            if (!sOccurrences.TryGetValue(character, out var count))
            {
                continue;
            }

            sOccurrences.Remove(character);
            resultBuilder.Append(character, count);
        }

        foreach (var (character, count) in sOccurrences)
        {
            resultBuilder.Append(character, count);
        }

        return resultBuilder.ToString();
    }

    private Dictionary<char, int> GetCharacterOccurrences(string input)
    {
        var dictionary = new Dictionary<char, int>();

        foreach (var character in input)
        {
            dictionary[character] = dictionary.TryGetValue(character, out var count) switch
            {
                true => count + 1,
                false => 1,
            };
        }

        return dictionary;
    }
}
