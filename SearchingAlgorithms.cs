using System;
using System.Collections.Generic;

public class SearchingAlgorithms
{
    public static void Display()
    {
        Console.WriteLine("Searching Algorithms");
        Console.WriteLine("[0] Back");
        Console.WriteLine("[1] Linear Search");
        int input = Home.GetMenuInput();

        switch (input)
        {
            case 0:
                Console.Clear();
                Home.HomePage();
                break;
            case 1:
                Console.Clear();
                LinearSearchDispay();
                break;
            default:
                Console.WriteLine("Invalid number.");
                Console.Clear();
                Display();
                break;
        }
    }

    public static void LinearSearchDispay()
    {
        Console.WriteLine("Input a search query");
        int input = Home.GetIntInput();
        if (input == -1)
        {
            Console.WriteLine("Invalid input.");
            LinearSearchDispay();
            return;
        }

        int result = LinearSearch(input);

        Random rnd2 = new Random(result); // gives a random seed
        int value = rnd2.Next(0, 100);
        Console.WriteLine("The value " + value + " exists at index " + result + ".");
        Console.WriteLine("");
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