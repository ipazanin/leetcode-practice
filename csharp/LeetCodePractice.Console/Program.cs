// Program.cs
//
// © 2023.

using System.Reflection;

namespace LeetCodePractice.Console;

public static class Program
{
    public static void Main()
    {
        System.Console.WriteLine("Starting C# tests");

        var testCases = GetTestCases();
        foreach (var testCase in testCases)
        {
            try
            {
                testCase.Assert();
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }

    private static IList<TestCase> GetTestCases()
    {
        const string MethodName = "GetTestCases";

        return Assembly
            .GetExecutingAssembly()
            .GetTypes()
            .Where(type => type.GetMethods(BindingFlags.Static | BindingFlags.Public).Any(method => method.Name == MethodName))
            .Select(type => type.GetMethod(MethodName)!.Invoke(null, null) as IEnumerable<TestCase>)
            .SelectMany(testCases => testCases!)
            .ToArray();
    }
}
