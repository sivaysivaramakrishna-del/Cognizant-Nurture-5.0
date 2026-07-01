// C# Exercise 11
var student = new Student("Riya Sharma", 101, "Computer Science");
var mentor = new Mentor();

Console.WriteLine("Access Modifiers in a Student Management Example\n");
student.ShowProfileFromStudent();
mentor.ReviewStudent(student);

class Person
{
    public string Name { get; }
    private int Id { get; }
    protected string Status { get; } = "Active";

    public Person(string name, int id)
    {
        Name = name;
        Id = id;
    }

    public string GetIdForDisplay() => Id.ToString();
}

class Student : Person
{
    public string Department { get; }

    public Student(string name, int id, string department) : base(name, id)
    {
        Department = department;
    }

    public void ShowProfileFromStudent() =>
        Console.WriteLine($"Student view -> Name: {Name}, Id: {GetIdForDisplay()}, Department: {Department}, Status: {Status}");
}

class Mentor
{
    public void ReviewStudent(Student student) =>
        Console.WriteLine($"Mentor view  -> Name: {student.Name}, Id: {student.GetIdForDisplay()} (private Id accessed through public method)");
}
