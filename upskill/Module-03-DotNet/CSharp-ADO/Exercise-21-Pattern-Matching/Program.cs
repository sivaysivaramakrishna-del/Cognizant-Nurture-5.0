// C# Exercise 21
object[] registrationInputs =
[
    new EventRegistration("Tech Innovators Meetup", 5),
    new EventRegistration("Design Workshop", 0),
    new OnlineRegistration("Cloud Summit", "https://portal.example.com/register"),
    "Walk-in registration",
    42
];

Console.WriteLine("Pattern Matching with is and switch\n");

foreach (var input in registrationInputs)
{
    Console.WriteLine(DescribeWithIsPattern(input));
    Console.WriteLine(DescribeWithSwitchPattern(input));
    Console.WriteLine();
}

static string DescribeWithIsPattern(object input)
{
    if (input is EventRegistration { Seats: > 0 } openEvent)
        return $"[is] Open event: {openEvent.Title} ({openEvent.Seats} seats left)";

    if (input is EventRegistration fullEvent)
        return $"[is] Full event: {fullEvent.Title}";

    if (input is OnlineRegistration online)
        return $"[is] Online registration: {online.EventName} at {online.RegistrationUrl}";

    if (input is string text)
        return $"[is] Manual entry: {text}";

    if (input is int code)
        return $"[is] Registration code: {code}";

    return "[is] Unknown input type";
}

static string DescribeWithSwitchPattern(object input) => input switch
{
    EventRegistration { Seats: > 0 } openEvent =>
        $"[switch] Open event: {openEvent.Title} ({openEvent.Seats} seats left)",
    EventRegistration fullEvent =>
        $"[switch] Full event: {fullEvent.Title}",
    OnlineRegistration online =>
        $"[switch] Online registration: {online.EventName} at {online.RegistrationUrl}",
    string text =>
        $"[switch] Manual entry: {text}",
    int code =>
        $"[switch] Registration code: {code}",
    _ =>
        "[switch] Unknown input type"
};

record EventRegistration(string Title, int Seats);
record OnlineRegistration(string EventName, string RegistrationUrl);
