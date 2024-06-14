using System;
using System.Collections.Generic;
using System.Xml.XPath;

public class MathematicalOperations
{
    public static void Display()
    {
        Console.Clear();
        Console.WriteLine("Mathematical Operations");
        Console.WriteLine("0: Back");
        Console.WriteLine("1: Addition");
        Console.WriteLine("2: Subtracation");
        Console.WriteLine("3: Multiplication");
        int result = Home.GetIntInput();

        switch (result)
        {
            case 0:
                Console.Clear();
                Home.HomePage();
                break;
            case 1:
                Console.Clear();
                AddDisplay();
                break;
            case 2:
                Console.Clear();
                SubtractDisplay();
                break;
            case 3:
                Console.Clear();
                MultiplyDisplay();
                break;
            default:
                Console.WriteLine("Invalid number.");
                Display();
                break;
        }
    }

    public static void AddDisplay()
    {
        Console.Clear();
        Console.WriteLine("Add: ");
        int a = Home.GetIntInput();

        Console.WriteLine("with: ");
        int b = Home.GetIntInput();

        int result = AddFunc(a, b);
        Console.WriteLine("Answer: " + result);


        Console.WriteLine("");
        Console.WriteLine("0: Back");
        Console.WriteLine("1: Addition");

        int userInput = Home.GetIntInput();
        switch (userInput)
        {
            case 0:
                Console.Clear();
                Display();
                break;
            case 1:
                Console.Clear();
                AddDisplay();
                break;
            default:
                // Console.WriteLine("Invalid number.");
                Display();
                break;
        }
    }

    public static void SubtractDisplay()
    {
        Console.Clear();
        Console.WriteLine("Subtract: ");
        int b = Home.GetIntInput();

        Console.WriteLine("from: ");
        int a = Home.GetIntInput();

        int result = SubtractFunc(a, b);
        Console.WriteLine("Answer: " + result);


        Console.WriteLine("");
        Console.WriteLine("0: Back");
        Console.WriteLine("1: Subtraction");

        int userInput = Home.GetIntInput();
        switch (userInput)
        {
            case 0:
                Console.Clear();
                Display();
                break;
            case 1:
                Console.Clear();
                SubtractDisplay();
                break;
            default:
                // Console.WriteLine("Invalid number.");
                Display();
                break;
        }
    }

    public static void MultiplyDisplay()
    {
        Console.Clear();
        Console.WriteLine("Multiply: ");
        int a = Home.GetIntInput();

        Console.WriteLine("with: ");
        int b = Home.GetIntInput();

        int result = MultiplyFunc(a, b);
        Console.WriteLine("Answer: " + result);


        Console.WriteLine("");
        Console.WriteLine("0: Back");
        Console.WriteLine("1: Multiply");

        int userInput = Home.GetIntInput();
        switch (userInput)
        {
            case 0:
                Console.Clear();
                Display();
                break;
            case 1:
                Console.Clear();
                MultiplyDisplay();
                break;
            default:
                // Console.WriteLine("Invalid number.");
                Display();
                break;
        }
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
        return a;
    }

    public static int MaxFunc(int[] numArray)
    {
        int max = 0;
        for (int i = 0; i < numArray.Length; i++)
        {
            if (numArray[i + 1] > numArray[i])
            {
                max = numArray[i + 1];
            }
        }
        return max;
    }
}