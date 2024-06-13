using System;

public class Home
{
    public static void Main(string[] args)
    {
        HomePage();
        // Startup();
    }

    public static void Startup()
    {
        // Large ASCII art of 'MULTI'

        // Takes two user integer inputs, then returns the second input

        // Takes user to HomePage()
    }

    public static void HomePage()
    {
        Console.WriteLine("0: Quit");
        Console.WriteLine("1: Mathematical Operations");
        Console.WriteLine("2: Searching Algorithms");

        Console.WriteLine("Input: ");
        string userInput = Console.ReadLine();

        try
        {
            if (userInput == string.Empty)
            {
                Console.Clear();
                HomePage();
            }

            int result = Int32.Parse(userInput);
            switch (result)
            {
                case 0:
                    Environment.Exit(0);
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
        catch
        {
            Console.Clear();
            HomePage();
        }
    }
}
