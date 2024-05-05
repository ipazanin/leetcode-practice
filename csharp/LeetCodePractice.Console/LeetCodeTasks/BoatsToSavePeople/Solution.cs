namespace LeetCodePractice.Console.LeetCodeTasks.BoatsToSavePeople;

/// <summary>
/// https://leetcode.com/problems/boats-to-save-people/description/?envType=daily-question&envId=2024-05-04
/// </summary>
public class Solution
{
    public int NumRescueBoats(int[] people, int limit)
    {
        var start = 0;
        var end = people.Length - 1;
        var boats = 0;

        Array.Sort(people);

        while (start < end)
        {
            var endPerson = people[end];
            var startPerson = people[start];

            if (startPerson + endPerson > limit)
            {
                boats++;
                end--;
            }
            else
            {
                boats++;
                end--;
                start++;
            }
        }

        if (start == end)
        {
            boats++;
        }

        return boats;
    }
}
