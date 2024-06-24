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
        "[2] Algorithms"
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
                Algorithms.SearchPage();
                break;
            default:
                Console.WriteLine("Invalid number.");
                HomePage();
                break;
        }
    }
}

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
