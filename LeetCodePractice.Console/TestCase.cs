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

        if (!Result!.Equals(actualResult))
        {
            var inputString = Input switch
            {
                Array array => string.Join(',', array.OfType<object>()),
                _ => Input!.ToString(),
            };

            var actualResultString = actualResult switch
            {
                Array array => string.Join(',', array.OfType<object>()),
                _ => actualResult!.ToString(),
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

public class TestCase<TResult, TInput1, TInput2>
{
    public TestCase(TResult result, TInput1 input1, TInput2 input2, Func<TInput1, TInput2, TResult> method)
    {
        Result = result;
        Input1 = input1;
        Input2 = input2;
        Method = method;
    }

    public TResult Result { get; init; }
    public TInput1 Input1 { get; }
    public TInput2 Input2 { get; }
    public Func<TInput1, TInput2, TResult> Method { get; }

    public void Assert()
    {
        var actualResult = Method(Input1, Input2);

        if (!Result!.Equals(actualResult))
        {
            var input1String = Input1 switch
            {
                Array array => string.Join(',', array.OfType<object>()),
                _ => Input1!.ToString(),
            };

            var input2String = Input2 switch
            {
                Array array => string.Join(',', array.OfType<object>()),
                _ => Input2!.ToString(),
            };

            var actualResultString = actualResult switch
            {
                Array array => string.Join(',', array.OfType<object>()),
                _ => actualResult!.ToString(),
            };

            var resultString = Result switch
            {
                Array array => string.Join(',', array.OfType<object>()),
                _ => Result.ToString(),
            };

            var message = $"Inputs: {input1String}, {input2String} generated result: {actualResultString} instead of: {resultString}";

            throw new Exception(message);
        }
    }
}
