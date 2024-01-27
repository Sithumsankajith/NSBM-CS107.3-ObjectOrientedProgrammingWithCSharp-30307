using System;

class Q3

{
    static void Main()
    {
        // Prompt user to enter a positive integer
        Console.Write("Enter a positive integer: ");
        int userInput = Convert.ToInt32(Console.ReadLine());

        // Check if the input is positive
        if (userInput > 0)
        {
            // Calculate the sum and display the result
            int sum = CalculateSum(userInput);
            Console.WriteLine($"The sum of all numbers from 1 to {userInput} is: {sum}");
        }
        else
        {
            // Display an error message for negative input
            Console.WriteLine("ERROR: Please enter a positive integer.");
        }

        Console.ReadLine(); // To keep the console window open
    }

    // Function to calculate the sum of all numbers from 1 to a given positive integer
    static int CalculateSum(int n)
    {
        return (n * (n + 1)) / 2;
    }
}
