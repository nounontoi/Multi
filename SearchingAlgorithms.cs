using System;
using System.Collections.Generic;

public class SearchingAlgorithms
{
    public static void Display()
    {
        Console.WriteLine("Searching Algorithms");
        Console.WriteLine("0: Back");
        Console.WriteLine("1: Linear Search");
        int userInput = Home.GetIntInput();

        switch (userInput)
        {
            case 0:
                Console.Clear();
                Home.HomePage();
                break;
            case 1:
                Console.Clear();
                LinearSearch();
                break;
            default:
                Console.WriteLine("Invalid number.");
                Console.Clear();
                Display();
                break;
        }
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

    public static void LinearSearch()
    {
        bool foundNumber = false;
        int[] rndNumArr = RandomNumberArray();

        Console.WriteLine("Input a search query");
        int result = Home.GetIntInput();

        if (result == -1)
        {
            Console.Clear();
            LinearSearch();
        }
        Random rnd = new Random();
        int index = rnd.Next(0, rndNumArr.Length);
        int value = rndNumArr[index];

        Console.WriteLine("The value " + value + " exists at index " + index + ".");

        for (int i = 0; i < rndNumArr.Length; i++)
        {
            if (rndNumArr[i] == result)
            {
                foundNumber = true;
            }
        }

        if (foundNumber) { }
        // Random rnd = new Random();
        // int index = rnd.Next(0, rndNumArr.Length);
        // int value = rndNumArr[index];

        // Console.WriteLine("The value " + value + " exists at index " + index + ".");
        Console.WriteLine("");
        Display();
    }
}