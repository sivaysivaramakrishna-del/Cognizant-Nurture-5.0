// C# Exercise 5
var students = new (string Name, int Score)[]
{
    ("Alice Johnson", 92),
    ("Bob Smith", 78),
    ("Carol Lee", 64),
    ("Dan Miller", 55),
    ("Eva Brown", 88)
};

Console.WriteLine("Student Grade Report\n");
Console.WriteLine($"{"Student",-16} {"Score",5} {"If/Else",-8} {"Switch",-8}");
Console.WriteLine(new string('-', 42));

foreach (var student in students)
{
    var gradeIfElse = CalculateGradeWithIfElse(student.Score);
    var gradeSwitch = CalculateGradeWithSwitch(student.Score);
    Console.WriteLine($"{student.Name,-16} {student.Score,5} {gradeIfElse,-8} {gradeSwitch,-8}");
}

static string CalculateGradeWithIfElse(int score)
{
    if (score >= 90) return "A";
    if (score >= 80) return "B";
    if (score >= 70) return "C";
    if (score >= 60) return "D";
    return "F";
}

static string CalculateGradeWithSwitch(int score) => score switch
{
    >= 90 and <= 100 => "A",
    >= 80 => "B",
    >= 70 => "C",
    >= 60 => "D",
    >= 0 => "F",
    _ => "Invalid"
};
