// C# Exercise 3
var developer = new Employee(101, "Alice Johnson", "Software Engineering", 78000m);
var analyst = new Employee(102, "Bob Smith", "Business Analysis", 65000m);

Console.WriteLine("Employee details using primary constructors:\n");
developer.DisplayDetails();
analyst.DisplayDetails();

developer.ApplyAnnualRaise(0.10m);
Console.WriteLine("\nAfter 10% raise for Alice:");
developer.DisplayDetails();

class Employee(int id, string fullName, string department, decimal salary)
{
    public int Id { get; } = id;
    public string FullName { get; } = fullName;
    public string Department { get; } = department;
    public decimal Salary { get; private set; } = salary;

    public void ApplyAnnualRaise(decimal percentage) =>
        Salary += Salary * percentage;

    public void DisplayDetails() =>
        Console.WriteLine($"  Id: {Id} | {FullName} | {Department} | Salary: ${Salary:N2}");
}
