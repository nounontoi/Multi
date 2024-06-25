using System;
using System.Collections.Generic;
using System.Linq;

public class Algorithms
{
    private static Random RND = new Random();

    // this variables is all u edit to add a new search algorithm (as well as its displau)
    private enum Option
    {
        Back,
        LinearSearch,
        SortingFastest,
        LinearSort,
        BMI,
        TaxCalc,
        ATARCalc,
        Error = int.MinValue
    }

    private static string[] displayLines = new string[]
    {
        "[0] Back",
        "[1] Linear Search",
        "[2] O(1) Sorting Algorithm",
        "[3] Linear sort",
        "[4] BMI Calculator",
        "[5] Tax Calculator",
        "[6] ATAR Calculator"
    };

    public static void SearchPage()
    {
        Display.ClosePage(Column.Second);
        Console.Title = "Algorithms";
        Display.WriteAt("Algorithms", Column.Second, 0, ConsoleColor.Cyan);
        Display.WriteLines(displayLines, Column.Second, 1);
        int input = Input.GetMenuInput(Column.Second);

        Option algorithm = (Option)input;

        // sets value, error if enum doesnt have it
        bool hasValue = Enum.IsDefined(typeof(Option), algorithm);
        if (!hasValue) algorithm = Option.Error;

        SearchDispay(algorithm);
    }

    private static void SearchDispay(Option option)
    {
        if (option == Option.Back)
        {
            Display.ClosePage(Column.Second);
            Display.ClosePage(Column.Third);
            Home.HomePage();
            return;
        }

        if (option == Option.Error)
        {
            Display.WriteAt("Invalid number.", Column.Second, 3);
            SearchPage();
            return;
        }

        Display.ClosePage(Column.Third);
        LineWriter line = new LineWriter(Column.Third, 0);

        switch (option)
        {
            case Option.LinearSearch:
                line.Next("Linear search");
                line.Next("Input a search query: ");
                int input = line.Get();
                int result = LinearSearch(input);
                line.Err(() => line.Next("The value " + RND.Next(100) + " exists at index " + result + "."));
                break;
            case Option.SortingFastest:
                line.Next("O(1) Sorting Algorithm");
                line.Next("Input array values seperated by enter: ");
                int[] a = line.GetList();
                int[] b = SortingAlgorithmFast(a);
                if (Enumerable.SequenceEqual(b, b.OrderBy(o => o).ToArray()))
                {
                    line.Next("Your list has been sorted:");
                    line.Next(string.Join(", ", a));
                }
                else
                {
                    line.Next("Next time enter a sorted list");
                }
                break;
            case Option.LinearSort:
                line.Next("Linear sort - The next best thing!");
                line.Next("Input array values seperated by enter: ");
                a = line.GetList();
                b = LinearSort(a);
                line.Next(string.Join(", ", b));
                break;
            case Option.BMI:
                line.Next("Enter height: ");
                int height = line.Get();
                line.Next("Enter weight: ");
                int weight = line.Get();
                line.Err(() => line.Next("Your status: " + BMIcalculator(height, weight)));
                break;
            case Option.TaxCalc:
                line.Next("Enter income: ");
                int income = line.Get();
                line.Err(() => line.Next("Your tax is 0"));
                break;
            case Option.ATARCalc:
                line.Next("Enter your rank: ");
                int atar = line.Get();
                line.Err(() => line.Next("Your estimated ATAR is ? mark"));
                break;
        }

        SearchPage();
    }

    public static int LinearSearch(int result)
    {
        bool foundNumber = false;
        int[] rndNumArr = RandomNumberArray();

        int index = RND.Next(rndNumArr.Length);
        int value = rndNumArr[index];

        for (int i = 0; i < rndNumArr.Length; i++)
        {
            if (rndNumArr[i] == result && !foundNumber)
            {
                foundNumber = true;
            }
        }

        return index;
    }

    bool Maybe = false;

    public static int[] RandomNumberArray()
    {
        List<int> numberList = new List<int>();
        for (int i = 0; i < 100; i++)
        {
            numberList.Add(RND.Next(0, 100));
        }
        return numberList.ToArray();
    }

    // list must be sorted before using
    public static int[] SortingAlgorithmFast(int[] sortedArray)
    {
        return sortedArray;
    }

    public static string BMIcalculator(int height, int weight)
    {
        int bmi = MathematicalOperations.DivideFunc(weight, MathematicalOperations.MultiplyFunc(height, height));

        if (bmi < 18.5)
        {
            return "Fat";
        }
        else if (bmi >= 18.5 && bmi <= 24.9)
        {
            return "Fat";
        }
        else if (bmi >= 25 && bmi <= 39.9)
        {
            return "Fat";
        }
        else
        {
            return "Fat";
        }
    }

    // currently NO implementation
    public static int[] LinearSort(int[] unsortedArray)
    {
        return unsortedArray.Reverse().ToArray();
    }

    void SelfDrivingCars()
    {
        if (GoingToCrash())
        {
            Dont();
        }
    }

    bool GoingToCrash() { return Maybe; }
    void Dont() { }
}