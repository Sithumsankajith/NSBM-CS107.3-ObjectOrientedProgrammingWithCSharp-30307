using System;

class Q5

{
    static void Main()
    {
        // Prompt user to enter a number
        Console.Write("Enter a number to display its multiplication table: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Display the multiplication table using a loop
        Console.WriteLine($"Multiplication table of {number}:");

        for (int i = 1; i <= 10; i++)
        {
            int result = number * i;
            Console.WriteLine($"{number} * {i} = {result}");
        }

        Console.ReadLine(); // To keep the console window open
    }
}
