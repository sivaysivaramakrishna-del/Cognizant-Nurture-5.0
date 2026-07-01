// C# Exercise 17
var contacts = new List<Contact>
{
    new("Alice Johnson", new Address("New York", "10001", "USA"), "alice@example.com", "555-0100"),
    new("Bob Smith", null, "bob@example.com", "555-0101"),
    new("Incomplete Record", new Address("Chicago", null, "USA"), null, null)
};

Console.WriteLine("Null Conditional Chaining — Contact Directory\n");
Console.WriteLine($"{"Name",-20} {"City",-12} {"Country",-10} {"Email",-22} Phone");
Console.WriteLine(new string('-', 80));

foreach (var contact in contacts)
{
    var name = contact?.Name ?? "Unknown";
    var city = contact?.Address?.City ?? "N/A";
    var country = contact?.Address?.Country ?? "N/A";
    var email = contact?.Email?.ToLowerInvariant() ?? "No email";
    var phone = contact?.PhoneNumber ?? "No phone";

    Console.WriteLine($"{name,-20} {city,-12} {country,-10} {email,-22} {phone}");
}

class Contact(string? name, Address? address, string? email, string? phoneNumber)
{
    public string? Name { get; } = name;
    public Address? Address { get; } = address;
    public string? Email { get; } = email;
    public string? PhoneNumber { get; } = phoneNumber;
}

class Address(string? city, string? zipCode, string? country)
{
    public string? City { get; } = city;
    public string? ZipCode { get; } = zipCode;
    public string? Country { get; } = country;
}
