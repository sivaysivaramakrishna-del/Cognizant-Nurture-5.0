// C# Exercise 18
var employee = new EmployeeProfile
{
    EmployeeId = "EMP-204",
    FullName = "Nina Patel",
    Department = "Learning and Development",
    Email = "nina.patel@example.com"
};

Console.WriteLine("Required Modifier — Employee Onboarding\n");
employee.Display();

class EmployeeProfile
{
    public required string EmployeeId { get; init; }
    public required string FullName { get; init; }
    public required string Department { get; init; }
    public required string Email { get; init; }

    public void Display() =>
        Console.WriteLine($"Employee {EmployeeId}: {FullName} | {Department} | {Email}");
}
