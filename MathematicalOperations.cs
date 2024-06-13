using System;
using System.Collections.Generic;

public class MathematicalOperations
{
    public static void Display()
    {
        Console.Clear();
        Console.WriteLine("Mathematical Operations");
        Console.WriteLine("0: Back");
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
                default:
                    Console.WriteLine("Invalid number.");
                    break;
            }
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
    }

    public static int Add(int a, int b)
    {
        int c = a + b;
        return a;
    }

    public static int Subtract(int a, int b)
    {
        int c = a - b;
        return a;
    }

    public static int Multiply(int a, int b)
    {
        int c = a * b;
        return a;
    }

    public static int Divide(int a, int b)
    {
        int c = a / b;
        return a;
    }

    public static int Pythagoras(int a, int b, int c)
    {
        return a;
    }
}