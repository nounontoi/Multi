using System;
using System.Collections.Generic;
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
        Console.WriteLine("Mathematical Operations");
        Console.WriteLine("0: Back");
        Console.WriteLine("1: Addition");
        Console.WriteLine("2: Subtracation");
        Console.WriteLine("3: Multiplication");
        Console.WriteLine("4: Pythagoras");
        Console.WriteLine("5: Max");

        int input = Home.GetMenuInput();
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
            Console.Clear();
            Home.HomePage();
            return;
        }

        // invalid input
        if (type == Operations.Error)
        {
            Console.Clear();
            Console.WriteLine("Invalid input");
            Display();
            return;
        }

        Console.WriteLine("\n");
        int result = 0;
        
        // selected operation
        switch (type)
        {
            case Operations.Add:
            case Operations.Subtract:
            case Operations.Multiply:
                Console.WriteLine(type.ToString() + ": ");
                int a = Home.GetIntInput();
                Console.WriteLine("with: ");
                int b = Home.GetIntInput();
                if (type == Operations.Add) result = AddFunc(a, b);
                if (type == Operations.Subtract) result = SubtractFunc(a, b);
                if (type == Operations.Multiply) result = MultiplyFunc(a, b);
                break;
            case Operations.Pythagoras:
                Console.WriteLine("Side a: ");
                a = Home.GetIntInput();
                Console.WriteLine("Side b: ");
                b = Home.GetIntInput();
                Console.WriteLine("Side c: ");
                int c = Home.GetIntInput();
                result = PythagorasFunc(a, b, c);
                break;
            case Operations.Max:
                Console.WriteLine("Enter numbers seperated by enter: ");
                List<int> nums = new List<int>();
                int term = Home.GetIntInput();
                while (term != -1)
                {
                    nums.Add(term);
                    term = Home.GetIntInput();
                }

                int[] d = nums.ToArray();
                // Console.WriteLine(string.Join(" ", d));
                result = MaxFunc(d);
                break;
        }

        // print result
        Console.WriteLine("Answer: " + result);
        Console.WriteLine("");
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