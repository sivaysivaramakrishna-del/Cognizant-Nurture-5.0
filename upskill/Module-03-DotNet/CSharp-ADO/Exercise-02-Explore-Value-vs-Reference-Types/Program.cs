// C# Exercise 2
Console.WriteLine("Value Type vs Reference Type Demonstration\n");

int attendanceScore = 80;
var trainee = new TraineeProfile("Alice Johnson", "New York");

Console.WriteLine("Before UpdateProfile method:");
Console.WriteLine($"  attendanceScore (value type): {attendanceScore}");
Console.WriteLine($"  trainee.City (reference type): {trainee.City}");

UpdateProfile(attendanceScore, trainee);

Console.WriteLine("\nAfter UpdateProfile method:");
Console.WriteLine($"  attendanceScore (value type): {attendanceScore}");
Console.WriteLine("  Explanation: int is copied, so the original value stays 80.");
Console.WriteLine($"  trainee.City (reference type): {trainee.City}");
Console.WriteLine("  Explanation: class objects are shared by reference, so the city changed.");

static void UpdateProfile(int score, TraineeProfile profile)
{
    score = 100;
    profile.City = "Chicago";
}

class TraineeProfile(string name, string city)
{
    public string Name { get; } = name;
    public string City { get; set; } = city;
}
