// C# Exercise 19
using MySqlConnector;

string connectionString = Environment.GetEnvironmentVariable("UPSKILL_DB_CONNECTION")
    ?? "Server=localhost;Database=upskill_events;User=root;Password=;";

try
{
    await using var connection = new MySqlConnection(connectionString);
    await connection.OpenAsync();

    const string selectSql = """
        SELECT e.event_id, e.title, e.city, e.status, e.start_date, u.full_name AS organizer
        FROM events e
        LEFT JOIN users u ON u.user_id = e.organizer_id
        WHERE e.status = @status
        ORDER BY e.start_date
        """;

    await using var command = new MySqlCommand(selectSql, connection);
    command.Parameters.AddWithValue("@status", "upcoming");

    await using var reader = await command.ExecuteReaderAsync();

    Console.WriteLine("ADO.NET Read — Upcoming Events from upskill_events\n");
    Console.WriteLine($"{"ID",-4} {"Title",-28} {"City",-14} {"Organizer",-16} Start Date");
    Console.WriteLine(new string('-', 88));

    var rowCount = 0;
    while (await reader.ReadAsync())
    {
        rowCount++;
        var eventId = reader.GetInt32("event_id");
        var title = reader.GetString("title");
        var city = reader.GetString("city");
        var organizer = reader.IsDBNull(reader.GetOrdinal("organizer"))
            ? "Not assigned"
            : reader.GetString("organizer");
        var startDate = reader.GetDateTime("start_date");

        Console.WriteLine($"{eventId,-4} {title,-28} {city,-14} {organizer,-16} {startDate:yyyy-MM-dd HH:mm}");
    }

    Console.WriteLine($"\nTotal rows read: {rowCount}");
}
catch (MySqlException ex)
{
    Console.WriteLine($"Database error: {ex.Message}");
    Console.WriteLine("Ensure MySQL is running with upskill_events loaded from schema.sql and sample_data.sql.");
    Console.WriteLine("Set UPSKILL_DB_CONNECTION if using non-default credentials.");
}
