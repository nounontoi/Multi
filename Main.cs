using System;
using System.Security.Principal;

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
        Console.SetWindowSize(Console.WindowWidth, Console.WindowHeight - 1);
        Console.Title = "Multi";
        Startup();
    }

    public static void Startup()
    {
        Display.WriteColour(ASCII, ConsoleColor.Green);
        Console.WriteLine("Multiply: ");
        int result1 = Input.GetIntInput();

        Console.WriteLine("with: ");
        object result2 = Input.GetIntInput();
        if ((int)result2 == int.MinValue) result2 = "Invalid input.";

        Console.Clear();
        Display.WriteAt("Answer: " + result2, Column.Second, 0);
        HomePage();
    }

    private static string[] displayLines = new string[] {
        "[0] Quit",
        "[1] Mathematical Operations",
        "[2] Searching Algorithms"
    };

    public static void HomePage()
    {
        Console.Title = "Multi";
        Display.WriteAt("Home", 0, 0, ConsoleColor.Cyan);
        Display.WriteLines(displayLines, 0, 1);

        int input = Input.GetMenuInput();

        switch (input)
        {
            case 0:
                Environment.Exit(0);
                break;
            case 1:
                MathematicalOperations.OperationPage();
                break;
            case 2:
                SearchingAlgorithms.SearchPage();
                break;
            default:
                Console.WriteLine("Invalid number.");
                HomePage();
                break;
        }
    }
}

// Probably should put thiese in a different file or something
public class Input
{
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

    public static int GetInputWithPos(Column column, int top)
    {
        Console.SetCursorPosition(Display.ColToCoord(column), top);
        return GetIntInput();
    }

    public static int GetMenuInput(Column column = Column.First)
    {
        int colNum = Display.ColToCoord(column);
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
}

public class Display
{
    public static void WriteAt(string line, Column column, int yCoord, ConsoleColor colour = ConsoleColor.Gray)
    {
        int xCoord = ColToCoord(column);
        Console.SetCursorPosition(xCoord, yCoord);
        WriteColour(line, colour);
    }

    public static void WriteColour(string text, ConsoleColor colour)
    {
        Console.ForegroundColor = colour;
        Console.WriteLine(text);
        Console.ResetColor();
    }

    public static void WriteLines(string[] lines, Column column, int yCoord)
    {
        LineWriter lineWriter = new LineWriter(column, yCoord);
        foreach (string line in lines)
        {
            lineWriter.Next(line);
        }
    }

    public static void ClosePage(Column column)
    {
        for (int row = 0; row < Console.WindowHeight; row++)
        {
            int remainingSpace = Console.WindowWidth - ColToCoord(column);
            string EmptySpace = new string(' ', remainingSpace);
            WriteAt(EmptySpace, column, row);
        }
    }

    public static int ColToCoord(Column column)
    {
        int gap = Console.WindowWidth / 3;
        return (int)column * gap;
    }
}

public class LineWriter
{
    public int row;
    public Column column;

    public LineWriter(Column column, int StartRow = 1)
    {
        this.row = StartRow;
        this.column = column;
    }

    /// <summary>
    /// Write text then enter next line
    /// </summary>
    public void Next(string line)
    {
        Display.WriteAt(line, column, row);
        row++;
    }

    /// <summary>
    /// Get an input from user using GetInput() method
    /// </summary>
    public int Get()
    {
        row++;
        return Input.GetInputWithPos(column, row - 1);
    }
}

public enum Column
{
    First,
    Second,
    Third
}
