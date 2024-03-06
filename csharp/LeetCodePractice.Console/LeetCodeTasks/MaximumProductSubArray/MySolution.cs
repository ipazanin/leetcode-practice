// Solution.cs
//
// © 2023.

namespace LeetCodePractice.Console.LeetCodeTasks.MaximumProductSubArray;

public class MySolution
{
    public int MaxProduct(int[] nums)
    {
        if (nums.Length == 1)
        {
            return nums[0];
        }

        var numbersSeparatedByZero = GetNumbersSplittedByZero(nums);
        var maxProductValue = 0;

        foreach (var (numbers, negativeNumbersCount) in numbersSeparatedByZero)
        {
            if (numbers.Length is 0)
            {
                continue;
            }

            var productValue = 1;

            if (numbers.Length is 1)
            {
                productValue = numbers.Span[0];
                maxProductValue = Math.Max(maxProductValue, productValue);
                continue;
            }

            if (negativeNumbersCount % 2 == 0)
            {

                for (var i = 0; i < numbers.Length; i++)
                {
                    var number = numbers.Span[i];

                    productValue *= number;
                }
            }
            else
            {
                var productValueWithoutLastNegative = 1;
                var productValueWithoutFirstNegative = 1;
                var currentNegativeNumbersCount = 0;
                var firstNegativePassed = false;

                for (var i = 0; i < numbers.Length; i++)
                {
                    var number = numbers.Span[i];

                    if (number < 0)
                    {
                        currentNegativeNumbersCount++;
                    }

                    if (currentNegativeNumbersCount != negativeNumbersCount)
                    {
                        productValueWithoutLastNegative *= number;
                    }

                    if (currentNegativeNumbersCount > 0)
                    {
                        if (!firstNegativePassed)
                        {
                            firstNegativePassed = true;
                        }
                        else
                        {
                            productValueWithoutFirstNegative *= number;
                        }
                    }
                }

                productValue = Math.Max(productValueWithoutFirstNegative, productValueWithoutLastNegative);
            }

            maxProductValue = Math.Max(maxProductValue, productValue);
        }

        return maxProductValue;
    }

    private static List<(ReadOnlyMemory<int> array, int negativeNumbersCount)> GetNumbersSplittedByZero(int[] nums)
    {
        var numbers = nums.AsMemory();
        var numbersSeparatedByZero = new List<(ReadOnlyMemory<int> array, int negativeNumbersCount)>();

        var negativeNumbersCount = 0;
        var startOfSlice = 0;
        for (var i = 0; i < numbers.Length; i++)
        {
            var number = numbers.Span[i];
            if (number == 0)
            {
                var slice = numbers[startOfSlice..i];
                numbersSeparatedByZero.Add((slice, negativeNumbersCount));

                negativeNumbersCount = 0;
                startOfSlice = i + 1;

            }

            if (number < 0)
            {
                negativeNumbersCount++;
            }
        }

        var finalSlice = numbers[startOfSlice..numbers.Length];
        numbersSeparatedByZero.Add((finalSlice, negativeNumbersCount));

        return numbersSeparatedByZero;
    }
}
