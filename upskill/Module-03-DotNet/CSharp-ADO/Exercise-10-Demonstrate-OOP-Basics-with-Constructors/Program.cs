// C# Exercise 10
var defaultCourse = new TrainingCourse();
var customCourse = new TrainingCourse("Advanced C#", 40, "Virtual");

Console.WriteLine("Constructor Demonstration\n");
Console.WriteLine("Default constructor (chained to parameterized):");
defaultCourse.Display();

Console.WriteLine("\nParameterized constructor:");
customCourse.Display();

class TrainingCourse
{
    public string Title { get; }
    public int DurationHours { get; }
    public string DeliveryMode { get; }

    public TrainingCourse() : this("C# Fundamentals", 24, "Classroom") { }

    public TrainingCourse(string title, int durationHours, string deliveryMode)
    {
        Title = title;
        DurationHours = durationHours;
        DeliveryMode = deliveryMode;
    }

    public void Display() =>
        Console.WriteLine($"  {Title} | {DurationHours} hours | Mode: {DeliveryMode}");
}
