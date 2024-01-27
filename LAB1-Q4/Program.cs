using System;

class Q4

{
    static void Main()
    {
        // Prompt user to enter the value of N
        Console.Write("Enter the value of N for Fibonacci series: ");
        int n = Convert.ToInt32(Console.ReadLine());

        // Check if the input is non-negative
        if (n >= 0)
        {
            // Print the first N terms of the Fibonacci series
            Console.WriteLine($"Fibonacci series up to {n} terms:");
            for (int i = 0; i < n; i++)
            {
                Console.Write(Fibonacci(i) + " ");
            }
        }
        else
        {
            // Display an error message for negative input
            Console.WriteLine("ERROR: Please enter a non-negative integer.");
        }

        Console.ReadLine(); // To keep the console window open
    }

    // Recursive function to calculate the Fibonacci series term at position n
    static int Fibonacci(int n)
    {
        if (n <= 1)
            return n;
        else
            return Fibonacci(n - 1) + Fibonacci(n - 2);
    }
}

