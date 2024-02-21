using System;

public class Course
{
   
    private string courseName;
    private string instructorName;
    private double grade;


    public string CourseName
    {
        get { return courseName; }
    }

    public double Grade
    {
        get { return grade; }
    }

    public Course(string courseName, string instructorName, double grade)
    {
        this.courseName = courseName;
        this.instructorName = instructorName;
        SetGrade(grade);
    }

    
    public void SetInstructorName(string instructorName)
    {
        if (string.IsNullOrWhiteSpace(instructorName))
        {
            throw new ArgumentException("Instructor name cannot be empty or null.");
        }
        this.instructorName = instructorName;
    }

   
    private string CalculateLetterGrade()
    {
        if (grade >= 90)
        {
            return "A";
        }
        else if (grade >= 80)
        {
            return "B";
        }
        else if (grade >= 70)
        {
            return "C";
        }
        else if (grade >= 60)
        {
            return "D";
        }
        else
        {
            return "F";
        }
    }

    
    public void PrintCourseInfo()
    {
        string letterGrade = CalculateLetterGrade();
        Console.WriteLine($"Course Name: {courseName}");
        Console.WriteLine($"Instructor Name: {instructorName}");
        Console.WriteLine($"Letter Grade: {letterGrade}");
    }

    
    private void SetGrade(double grade)
    {
        if (grade < 0 || grade > 100)
        {
            throw new ArgumentException("Grade must be between 0 and 100.");
        }
        this.grade = grade;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Course course = new Course("Computer Science", "Dr. Smith", 85);
        course.SetInstructorName("Prof. Johnson"); 
        course.PrintCourseInfo(); 
        Console.ReadLine();
    }
}
