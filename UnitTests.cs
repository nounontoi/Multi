using System;
using System.Linq;

public class UnitTests
{
    public static void Main()
    {
        int[] test1 = OperationTest();
        OutputResult("Operations test", test1[0], test1[1]);

        int[] test2 = AlgorithmsTest();
        OutputResult("Algorithms test", test2[0], test2[1]);
    }

    private static void OutputResult(string text, int passed, int total)
    {
        if (passed == 0)
        { // passed
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(text + ": " + passed + "/" + total + " passed");
            Console.ResetColor();
        }
        else
        { // failed
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text + ": " + passed + "/" + total + " passed");
            Console.ResetColor();
        }
    }

    public static int[] OperationTest()
    {
        bool[] tests = new bool[] {

            MathematicalOperations.AddFunc(1, 2) == 3,
            MathematicalOperations.SubtractFunc(4, 2) == 2,
            MathematicalOperations.MultiplyFunc(1, 2) == 2,
            MathematicalOperations.DivideFunc(4, 2) == 2,
            MathematicalOperations.PythagorasFunc(1, 2, 3) == 3,
            MathematicalOperations.MaxFunc(new int[] { 1, 2, 3 }) == 3

        };

        // returns count of passed tests, and total tests in an array
        return new int[] { tests.Count(c => c), tests.Length };
    }

    public static int[] AlgorithmsTest()
    {
        bool[] tests = new bool[] {

            Algorithms.LinearSearch(1) == 1,

        };

        // returns count of passed tests, and total tests in an array
        return new int[] { tests.Count(c => c), tests.Length };
    }
}