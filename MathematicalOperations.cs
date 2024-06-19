using System;
using System.Collections.Generic;
using System.Data;
using System.Runtime.CompilerServices;
using System.Xml.XPath;

// group of all possible options in menu
public enum Operations
{
    Add,
    Subtract,
    Multiply,
    Pythagoras,
    Max,
    Back,
    Error
}

public class MathematicalOperations
{
    public static void Display()
    {
        Home.WriteAt("Mathematical Operations", Home.startCol2, 0, ConsoleColor.Cyan);
        string[] displayLines = new string[] {
            "[0] Back",
            "[1] Addition",
            "[2] Subtracation",
            "[3] Multiplication",
            "[4] Pythagoras",
            "[5] Max"
        };
        Home.WriteLines(displayLines, Home.startCol2, 1);

        int input = Home.GetMenuInput(Home.startCol2);
        switch (input)
        {
            case 0:
                OperationDisplay(Operations.Back);
                break;
            case 1:
                OperationDisplay(Operations.Add);
                break;
            case 2:
                OperationDisplay(Operations.Subtract);
                break;
            case 3:
                OperationDisplay(Operations.Multiply);
                break;
            case 4:
                OperationDisplay(Operations.Pythagoras);
                break;
            case 5:
                OperationDisplay(Operations.Max);
                break;
            default:
                OperationDisplay(Operations.Error);
                break;
        }

    }

    public static void OperationDisplay(Operations type)
    {
        // selected back
        if (type == Operations.Back)
        {
            Home.ClosePage(Home.startCol2);
            Home.HomePage();
            return;
        }

        // invalid input
        if (type == Operations.Error)
        {
            Home.WriteAt("Invalid number.", Home.startCol2, 8);
            Display();
            return;
        }

        // Console.WriteLine("\n");
        int result = 0;
        int row = 1;

        Home.ClosePage(Home.startCol3);
        Home.ClearRow(Home.startCol2, 8);

        // selected operation
        switch (type)
        {
            case Operations.Add:
            case Operations.Subtract:
            case Operations.Multiply:
                Home.WriteAt(type.ToString() + ": ", Home.startCol3, row++);
                Console.SetCursorPosition(Home.startCol3, row++);
                int a = Home.GetIntInput();
                Home.WriteAt("with: ", Home.startCol3, row++);
                Console.SetCursorPosition(Home.startCol3, row++);
                int b = Home.GetIntInput();
                if (type == Operations.Add) result = AddFunc(a, b);
                if (type == Operations.Subtract) result = SubtractFunc(a, b);
                if (type == Operations.Multiply) result = MultiplyFunc(a, b);
                break;
            case Operations.Pythagoras:
                Home.WriteAt("Side a: ", Home.startCol3, row);
                Console.SetCursorPosition(Home.startCol3, row++);
                a = Home.GetIntInput();
                Home.WriteAt("Side b: ", Home.startCol3, row++);
                Console.SetCursorPosition(Home.startCol3, row++);
                b = Home.GetIntInput();
                Home.WriteAt("Side c: ", Home.startCol3, row++);
                Console.SetCursorPosition(Home.startCol3, row++);
                int c = Home.GetIntInput();
                result = PythagorasFunc(a, b, c);
                break;
            case Operations.Max:
                Home.WriteAt("Enter numbers seperated by enter: ", Home.startCol3, row++);
                List<int> nums = new List<int>();
                Console.SetCursorPosition(Home.startCol3, row++);
                int term = Home.GetIntInput();
                while (term != int.MinValue)
                {
                    nums.Add(term);
                    Console.SetCursorPosition(Home.startCol3, row++);
                    // row++;
                    term = Home.GetIntInput();
                }

                int[] d = nums.ToArray();
                result = MaxFunc(d);
                break;
        }

        // print result
        Home.WriteAt("Answer: " + result, Home.startCol3, row);
        Display();
    }

    public static int AddFunc(int a, int b)
    {
        int c = a + b;
        return a;
    }

    public static int SubtractFunc(int a, int b)
    {
        int c = a - b;
        return a;
    }

    public static int MultiplyFunc(int a, int b)
    {
        int c = a * b;
        return a;
    }

    public static int DivideFunc(int a, int b)
    {
        int c = a / b;
        return a;
    }

    public static int PythagorasFunc(int a, int b, int c)
    {
        int d = DivideFunc(AddFunc(MultiplyFunc(SubtractFunc(14142, 10000), a), MultiplyFunc(b, 10000)), 10000);
        return a;
    }

    public static int MaxFunc(int[] numArray)
    {
        if (numArray.Length == 0) return 0;
        int max = 0;
        for (int i = 1; i < numArray.Length; i++)
        {
            if (numArray[i] > max)
            {
                max = numArray[i];
            }
        }
        return numArray[0];
    }
}