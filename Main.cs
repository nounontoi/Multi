using System;

public class Home
{
    public static void Main(string[] args)
    {
        // HomePage();
        Startup();
    }

    public static void Startup()
    {
        // Large ASCII art of 'MULTI'
        string multiASCII = @"
         __    __   __  __   __       ______  __   
        /\ \-./  \ /\ \/\ \ /\ \     /\__  _\/\ \  
        \ \ \-./\ \\ \ \_\ \\ \ \____\/_/\ \/\ \ \ 
         \ \_\ \ \_\\ \_____\\ \_____\  \ \_\ \ \_\
          \/_/  \/_/ \/_____/ \/_____/   \/_/  \/_/
        ";
        Console.WriteLine(multiASCII);

        // Takes two user integer inputs, then returns the second input
        Console.WriteLine("Multiply:");

        int result1 = 0;
        int result2 = 0;

        string a = Console.ReadLine();
        try
        {
            if (a == string.Empty)
            {
                Console.Clear();
                Startup();
            }
            result1 = Int32.Parse(a);
        }
        catch
        {
            Console.Clear();
            Startup();
        }

        Console.WriteLine("with:");
        string b = Console.ReadLine();
        try
        {
            if (b == string.Empty)
            {
                Console.Clear();
                Startup();
            }
            result2 = Int32.Parse(b);
        }
        catch
        {
            Console.Clear();
            Startup();
        }
        Console.WriteLine("Answer:" + b);

        // Takes user to HomePage()
        Console.ReadLine();
        HomePage();
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
