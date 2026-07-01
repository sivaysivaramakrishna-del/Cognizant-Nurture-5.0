// C# Exercise 4
Console.WriteLine("Type Inference with var and target-typed new\n");

var workshopCount = 4;
var workshopTitle = "Cloud Fundamentals";
List<string> hostCities = new() { "New York", "Chicago", "Seattle", "Boston" };
Dictionary<int, string> sessionAgenda = new()
{
    [1] = "Introduction to Cloud",
    [2] = "Hands-on Lab",
    [3] = "Q&A Session"
};

Console.WriteLine($"var workshopCount   -> Type: {workshopCount.GetType().Name}, Value: {workshopCount}");
Console.WriteLine($"var workshopTitle   -> Type: {workshopTitle.GetType().Name}, Value: {workshopTitle}");
Console.WriteLine($"List with new()     -> Type: {hostCities.GetType().Name}");
Console.WriteLine($"  Cities: {string.Join(", ", hostCities)}");
Console.WriteLine($"Dictionary with new()-> Type: {sessionAgenda.GetType().Name}");

foreach (var session in sessionAgenda)
    Console.WriteLine($"  Session {session.Key}: {session.Value}");
