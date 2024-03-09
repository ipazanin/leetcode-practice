namespace LeetCodePractice.Console.LeetCodeTasks.MergeSortedArrays;

public class Solution
{
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        var numsCopy = nums1.Take(m).ToArray();

        var firstPointer = 0;
        var secondPointer = 0;
        var resultPointer = 0;

        while (firstPointer < m && secondPointer < n)
        {
            var firstNumber = numsCopy[firstPointer];
            var secondNumber = nums2[secondPointer];

            if (firstNumber > secondNumber)
            {
                nums1[resultPointer++] = secondNumber;
                secondPointer++;
            }
            else
            {
                nums1[resultPointer++] = firstNumber;
                firstPointer++;
            }
        }

        // leftovers
        while (firstPointer < m)
        {
            var firstNumber = numsCopy[firstPointer++];
            nums1[resultPointer++] = firstNumber;
        }

        // leftovers
        while (secondPointer < n)
        {
            var secondNumber = nums2[secondPointer++];
            nums1[resultPointer++] = secondNumber;
        }
    }
}
