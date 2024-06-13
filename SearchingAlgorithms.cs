using System;
using System.Collections.Generic;

public class SearchingAlgorithms
{
    public static void Display()
    {
        Console.Clear();
        Console.WriteLine("Searching Algorithms");
        Console.WriteLine("0: Back");
        Console.WriteLine("1: Linear Search");
        string userInput = Console.ReadLine();

        try
        {
            if (userInput == string.Empty)
            {
                Display();
            }

            int result = Int32.Parse(userInput);
            switch (result)
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
                    // Console.WriteLine("Invalid page number.");
                    Display();
                    break;
            }
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
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
        string searchQuery = Console.ReadLine();

        try
        {
            int result = Int32.Parse(searchQuery);
            for (int i = 0; i < rndNumArr.Length; i++)
            {
                if (rndNumArr[i] == result)
                {
                    foundNumber = true;
                }
            }

            Random rnd = new Random();
            int index = rnd.Next(0, rndNumArr.Length);
            int value = rndNumArr[index];

            Console.WriteLine("The value " + value + " exists at index " + index + ".");
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }

        Console.WriteLine("");
        Console.WriteLine("0: Back");
        Console.WriteLine("1: Linear Search");
        string userInput = Console.ReadLine();

        try
        {
            if (userInput == string.Empty)
            {
                Display();
            }

            int result = Int32.Parse(userInput);
            switch (result)
            {
                case 0:
                    Console.Clear();
                    SearchingAlgorithms.Display();
                    break;
                case 1:
                    Console.Clear();
                    LinearSearch();
                    break;
                default:
                    // Console.WriteLine("Invalid number.");
                    Display();
                    break;
            }
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}