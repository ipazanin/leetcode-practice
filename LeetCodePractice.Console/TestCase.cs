// TestCase.cs
//
// © 2023.

using System.Diagnostics;
using System.Globalization;

namespace LeetCodePractice.Console;

public abstract class TestCase
{
    protected static string FormatInputOutputForDisplay<T>(T data)
    {
        return data switch
        {
            Array array => string.Join(',', array.OfType<object>()),
            _ => data?.ToString() ?? string.Empty,
        };
    }

    protected static bool IsResultEqual<T>(T result, T expected)
    {
        if (result is Array resultArray && expected is Array expectedArray)
        {
            if (resultArray.Length != expectedArray.Length)
            {
                return false;
            }

            return Enumerable.SequenceEqual(resultArray.OfType<object>(), expectedArray.OfType<object>());
        }

        return result?.Equals(expected) ?? false;
    }
}

public class TestCase<TResult, TInput> : TestCase
{
    public TestCase(TResult result, TInput input, Func<TInput, TResult> method)
    {
        Result = result;
        Input = input;
        Method = method;
    }

    public TResult Result { get; init; }

    public TInput Input { get; init; }

    public virtual Func<TInput, TResult> Method { get; init; }

    public void Assert()
    {
        var actualResult = Method(Input);

        if (IsResultEqual(Result, actualResult))
        {
            return;
        }

        var message = $"Input: {FormatInputOutputForDisplay(Input)} generated result: {FormatInputOutputForDisplay(actualResult)} instead of: {FormatInputOutputForDisplay(Result)}";

        throw new Exception(message);
    }
}

public class TestCase<TResult, TInput1, TInput2> : TestCase
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

        if (IsResultEqual(Result, actualResult))
        {
            return;
        }

        var message = $"Inputs: {FormatInputOutputForDisplay(Input1)}, {FormatInputOutputForDisplay(Input2)} generated result: {FormatInputOutputForDisplay(actualResult)} instead of: {FormatInputOutputForDisplay(Result)}";

        throw new Exception(message);
    }
}

public class TestCase<TResult, TInput1, TInput2, TInput3> : TestCase
{
    public TestCase(TResult result, TInput1 input1, TInput2 input2, TInput3 input3, Func<TInput1, TInput2, TInput3, TResult> method)
    {
        Result = result;
        Input1 = input1;
        Input2 = input2;
        Input3 = input3;
        Method = method;
    }

    public TResult Result { get; init; }
    public TInput1 Input1 { get; }
    public TInput2 Input2 { get; }
    public TInput3 Input3 { get; }
    public Func<TInput1, TInput2, TInput3, TResult> Method { get; }

    public void Assert()
    {
        var actualResult = Method(Input1, Input2, Input3);

        if (IsResultEqual(Result, actualResult))
        {
            return;
        }

        var message = $"Inputs: {FormatInputOutputForDisplay(Input1)}, {FormatInputOutputForDisplay(Input2)}, {FormatInputOutputForDisplay(Input3)} generated result: {FormatInputOutputForDisplay(actualResult)} instead of: {FormatInputOutputForDisplay(Result)}";

        throw new Exception(message);
    }
}

public class TestCase<TResult, TInput1, TInput2, TInput3, TInput4> : TestCase
{
    public TestCase(TResult result, TInput1 input1, TInput2 input2, TInput3 input3, TInput4 input4, Func<TInput1, TInput2, TInput3, TInput4, TResult> method)
    {
        Result = result;
        Input1 = input1;
        Input2 = input2;
        Input3 = input3;
        Input4 = input4;
        Method = method;
    }

    public TResult Result { get; init; }
    public TInput1 Input1 { get; }
    public TInput2 Input2 { get; }
    public TInput3 Input3 { get; }
    public TInput4 Input4 { get; }
    public Func<TInput1, TInput2, TInput3, TInput4, TResult> Method { get; }

    public void Assert()
    {
        var actualResult = Method(Input1, Input2, Input3, Input4);

        if (IsResultEqual(Result, actualResult))
        {
            return;
        }

        var message = $"Inputs: {FormatInputOutputForDisplay(Input1)}, {FormatInputOutputForDisplay(Input2)}, {FormatInputOutputForDisplay(Input3)}, {FormatInputOutputForDisplay(Input4)} generated result: {FormatInputOutputForDisplay(actualResult)} instead of: {FormatInputOutputForDisplay(Result)}";

        throw new Exception(message);
    }
}

public class TestCase<TResult, TInput1, TInput2, TInput3, TInput4, TInput5> : TestCase
{
    public TestCase(TResult result, TInput1 input1, TInput2 input2, TInput3 input3, TInput4 input4, TInput5 input5, Func<TInput1, TInput2, TInput3, TInput4, TInput5, TResult> method)
    {
        Result = result;
        Input1 = input1;
        Input2 = input2;
        Input3 = input3;
        Input4 = input4;
        Input5 = input5;
        Method = method;
    }

    public TResult Result { get; init; }
    public TInput1 Input1 { get; }
    public TInput2 Input2 { get; }
    public TInput3 Input3 { get; }
    public TInput4 Input4 { get; }
    public TInput5 Input5 { get; }
    public Func<TInput1, TInput2, TInput3, TInput4, TInput5, TResult> Method { get; }

    public void Assert()
    {
        var actualResult = Method(Input1, Input2, Input3, Input4, Input5);

        if (IsResultEqual(Result, actualResult))
        {
            return;
        }

        var message = $"Inputs: {FormatInputOutputForDisplay(Input1)}, {FormatInputOutputForDisplay(Input2)}, {FormatInputOutputForDisplay(Input3)}, {FormatInputOutputForDisplay(Input4)}, {FormatInputOutputForDisplay(Input5)} generated result: {FormatInputOutputForDisplay(actualResult)} instead of: {FormatInputOutputForDisplay(Result)}";

        throw new Exception(message);
    }
}
