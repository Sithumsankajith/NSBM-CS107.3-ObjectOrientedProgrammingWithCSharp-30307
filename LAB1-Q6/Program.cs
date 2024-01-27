using System;

class Q6

{
    static void Main()
    {
        // Prompt user to input student's name
        Console.Write("Enter student's name: ");
        string studentName = Console.ReadLine();

        // Prompt user to input exam marks with validation
        int marks;
        do
        {
            Console.Write("Enter exam marks (0-100): ");
            if (int.TryParse(Console.ReadLine(), out marks) && marks >= 0 && marks <= 100)
            {
                break;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid marks between 0 and 100.");
            }
        } while (true);

        // Determine and display the corresponding grade
        string grade = DetermineGrade(marks);
        Console.WriteLine($"{studentName}'s grade is: {grade}");

        Console.ReadLine(); // To keep the console window open
    }

    // Function to determine the grade based on marks
    static string DetermineGrade(int marks)
    {
        if (marks >= 75 && marks <= 100)
            return "A";
        else if (marks >= 60 && marks <= 74)
            return "B";
        else if (marks >= 50 && marks <= 59)
            return "C";
        else if (marks >= 40 && marks <= 49)
            return "D";
        else
            return "Failed";
    }
}
