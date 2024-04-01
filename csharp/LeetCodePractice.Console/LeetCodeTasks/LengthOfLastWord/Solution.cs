namespace LeetCodePractice.Console.LeetCodeTasks.LengthOfLastWord;

/// <summary>
/// https://leetcode.com/problems/length-of-last-word/?envType=daily-question&envId=2024-04-01
/// </summary>
public class Solution
{
    public int LengthOfLastWord(string s)
    {
        var lastWord = s.Trim().Split(' ')[^1];

        return lastWord.Length;
    }
}
