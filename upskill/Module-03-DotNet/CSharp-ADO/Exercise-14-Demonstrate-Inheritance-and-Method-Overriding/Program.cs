// C# Exercise 14
Shape[] shapes =
[
    new Circle("Red", 5),
    new Rectangle("Blue", 4, 6)
];

Console.WriteLine("Inheritance and Method Overriding — Shape Example\n");

foreach (var shape in shapes)
{
    shape.Draw();
    Console.WriteLine($"  Area: {shape.GetArea():F2}\n");
}

abstract class Shape(string color)
{
    protected string Color { get; } = color;

    public abstract double GetArea();

    public virtual void Draw() =>
        Console.WriteLine($"Drawing {GetType().Name} in {Color}");
}

class Circle(string color, double radius) : Shape(color)
{
    public override double GetArea() => Math.PI * radius * radius;

    public override void Draw()
    {
        base.Draw();
        Console.WriteLine($"  Radius: {radius}");
    }
}

class Rectangle(string color, double width, double height) : Shape(color)
{
    public override double GetArea() => width * height;

    public override void Draw()
    {
        base.Draw();
        Console.WriteLine($"  Width: {width}, Height: {height}");
    }
}
