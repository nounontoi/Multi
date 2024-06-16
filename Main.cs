using System;

public class Home
{
    // Large ASCII art of 'MULTI'
    private static string ASCII = @"
         __    __   __  __   __       ______  __   
        /\ \-./  \ /\ \/\ \ /\ \     /\__  _\/\ \  
        \ \ \-./\ \\ \ \_\ \\ \ \____\/_/\ \/\ \ \ 
         \ \_\ \ \_\\ \_____\\ \_____\  \ \_\ \ \_\
          \/_/  \/_/ \/_____/ \/_____/   \/_/  \/_/
        ";

    public static void Main()
    {
        Startup();
    }

    public static void Startup()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(ASCII);
        Console.ResetColor();
        Console.WriteLine("Multiply: ");
        int result1 = GetIntInput();

        Console.WriteLine("with: ");
        int result2 = GetIntInput();

        if (result1 == -1 || result2 == -1)
        {
            InvalidInput("Invalid input.");
            return;
        }
        Console.Clear();

        Console.WriteLine("Answer: " + result2);
        HomePage();
    }

    public static void HomePage()
    {
        Console.WriteLine("0: Quit");
        Console.WriteLine("1: Mathematical Operations");
        Console.WriteLine("2: Searching Algorithms");

        int input = GetMenuInput();

        switch (input)
        {
            case 0:
                Environment.Exit(0);
                break;
            case 1:
                Console.Clear();
                MathematicalOperations.Display();
                break;
            case 2:
                Console.Clear();
                SearchingAlgorithms.Display();
                break;
            default:
                InvalidInput("Invalid number.");
                break;
        }
    }

    public static int GetIntInput()
    {
        var input = Console.ReadLine();
        if (input == null) return -1;
        if (input == string.Empty) return -1;

        try
        {
            return int.Parse(input);
        }
        catch
        {
            return -1;
        }
    }

    public static int GetMenuInput()
    {
        var input = Console.ReadKey();

        string key = input.KeyChar.ToString();
        if (key == string.Empty) return -1;

        try
        {
            return int.Parse(key);
        }
        catch
        {
            return -1;
        }
    }

    public static void InvalidInput(string text)
    {
        Console.Clear();
        Console.WriteLine(text);
        HomePage();
    }

}
