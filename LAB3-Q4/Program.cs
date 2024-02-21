using System;

public class Shape
{
    public string ShapeType { get; protected set; }
    public double Area { get; protected set; }

    public Shape()
    {
        ShapeType = "";
        Area = 0;
    }

    public virtual void CalculateArea(double val1, double val2)
    {
        // To be implemented by subclasses
    }

    public virtual void DisplayShapeInfo()
    {
        Console.WriteLine($"Shape Type: {ShapeType}");
        Console.WriteLine($"Area: {Area}");
    }
}

public class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(double length, double width)
    {
        ShapeType = "Rectangle";
        this.length = length;
        this.width = width;
        CalculateArea(length, width);
    }

    public override void CalculateArea(double length, double width)
    {
        Area = length * width;
    }

    public override void DisplayShapeInfo()
    {
        base.DisplayShapeInfo();
        Console.WriteLine($"Length: {length}");
        Console.WriteLine($"Width: {width}");
    }
}

public class Circle : Shape
{
    private double radius;

    public Circle(double radius)
    {
        ShapeType = "Circle";
        this.radius = radius;
        
    }

    public override void CalculateArea(double val1, double val2)
    {
        Area = Math.PI * radius * radius;
    }

    public override void DisplayShapeInfo()
    {
        base.DisplayShapeInfo();
        Console.WriteLine($"Radius: {radius}");
    }
}

class Program
{
    static void Main()
    {
        
        Rectangle rectangle = new Rectangle(5, 3);
       
        rectangle.DisplayShapeInfo();

        Circle circle = new Circle(4);
        circle.DisplayShapeInfo();
        Console.ReadLine();
    }
}