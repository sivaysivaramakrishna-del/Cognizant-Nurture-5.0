// C# Exercise 16
Console.WriteLine("Null Safety with ? and ?? operators\n");

string? preferredCity = GetPreferredCity("Alice");
string? missingCity = GetPreferredCity(null);
string? emptyCity = GetPreferredCity("");

Console.WriteLine($"Preferred city: {preferredCity ?? "City not assigned"}");
Console.WriteLine($"Missing input:  {missingCity ?? "City not assigned"}");
Console.WriteLine($"Empty input:    {emptyCity ?? "City not assigned"}");

Console.WriteLine();
Console.WriteLine($"Welcome message: {BuildWelcomeMessage("Alice") ?? "Guest user"}");
Console.WriteLine($"Welcome message: {BuildWelcomeMessage(null) ?? "Guest user"}");

static string? GetPreferredCity(string? userName)
{
    if (userName is null)
        return null;

    return userName.Length > 0 ? "New York" : null;
}

static string? BuildWelcomeMessage(string? name) =>
    name is { Length: > 0 } validName ? $"Welcome, {validName}!" : null;
