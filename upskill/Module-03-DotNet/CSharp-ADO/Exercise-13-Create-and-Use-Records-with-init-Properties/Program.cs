// C# Exercise 13
var employee = new EmployeeRecord(101, "Alice Johnson", "Engineering", 85000m);
var transferred = employee with { Department = "Cloud Practice", Salary = 92000m };

Console.WriteLine("Employee Record with with-expression\n");
Console.WriteLine("Original record:");
employee.Display();

Console.WriteLine("\nAfter department transfer:");
transferred.Display();

record EmployeeRecord(int Id, string Name, string Department, decimal Salary)
{
    public void Display() =>
        Console.WriteLine($"  Id: {Id} | {Name} | {Department} | Salary: ${Salary:N0}");
}
