using System;
using System.Collections.Generic;

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
            int gap = Console.WindowWidth / 3;
            string EmptySpace = new string(' ', gap);
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
    public bool HasBadInput = false;

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
    public int Get(bool ignoreErr = false)
    {
        row++;
        int input = Input.GetInputWithPos(column, row - 1);
        if (input == int.MinValue && !ignoreErr) HasBadInput = true;
        return input;
    }

    /// <summary>
    /// Get a list of numbers seperated by enter
    /// </summary>
    public int[] GetList()
    {
        List<int> nums = new List<int>();
        int term = Get(true);
        while (term != int.MinValue)
        {
            nums.Add(term);
            term = Get(true);
        }
        return nums.ToArray();
    }

    public void Err(Action passedFunc)
    {
        if (HasBadInput)
        {
            Next("Invalid input.");
            return;
        }
        passedFunc();
    }
}

public enum Column
{
    First,
    Second,
    Third
}