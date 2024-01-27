using System;

class Q1

{
    static void Main()
    {
        // Prompt user to enter length and width
        Console.Write("Enter the length of the rectangle: ");
        double length = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the width of the rectangle: ");
        double width = Convert.ToDouble(Console.ReadLine());

        // Calculate and display the area
        double area = CalculateArea(length, width);
        Console.WriteLine($"The area of the rectangle is: {area}");

        Console.ReadLine(); // To keep the console window open
    }

    // Function to calculate the area of a rectangle
    static double CalculateArea(double length, double width)
    {
        return length * width;
    }
}

