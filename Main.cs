using System;

public class Home
{
    public static void Main(string[] args)
    {
        HomePage();
    }

    public static void HomePage()
    {
        Console.WriteLine("0: Quit.");
        Console.WriteLine("1: Mathematical Operations.");
        Console.WriteLine("2: Searching Algorithms.");

        Console.WriteLine("Input: ");
        string userInput = Console.ReadLine();

        if (userInput == string.Empty)
        {
            HomePage();
        }

        try
        {
            int result = Int32.Parse(userInput);
            switch (result)
            {
                case 0:
                    break;
                case 1:
                    Console.Clear();
                    MathematicalOperations.Display();
                    break;
                case 2:
                    Console.Clear();
                    SearchingAlgorithms.Display();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Invalid number.");
                    HomePage();
                    break;
            }
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
