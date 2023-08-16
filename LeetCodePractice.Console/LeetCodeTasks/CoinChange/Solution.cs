// Solution.cs
//
// © 2023.

namespace LeetCodePractice.Console.LeetCodeTasks.CoinChange;

public class Solution
{
    public int CoinChange(int[] coins, int amount)
    {
        if (amount is 0)
        {
            return 0;
        }

        Array.Sort(coins);

        var coinPossibilities = new Queue<(int amount, int count)>();
        var visitedAmounts = new HashSet<int>();

        coinPossibilities.Enqueue((amount, 0));

        while (coinPossibilities.TryDequeue(out var possibility))
        {
            var (currentAmount, currentCount) = possibility;

            if (visitedAmounts.Contains(currentAmount))
            {
                continue;
            }

            visitedAmounts.Add(currentAmount);

            for (var i = 0; i < coins.Length; i++)
            {
                var coinValue = coins[i];

                var newAmount = currentAmount - coinValue;
                var newCount = currentCount + 1;

                if (newAmount == 0)
                {
                    return newCount;
                }

                if (newAmount > 0)
                {
                    coinPossibilities.Enqueue((newAmount, newCount));
                }
            }
        }

        return -1;
    }
}
