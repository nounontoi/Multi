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
        Console.SetWindowSize(170, 30);

        Display.WriteColour(ASCII, ConsoleColor.Green);
        Console.WriteLine("Multiply: ");
        int result1 = Input.GetIntInput();

        Console.WriteLine("with: ");
        int result2 = Input.GetIntInput();

        if (result1 == int.MinValue || result2 == int.MinValue)
        {
            Console.WriteLine("Invalid input.");
        }
        Console.Clear();

        // Console.WriteLine("Answer: " + result2);
        HomePage();
    }

    private static string[] displayLines = new string[] {
        "[0] Quit",
        "[1] Mathematical Operations",
        "[2] Searching Algorithms"
    };

    public static void HomePage()
    {
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

    public static void WriteLines(string[] lines, Column column, int yCoord, ConsoleColor colour = ConsoleColor.Gray)
    {
        int xCoord = ColToCoord(column);
        Console.ForegroundColor = colour;
        foreach (string line in lines)
        {
            Console.SetCursorPosition(xCoord, yCoord);
            Console.WriteLine(line);
            yCoord++;
        }
        Console.ResetColor();
    }

    public static void ClosePage(Column column)
    {
        for (int row = 0; row < 20; row++) // clears up to 20 rows, maybe better to clear whole screen column
        {
            // instead of looping through each col, just found how many spaces to fill and filled them all - faster
            int remainingSpace = Console.WindowWidth - ColToCoord(column);
            string EmptySpace = new string(' ', remainingSpace);
            WriteAt(EmptySpace, column, row);
        }

        // idk what this does so i left it

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

    public static void ClearRow(Column column, int row)
    {
        string EmptySpace = new string(' ', 50);
        WriteAt(EmptySpace, column, row);
    }

    // convert column to x coord
    public static int ColToCoord(Column column)
    {
        switch (column)
        {
            case Column.First:
                return 0;
            case Column.Second:
                return 40;
            case Column.Third:
                return 80;
            default:
                return 0;
        }
    }
}

// this is basically a way to store a variable with a bunch of functions attached to directly modify it
// this will some explaining to do sorry
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
