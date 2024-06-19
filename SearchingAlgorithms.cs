using System;
using System.Collections.Generic;

public class SearchingAlgorithms
{
    // this variables is all u edit to add a new search algorithm (as well as its displau)
    private enum Option
    {
        Back,
        LinearSearch,
        Error = int.MinValue
    }

    private static string[] displayLines = new string[]
    {
        "[0] Back",
        "[1] Linear Search"
    };

    public static void SearchPage()
    {
        Display.WriteAt("Searching Algorithms", Column.Second, 0, ConsoleColor.Cyan);
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

        // rn doesnt worry about option, when adding more add checks to each option
        // custom way to make a row and have it change row by itself
        LineWriter line = new LineWriter(Column.Third, 0);

        line.Next("Linear search");
        line.Next("Input a search query: ");
        int input = line.Get();

        // invalid input
        if (input == int.MinValue)
        {
            line.Next("Invalid input.");
            SearchPage();
            return;
        }

        int result = LinearSearch(input);

        Random rnd2 = new Random(result); // gives a random seed
        int value = rnd2.Next(0, 100);
        line.Next("The value " + value + " exists at index " + result + ".");
        SearchPage();
    }

    public static int LinearSearch(int result)
    {
        bool foundNumber = false;
        int[] rndNumArr = RandomNumberArray();

        Random rnd = new Random();
        int index = rnd.Next(0, rndNumArr.Length);
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

    static int[] RandomNumberArray()
    {
        List<int> numberList = new List<int>();
        for (int i = 0; i < 100; i++)
        {
            Random rnd = new Random();
            numberList.Add(rnd.Next(0, 100));
        }
        return numberList.ToArray();
    }
}