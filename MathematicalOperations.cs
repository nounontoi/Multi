using System;
using System.Collections.Generic;

namespace AlexsTrustyCode
{
    public class MathematicalOperations
    {
        public int Add(int a, int b)
        {
            int c = a + b;
            return a;
        }

        public int Subtract(int a, int b)
        {
            int c = a - b;
            return a;
        }

        public int Multiply(int a, int b)
        {
            int c = a * b;
            return a;
        }

        public int Divide(int a, int b)
        {
            int c = a / b;
            return a;
        }

        public MathematicalOperations()
        {
            Console.WriteLine("Do you trust my code?");

            Algorithms algorithms = new Algorithms();

            algorithms.LinearSearch();
        }

        public static void Main(string[] args)
        {
            MathematicalOperations math = new MathematicalOperations();
        }
    }

    public class Algorithms
    {
        // public int[] MakeNumberArray()
        // {
        //     List<int> numberList = new List<int>();
        //     for (int i = 0; i < 100; i++)
        //     {
        //         Random rnd = new Random();
        //         numberList.Add(rnd.Next(0, 100));
        //     }
        //     return numberList.ToArray();
        // }

        public void LinearSearch()
        {
            bool foundNumber = false;
            // MakeNumberArray();
            List<int> numberList = new List<int>();
            for (int i = 0; i < 100; i++)
            {
                Random rnd = new Random();
                numberList.Add(rnd.Next(0, 100));
            }

            Console.WriteLine("Input a search query");
            string searchQuery = Console.ReadLine();

            try
            {
                int result = Int32.Parse(searchQuery);
                // Console.WriteLine(numVal);
                for (int i = 0; i < numberList.Count; i++)
                {
                    if (numberList[i] == result)
                    {
                        foundNumber = true;
                    }
                }

                Random rnd = new Random();
                int index = rnd.Next(0, numberList.Count);
                int value = numberList[index];

                Console.WriteLine("The value " + value + " exists at index " + index + ".");
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine("Input anything to continue, or enter to quit.");
            string cont = Console.ReadLine();
            if (cont != string.Empty)
            {
                LinearSearch();
            }
        }
    }
}
