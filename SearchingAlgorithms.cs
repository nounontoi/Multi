using System;
using System.Collections.Generic;

public class SearchingAlgorithms
{
    public static void Display()
    {
        Home.WriteAt("Searching Algorithms", Home.startCol2, 0, ConsoleColor.DarkYellow);
        string[] displayLines = new string[] {
            "[0] Back",
            "[1] Linear Search"
        };
        Home.WriteLines(displayLines, Home.startCol2, 1);
        int input = Home.GetMenuInput(Home.startCol2);

        switch (input)
        {
            case 0:
                Home.ClosePage(Home.startCol2);
                Home.HomePage();
                break;
            case 1:
                LinearSearchDispay();
                break;
            default:
                Home.WriteAt("Invalid number.", Home.startCol2, 3);
                // Console.Clear();
                Display();
                break;
        }
    }

    public static void LinearSearchDispay()
    {
        Home.ClearRow(Home.startCol3, 2);
        Home.ClearRow(Home.startCol3, 3);
        Home.WriteAt("Linear search", Home.startCol3, 0);
        Home.WriteAt("Input a search query: ", Home.startCol3, 1);
        Console.SetCursorPosition(Home.startCol3, 2);
        int input = Home.GetIntInput();
        if (input == int.MinValue)
        {
            Home.ClearRow(Home.startCol3, 2);
            Home.ClearRow(Home.startCol3, 3);
            Home.WriteAt("Invalid input.", Home.startCol3, 3);
            Display();
            return;
        }

        int result = LinearSearch(input);

        Random rnd2 = new Random(result); // gives a random seed
        int value = rnd2.Next(0, 100);
        Home.WriteAt("The value " + value + " exists at index " + result + ".", Home.startCol3, 3);
        Display();
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