using System;
using System.Collections.Generic;

public class MathematicalOperations
{
    public static void Display()
    {
        Console.Clear();
        Console.WriteLine("Mathematical Operations");
        Console.WriteLine("0: Back");
        int result = Home.GetIntInput();

        switch (result)
        {
            case 0:
                Console.Clear();
                Home.HomePage();
                break;
            default:
                Console.WriteLine("Invalid number.");
                Display();
                break;
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
        int d = Divide(Add(Multiply(Subtract(14142, 10000), a), Multiply(b, 10000)), 10000);
        return a;
    }
}