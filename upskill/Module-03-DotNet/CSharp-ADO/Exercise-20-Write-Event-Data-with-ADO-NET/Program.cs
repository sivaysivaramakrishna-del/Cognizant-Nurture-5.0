// C# Exercise 20
using MySqlConnector;

string connectionString = Environment.GetEnvironmentVariable("UPSKILL_DB_CONNECTION")
    ?? "Server=localhost;Database=upskill_events;User=root;Password=;";

const int userId = 6;
const int eventId = 3;
var registrationDate = DateOnly.FromDateTime(DateTime.Today);

try
{
    await using var connection = new MySqlConnection(connectionString);
    await connection.OpenAsync();

    Console.WriteLine("ADO.NET Write — Insert and Update Operations\n");

    const string insertSql = """
        INSERT INTO registrations (user_id, event_id, registration_date)
        VALUES (@userId, @eventId, @registrationDate)
        """;

    await using var insertCommand = new MySqlCommand(insertSql, connection);
    insertCommand.Parameters.AddWithValue("@userId", userId);
    insertCommand.Parameters.AddWithValue("@eventId", eventId);
    insertCommand.Parameters.AddWithValue("@registrationDate", registrationDate);

    var insertedRows = await insertCommand.ExecuteNonQueryAsync();
    Console.WriteLine($"INSERT: {insertedRows} row(s) added.");
    Console.WriteLine($"  Registered user {userId} for event {eventId} on {registrationDate:yyyy-MM-dd}.");

    const string updateSql = """
        UPDATE events
        SET description = @description
        WHERE event_id = @eventId
        """;

    await using var updateCommand = new MySqlCommand(updateSql, connection);
    updateCommand.Parameters.AddWithValue("@description", "Registration confirmed via ADO.NET write exercise.");
    updateCommand.Parameters.AddWithValue("@eventId", eventId);

    var updatedRows = await updateCommand.ExecuteNonQueryAsync();
    Console.WriteLine($"UPDATE: {updatedRows} row(s) modified.");
    Console.WriteLine($"  Event {eventId} description updated successfully.");
}
catch (MySqlException ex) when (ex.Number == 1062)
{
    Console.WriteLine("INSERT skipped: registration already exists for this user and event.");
    Console.WriteLine("The parameterized INSERT still demonstrates ADO.NET write operations.");
}
catch (MySqlException ex)
{
    Console.WriteLine($"Database error: {ex.Message}");
    Console.WriteLine("Ensure MySQL is running with upskill_events loaded from schema.sql and sample_data.sql.");
    Console.WriteLine("Set UPSKILL_DB_CONNECTION if using non-default credentials.");
}
