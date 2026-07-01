// C# Exercise 12
var report = new ExamReport { StudentName = "Arjun Mehta", Marks = 78 };

Console.WriteLine("Properties with Validation\n");
Console.WriteLine($"{report.StudentName} scored {report.Marks} marks.");

try
{
    report.Marks = 105;
}
catch (ArgumentOutOfRangeException ex)
{
    Console.WriteLine($"Validation blocked invalid marks: {ex.Message}");
}

report.Marks = 85;
Console.WriteLine($"Updated marks for {report.StudentName}: {report.Marks}");

class ExamReport
{
    private int marks;

    public string StudentName { get; set; } = "";

    public int Marks
    {
        get => marks;
        set => marks = value is < 0 or > 100
            ? throw new ArgumentOutOfRangeException(nameof(value), "Marks must be between 0 and 100.")
            : value;
    }
}
