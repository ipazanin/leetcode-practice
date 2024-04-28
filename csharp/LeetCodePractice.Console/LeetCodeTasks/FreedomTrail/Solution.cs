using System.Diagnostics;

namespace LeetCodePractice.Console.LeetCodeTasks.FreedomTrail;

/// <summary>
/// https://leetcode.com/problems/freedom-trail/description/?envType=daily-question&envId=2024-04-27
/// </summary>
public class Solution
{
    public int FindRotateSteps(string ring, string key)
    {
        var possibleRotations = new Dictionary<int, int>();
        possibleRotations.Add(0, 0);

        foreach (var keyCharacter in key)
        {
            var clockWisePossibleRotations = GetPossibleClockwiseRotations(ring, keyCharacter, possibleRotations);
            var counterclockwisePossibleRotations = GetPossibleCounterclockwiseRotations(ring, keyCharacter, possibleRotations);

            foreach (var (ringPosition, steps) in counterclockwisePossibleRotations)
            {
                if (clockWisePossibleRotations.TryGetValue(ringPosition, out var savedSteps))
                {
                    if (steps < savedSteps)
                    {
                        clockWisePossibleRotations[ringPosition] = steps;
                    }
                }
                else
                {
                    clockWisePossibleRotations.Add(ringPosition, steps);
                }
            }

            possibleRotations = clockWisePossibleRotations;

            // System.Console.WriteLine(string.Join(" | ", possibleRotations.Select(kv => $"{keyCharacter} - {ring.Substring(kv.Key)}{ring.Substring(0, kv.Key)} - {kv.Value}")));
        }

        return possibleRotations.Values.Min();
    }

    private static Dictionary<int, int> GetPossibleClockwiseRotations(
        string ring,
        char keyCharacter,
        Dictionary<int, int> currentPossibleRotations)
    {
        var newPossibleRotations = new Dictionary<int, int>();

        foreach (var (ringPointer, steps) in currentPossibleRotations)
        {
            var currentPossibilitySteps = 0;
            var currentRingPointer = ringPointer;

            while (true)
            {
                var (rotationSteps, newRingPointerPosition) = MovePointerClockwise(ring, keyCharacter, currentRingPointer);
                currentPossibilitySteps += rotationSteps;
                currentRingPointer = newRingPointerPosition;

                if (currentPossibilitySteps >= ring.Length)
                {
                    break;
                }

                var currentSteps = steps + currentPossibilitySteps + 1;

                if (newPossibleRotations.TryGetValue(currentRingPointer, out var savedSteps))
                {
                    if (savedSteps > currentSteps)
                    {
                        newPossibleRotations[currentRingPointer] = currentSteps;
                    }
                }
                else
                {
                    newPossibleRotations[currentRingPointer] = currentSteps;
                }

                currentPossibilitySteps++;
                currentRingPointer = (currentRingPointer + 1) % ring.Length;
            }
        }

        return newPossibleRotations;
    }

    private static Dictionary<int, int> GetPossibleCounterclockwiseRotations(
        string ring,
        char keyCharacter,
        Dictionary<int, int> currentPossibleRotations)
    {
        var newPossibleRotations = new Dictionary<int, int>();

        foreach (var (ringPointer, steps) in currentPossibleRotations)
        {
            var currentPossibilitySteps = 0;
            var currentRingPointer = ringPointer;

            while (true)
            {
                var (rotationSteps, newRingPointerPosition) = MovePointerCounterclockwise(ring, keyCharacter, currentRingPointer);
                currentPossibilitySteps += rotationSteps;
                currentRingPointer = newRingPointerPosition;

                if (currentPossibilitySteps >= ring.Length)
                {
                    break;
                }

                var currentSteps = steps + currentPossibilitySteps + 1;

                if (newPossibleRotations.TryGetValue(currentRingPointer, out var savedSteps))
                {
                    if (savedSteps > currentSteps)
                    {
                        newPossibleRotations[currentRingPointer] = currentSteps;
                    }
                }
                else
                {
                    newPossibleRotations[currentRingPointer] = currentSteps;
                }

                currentPossibilitySteps++;
                currentRingPointer--;
                if (currentRingPointer < 0)
                {
                    currentRingPointer = ring.Length - 1;
                }
            }
        }

        return newPossibleRotations;
    }

    private static (int numberOfSteps, int ringPointer) MovePointerClockwise(string ring, char keyCharacter, int ringPointer)
    {
        var clockwiseRotationNumberOfSteps = 0;
        var clockwiseRingPointer = ringPointer;

        for (var i = 0; i < ring.Length; i++)
        {
            if (ring[clockwiseRingPointer] == keyCharacter)
            {
                break;
            }

            clockwiseRingPointer = (clockwiseRingPointer + 1) % ring.Length;
            clockwiseRotationNumberOfSteps++;
        }

        return (clockwiseRotationNumberOfSteps, clockwiseRingPointer);
    }

    private static (int numberOfSteps, int ringPointer) MovePointerCounterclockwise(string ring, char keyCharacter, int ringPointer)
    {
        var counterClockwiseRotationNumberOfSteps = 0;
        var counterClockwiseRingPointer = ringPointer;

        for (var i = 0; i < ring.Length; i++)
        {
            if (ring[counterClockwiseRingPointer] == keyCharacter)
            {
                break;
            }

            counterClockwiseRingPointer--;

            if (counterClockwiseRingPointer < 0)
            {
                counterClockwiseRingPointer = ring.Length - 1;
            }

            counterClockwiseRotationNumberOfSteps++;
        }

        return (counterClockwiseRotationNumberOfSteps, counterClockwiseRingPointer);
    }
}
