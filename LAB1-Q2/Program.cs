using System;

class Q2

{
    static void Main()
    {
        // Prompt user to enter 10 numbers
        for (int i = 1; i <= 10; i++)
        {
            Console.Write($"Enter number #{i}: ");
            int number = Convert.ToInt32(Console.ReadLine());

            // Check if the number is even or odd and display the result
            if (IsEven(number))
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }

        Console.ReadLine(); // To keep the console window open
    }

    // Function to check if a number is even
    static bool IsEven(int number)
    {
        return number % 2 == 0;
    }
}
