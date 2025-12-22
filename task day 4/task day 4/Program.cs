using System;

interface Shape
{
    double GetArea();
}

class Circle : Shape
{
    double radius;

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public double GetArea()
    {
        return Math.PI * radius * radius;
    }
}

class Rectangle : Shape
{
    double length;
    double width;

    public Rectangle(double length, double width)
    {
        this.length = length;
        this.width = width;
    }

    public double GetArea()
    {
        return length * width;
    }
}

class Square : Shape
{
    double side;

    public Square(double side)
    {
        this.side = side;
    }

    public double GetArea()
    {
        return side * side;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Shape circle = new Circle(5);
        Shape rectangle = new Rectangle(4, 6);
        Shape square = new Square(3);

        Console.WriteLine("Circle Area: " + circle.GetArea());
        Console.WriteLine("Rectangle Area: " + rectangle.GetArea());
        Console.WriteLine("Square Area: " + square.GetArea());
    }
}
