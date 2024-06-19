using System;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

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
        Console.SetWindowSize(170, 30);

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(ASCII);
        Console.ResetColor();
        Console.WriteLine("Multiply: ");
        int result1 = GetIntInput();

        Console.WriteLine("with: ");
        int result2 = GetIntInput();

        if (result1 == int.MinValue || result2 == int.MinValue)
        {
            InvalidInput("Invalid input.");
            return;
        }
        Console.Clear();

        // Console.WriteLine("Answer: " + result2);
        HomePage();
    }

    public static void HomePage()
    {
        WriteAt("Home", 0, 0, ConsoleColor.Cyan);
        string[] displayLines = new string[] {
            "[0] Quit",
            "[1] Mathematical Operations",
            "[2] Searching Algorithms"
        };
        WriteLines(displayLines, 0, 1);

        int input = GetMenuInput();

        switch (input)
        {
            case 0:
                Environment.Exit(0);
                break;
            case 1:
                // Console.Clear();
                MathematicalOperations.Display();
                break;
            case 2:
                // Console.Clear();
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
        if (input == null) return int.MinValue;
        if (input == string.Empty) return int.MinValue;

        try
        {
            return int.Parse(input);
        }
        catch
        {
            return int.MinValue;
        }
    }

    public static int GetMenuInput(int colNum = 0)
    {
        Console.SetCursorPosition(colNum, 10);
        var input = Console.ReadKey(true);

        string key = input.KeyChar.ToString();
        if (key == string.Empty) return int.MinValue;

        try
        {
            return int.Parse(key);
        }
        catch
        {
            return int.MinValue;
        }
    }

    public static void InvalidInput(string text)
    {
        Console.Clear();
        Console.WriteLine(text);
        HomePage();
    }

    public static int startCol2 = 40;
    public static int startCol3 = 80;

    public static void WriteAt(string line, int xCoord, int yCoord, ConsoleColor colour = ConsoleColor.Gray)
    {
        Console.SetCursorPosition(xCoord, yCoord);
        Console.ForegroundColor = colour;
        Console.WriteLine(line);
        Console.ResetColor();
    }

    public static void WriteLines(string[] lines, int xCoord, int yCoord, ConsoleColor colour = ConsoleColor.Gray)
    {
        Console.ForegroundColor = colour;
        foreach (string line in lines)
        {
            Console.SetCursorPosition(xCoord, yCoord);
            Console.WriteLine(line);
            yCoord++;
        }
        Console.ResetColor();
    }

    public static void ClosePage(int column)
    {
        for (int row = 0; row < 20; row++)
        {
            for (int col = column; col < column + 80; col++)
            {
                WriteAt(" ", col, row);
            }
        }
        // Console.Clear();
        // HomePage();
        // switch (className)
        // {
        //     case "MathematicalOperations":
        //         MathematicalOperations.Display();
        //         break;
        //     case "SearchingAlgorithms":
        //         SearchingAlgorithms.Display();
        //         break;
        //     default:
        //         HomePage();
        //         break;
        // }
    }

    public static void ClearRow(int left, int row)
    {
        for (int col = left; col < left + 50; col++)
        {
            WriteAt(" ", col, row);
        }

    }

}
