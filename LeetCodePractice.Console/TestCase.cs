// TestCase.cs
//
// © 2023.

using System.Diagnostics;

namespace LeetCodePractice.Console;

public class TestCase<TResult, TInput>
{
    public TestCase(TResult result, TInput input, Func<TInput, TResult> method)
    {
        Result = result;
        Input = input;
        Method = method;
    }

    public TResult Result { get; init; }

    public TInput Input { get; init; }

    public Func<TInput, TResult> Method { get; init; }

    public void Assert()
    {
        var actualResult = Method(Input);

        if (!Result.Equals(actualResult))
        {
            var inputString = Input switch
            {
                Array array => string.Join(',', array.OfType<object>()),
                _ => Input.ToString(),
            };

            var actualResultString = actualResult switch
            {
                Array array => string.Join(',', array.OfType<object>()),
                _ => actualResult.ToString(),
            };

            var resultString = Result switch
            {
                Array array => string.Join(',', array.OfType<object>()),
                _ => Result.ToString(),
            };

            var message = $"Input: {inputString} generated result: {actualResultString} instead of: {resultString}";

            throw new Exception(message);
        }
    }
}
